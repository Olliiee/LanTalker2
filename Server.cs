using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using FSUIPC;

namespace LanTalker2
{
    /// <summary>
    /// Server class
    /// </summary>
    public class Server
    {
        private TcpListener tcpListener;                                    //tcpListener - waiting for incoming tcp connections
        private Thread listenThread;                                        //listenThread - one thread for each client connection
        LanTalker2.Lib.stringLib byter = new Lib.stringLib();               //byter - class for coneverting strings and logging
        LanTalker2.Lib.fsuipcError uipcerror = new Lib.fsuipcError();       //uipcerror - handling uipc error msg
        public bool debugger;                                               //debugger - if debug mode is active or not
        LanTalker2.Parser parser = new LanTalker2.Parser();                 //parser - class for parsing a msg for the fs

        const String lanTalker = "FS LanTalker V2.0 (C) Oliver Strauss 2011";

        /// <summary>
        /// Starting the server
        /// </summary>
        /// <param name="debug">if debug mode is active (true) or not (false)</param>
        public void startServer(bool debug)
        {
            debugger = debug;
            
            this.tcpListener = new TcpListener(IPAddress.Any, 3000);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
            byter.screamer(lanTalker, true, debugger);
            
            if (debugger == true)
                byter.screamer("Running in debug-mode", false, debugger);

            byter.screamer("Server is running ..", true, debugger);
            
            string HostName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostByName(HostName);
            string IpAdresse = hostInfo.AddressList[0].ToString();
            byter.screamer("Server IP " + IpAdresse, true, debugger);

            try
            {
                FSUIPCConnection.Open();
                byter.screamer("Connected to Microsoft Flight Simulator " + FSUIPCConnection.FlightSimVersionConnected, true, debugger);
                byter.screamer("Uses the FSUIPC Client DLL for .NET by Paul Henty V" + FSUIPCConnection.DLLVersion, true, debugger);
            }
            catch (FSUIPCException ex)
            {
                byter.screamer(uipcerror.errorMsg(ex), true, debugger);
                byter.screamer("Closing", true, debugger);
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }

        

        private void ListenForClients()
        {
            this.tcpListener.Start();            

            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                NetworkStream clientStream = client.GetStream();

                //create a thread to handle communication
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));

                Byte[] data = byter.StringToByteArray("TalkerV:1");
                clientStream.Write(data, 0, data.Length);
                byter.screamer("Client connected " + client.Client.RemoteEndPoint, true, debugger);

                clientThread.Start(client);  
            }  
        }


        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            bool init = true;
            int protVersion = 0;

            if (tcpClient.Connected == true)
            {
                NetworkStream clientStream = tcpClient.GetStream();
                clientStream.ReadTimeout = 5000;
                


                byte[] message = new byte[4096];
                int bytesRead;
                string readMessage;

                while (true)
                {
                    bytesRead = 0;

                    try
                    {
                        //blocks until a client sends a message
                        bytesRead = clientStream.Read(message, 0, 4096);
                    }
                    catch (TimeoutException ex)
                    {
                        byter.screamer("Timeout for reading client data. Error: " + ex, false, debugger);
                        break;
                    }
                    catch
                    {
                        //a socket error has occured
                        break;
                    }

                    if (bytesRead == 0)
                    {
                        //the client has disconnected from the server
                        break;
                    }

                    //message has successfully been received
                    ASCIIEncoding encoder = new ASCIIEncoding();


                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(encoder.GetString(message, 0, bytesRead));
                    byter.screamer("Original Msg: " + byter.ByteArrayToString(data), false, debugger);
                    readMessage = byter.ByteArrayToString(data);

                    if (init == true)
                    {
                        if (initProt(readMessage, client) > 0)
                            init = true;
                    }
                    else if (init == false)
                    {
                        if (protVersion == 1)
                        {
                            protV1(readMessage, client);
                        }
                    }
                }
                sendMsg("CLOSE", client);
                tcpClient.Close();
                byter.screamer("Connection closed to " + tcpClient.Client.RemoteEndPoint, false, debugger);

            }
        }

        private int initProt(string readMessage, object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            int protVersion = 0;
            if (readMessage == "TalkerV:1:OK")
            {
                protVersion = 1;
                byter.screamer("Protocol Version set to V1", false, debugger);
            }
            else if (readMessage.Contains("TalkerV:NOK") == true)
            {
                string[] msgArray = readMessage.Split(':');
                if (msgArray[2] == "1")
                {
                    protVersion = 1;
                    //data = byter.StringToByteArray("TalkerV:" + protVersion.ToString() + ":OK");
                    //clientStream.Write(data, 0, data.Length);
                    sendMsg("TalkerV:" + protVersion.ToString() + ":OK", client);
                    byter.screamer("Protocol Version set to V" + protVersion.ToString(), false, debugger);
                }
                else
                {
                    //data = byter.StringToByteArray("TalkerV:NOK");
                    //clientStream.Write(data, 0, data.Length);
                    sendMsg("TalkerV:NOK", client);
                                
                    //data = byter.StringToByteArray("CLOSE");
                    //clientStream.Write(data, 0, data.Length);
                    sendMsg("CLOSE", client);
                    clientStream.Close();
                    byter.screamer("Unable to set a new protocol version. Connection closed!", false, debugger);
                }                            
            }
            return protVersion;
        }

        private bool sendMsg(string msg, object client)
        {
            try
            {
                TcpClient tcpClient = (TcpClient)client;
                NetworkStream clientStream = tcpClient.GetStream();
                clientStream.WriteTimeout = 5000;

                Byte[] data = byter.StringToByteArray(msg);

                clientStream.Write(data, 0, data.Length);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void protV1(string readMessage, object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            if (readMessage == "CLOSE")
            {
                tcpClient.Close();
                byter.screamer("Connection closed by " + tcpClient.Client.RemoteEndPoint, false, debugger);
            }
            else if (readMessage.Contains("|"))
            {
                string[] msgArray = readMessage.Split('|');
                List<string> resultList = new List<string>();
                int i = 0;

                foreach (string msg in msgArray)
                {
                    byter.screamer("Parsing Msg: " + parser.parseText(msg), false, debugger);
                    resultList.Add(parser.parseText(msg));
                    i++;
                }

                string[] resultArray = new string[i];
                i = 0;
                foreach (string msg in resultList)
                {
                    resultArray[i++] = msg;
                }
                byter.screamer("Send Msg to " + tcpClient.Client.RemoteEndPoint, false, debugger);
                //data = byter.StringToByteArray(byter.ConvertStringArrayToString(resultArray));
                //clientStream.Write(data, 0, data.Length);
                sendMsg(byter.ConvertStringArrayToString(resultArray), client);
            }
            else
            {
                if (readMessage.Contains(":") == true)
                {
                    readMessage = parser.parseText(readMessage);
                    byter.screamer("Parsing Msg: " + readMessage, false, debugger);

                    byter.screamer("Send Msg to " + tcpClient.Client.RemoteEndPoint, false, debugger);
                    //data = byter.StringToByteArray(readMessage);
                    //clientStream.Write(data, 0, data.Length);
                    sendMsg(readMessage, client);
                }
                else
                {
                    sendMsg("REQ:NOK", client);
                }
            }
        }
    }
}

