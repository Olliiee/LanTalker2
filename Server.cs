using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using FSUIPC;
using System.Diagnostics;
using Newtonsoft.Json;
using Offsets;

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
            

            //Starting the tcpclient to listen for clients
            try
            {
                this.tcpListener = new TcpListener(IPAddress.Any, 3000);
                this.listenThread = new Thread(new ThreadStart(ListenForClients));
                this.listenThread.Start();
            }
            catch (Exception ex)
            {
                byter.screamer("Unable to listen for clients: " + ex, true, debugger);
                byter.screamer("Closing", true, debugger);
                Thread.Sleep(5000);

                //Can't work without a network, bye bye!
                Environment.Exit(0);
            }

            byter.screamer(lanTalker, true, debugger);

            if (debugger == true)
                byter.screamer("Running in debug-mode", false, debugger);

            byter.screamer("Server is running ..", true, debugger);
            
            //Looking for the local ip
            string HostName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostEntry(HostName);

            byter.screamer("Server IP: ", true, debugger);
            int h = 1;
            for (int i = 0; i < hostInfo.AddressList.Length; i++)
            {
                byter.screamer(h.ToString() + ") " + hostInfo.AddressList[i].ToString(), true, false);
                h++;
            }
                
            

            //Try to connect to the FS via the FSUIPC Client for .NET
            //http://forum.simflight.com/topic/40989-fsuipc-client-dll-for-net-version-20/
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

        
        /// <summary>
        /// Psssssst, the clients are talking, I listen to them
        /// </summary>
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

                //Version 1 is current in use, that's what we want.
                Byte[] data = byter.StringToByteArray("TalkerV:1");
                clientStream.Write(data, 0, data.Length);
                byter.screamer("Client connected " + client.Client.RemoteEndPoint, true, debugger);

                clientThread.Start(client);  
            }  
        }

        /// <summary>
        /// The talking area
        /// </summary>
        /// <param name="client">tcpclient obeject</param>
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

                    //Encoding the received message
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(encoder.GetString(message, 0, bytesRead));
                    byter.screamer("Original Msg: " + byter.ByteArrayToString(data), false, debugger);
                    readMessage = byter.ByteArrayToString(data);
                    byter.screamer("Init is " + init.ToString(), false, debugger);

                    //Check the correct version
                    if (init == true)
                    {
                        protVersion = initProt(readMessage, client);
                        if (protVersion > 0)
                            init = false;
                    }
                    else if (init == false)
                    {
                        byter.screamer("Using ProtV " + protVersion.ToString(), false, debugger);
                        if (protVersion == 1)
                        {
                            protV1(readMessage, client);
                        }
                        else if (protVersion == 2)
                        {
                            protV2(readMessage, client);
                        }
                    }
                }
                //sendMsg("CLOSE", client);
                //tcpClient.Close();
                //byter.screamer("Connection closed to " + tcpClient.Client.RemoteEndPoint, false, debugger);

            }
        }

        /// <summary>
        /// Let's talk about the protocol
        /// </summary>
        /// <param name="readMessage">The protocol version requested by the client</param>
        /// <param name="client">tcpclient object</param>
        /// <returns>protocol version</returns>
        private int initProt(string readMessage, object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            int protVersion = 0;

            //Version 2 is what we want today
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
                    sendMsg("TalkerV:" + protVersion.ToString() + ":OK", client);
                    byter.screamer("Protocol Version set to V" + protVersion.ToString(), false, debugger);
                }
                else if (msgArray[2] == "2")
                {
                    protVersion = 2;
                    sendMsg("TalkerV:" + protVersion.ToString() + ":OK", client);
                    byter.screamer("Protocol Version set to V" + protVersion.ToString() + " (JSON)", false, debugger);
                }
                else //all the other stuff will be denied
                {
                    sendMsg("TalkerV:NOK", client);
                    sendMsg("CLOSE", client);
                    clientStream.Close();
                    byter.screamer("Unable to set a new protocol version. Connection closed!", false, debugger);
                }                            
            }
            return protVersion;
        }

        /// <summary>
        /// Sending a message to the client
        /// </summary>
        /// <param name="msg">The message, check the readme</param>
        /// <param name="client">tcpclient object</param>
        /// <returns>true message was send, false message was not send</returns>
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


        /// <summary>
        /// All the thing we can receive by using V1
        /// </summary>
        /// <param name="readMessage">The message send by the client</param>
        /// <param name="client">tcpclient object</param>
        private void protV1(string readMessage, object client)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();

            /*
             * The V1 can handle the following requests or orders:
             * TalkerV - the protocol version the server/clients like to talk
             * READ - read the following offset (READ:0560)
             * WRITE - write tot the following offset with a value (WRITE:0262:1)
             * TRAFFIC - read all traffic (TRAFFIC:POSITION)
             * CLOSE - close the connection
             * REQ - sends an reqly to the request (OK or NOK)
             */

            TcpClient tcpClient = (TcpClient)client;

            //If the message contains a "CLOSE" order
            if (readMessage == "CLOSE")
            {
                tcpClient.Close();
                byter.screamer("Connection closed by " + tcpClient.Client.RemoteEndPoint, false, debugger);
            }

            // If the messahe contais multiple requests
            else if (readMessage.Contains("|"))
            {
                string[] msgArray = readMessage.Split('|');
                List<string> resultList = new List<string>();
                int i = 0;

                // splitting the message and parse it
                foreach (string msg in msgArray)
                {
                    byter.screamer("Result: " + parser.parseText(msg), false, debugger);
                    resultList.Add(parser.parseText(msg));
                    i++;
                }

                // creatting a new array to send the reply
                string[] resultArray = new string[i];
                i = 0;
                foreach (string msg in resultList)
                {
                    resultArray[i++] = msg;
                }
                byter.screamer("Send Msg to " + tcpClient.Client.RemoteEndPoint, false, debugger);
                sendMsg(byter.ConvertStringArrayToString(resultArray), client);
            }

            // If the message contains a single request
            else
            {
                if (readMessage.Contains(":") == true)
                {
                    readMessage = parser.parseText(readMessage);
                    byter.screamer("Result: " + readMessage, false, debugger);

                    byter.screamer("Send Msg to " + tcpClient.Client.RemoteEndPoint, false, debugger);
                    sendMsg(readMessage, client);
                }
                else
                {
                    sendMsg("REQ:NOK", client);
                }
            }

            //watch.Stop();
            //byter.screamer("Time spent V1: " + watch.Elapsed, false, debugger);
        }

        /// <summary>
        /// Protocol version 2 JSON
        /// This protocol uses the JOSN.NET framework
        /// </summary>
        /// <param name="readMessage"></param>
        /// <param name="client"></param>
        private void protV2(string readMessage, object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            LanTalker2.Lib.json.RootObject root = new Lib.json.RootObject();
            Offsets.OffsetClass offsets = new OffsetClass();

            Lib.json.RootObject rootMsg = JsonConvert.DeserializeObject<Lib.json.RootObject>(readMessage);
            Lib.json.RootObject rootSend = new Lib.json.RootObject();

            if (rootMsg.READ != null && rootMsg.READ.Offset.Count > 0)
            {
                rootSend.READ.Offset = new List<string>();
                rootSend.READ.Value = new List<string>();

                for (int i = 0; i < rootMsg.READ.Offset.Count; i++)
                {
                    rootSend.READ.Offset.Add(rootMsg.READ.Offset[i]);
                    rootSend.READ.Value.Add(offsets.processData("READ", rootMsg.READ.Offset[i]));
                    /*
                     * send result as Msg via tcpclient
                     * result as an json array
                     */
                }
            }

            if (rootMsg.WRITE != null && rootMsg.WRITE.Offset.Count > 0)
            {
                rootSend.WRITE.Offset = new List<string>();
                rootSend.WRITE.Value = new List<string>();

                for (int i = 0; i < rootMsg.WRITE.Offset.Count; i++)
                {
                    rootSend.WRITE.Offset.Add(rootMsg.WRITE.Offset[i]);
                    rootSend.WRITE.Value.Add(offsets.processData("WRITE", rootMsg.READ.Offset[i], rootMsg.WRITE.Value[i]));
                    /*
                     * send result as Msg via tcpclient
                     * result as an json array
                     */
                }
            }

            if (rootMsg.TRAFFIC != null && rootMsg.TRAFFIC.Flight[0] == "Position")
            {
                rootSend.TRAFFIC.ID = new List<string>();
                rootSend.TRAFFIC.Altitude = new List<string>();
                rootSend.TRAFFIC.Callsign = new List<string>();
                rootSend.TRAFFIC.Heading = new List<string>();
                rootSend.TRAFFIC.Latitude = new List<string>();
                rootSend.TRAFFIC.Longitude = new List<string>();

                AITrafficServices AI = FSUIPCConnection.AITrafficServices;
                AI.RefreshAITrafficInformation();

                foreach (AIPlaneInfo plane in FSUIPCConnection.AITrafficServices.AllTraffic)
                {
                    rootSend.TRAFFIC.ID.Add(plane.ID.ToString());
                    rootSend.TRAFFIC.Callsign.Add(plane.ATCIdentifier);
                    rootSend.TRAFFIC.Latitude.Add(plane.Location.Latitude.DecimalDegrees.ToString());
                    rootSend.TRAFFIC.Longitude.Add(plane.Location.Longitude.DecimalDegrees.ToString());
                    rootSend.TRAFFIC.Heading.Add(plane.HeadingDegrees.ToString());
                    rootSend.TRAFFIC.Altitude.Add(plane.AltitudeFeet.ToString());
                }
            }


            if (rootMsg.ACTION != null && rootMsg.ACTION.Req.Count > 0)
            {
                for (int i = 0; i < rootMsg.ACTION.Req.Count; i++)
                {
                    if (rootMsg.ACTION.Req[i] == "CLOSE")
                    {
                        tcpClient.Close();
                        byter.screamer("Connection closed by " + tcpClient.Client.RemoteEndPoint, false, debugger);
                    }
                }
            }

            sendMsg(JsonConvert.SerializeObject(rootMsg), tcpClient);
        }
    }
}

