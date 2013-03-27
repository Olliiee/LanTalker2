using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using FSUIPC;
using Newtonsoft.Json;
using Offsets;

namespace LanTalker2.Lib
{
    class network
    {
        private TcpListener tcpListener;                                    //tcpListener - waiting for incoming tcp connections
        
        LanTalker2.Lib.stringLib logging = new Lib.stringLib();             //byter - class for coneverting strings and logging
        LanTalker2.Lib.settings settings = new Lib.settings();              //debugger - if debug mode is active or not
       

        /// <summary>
        /// Psssssst, the clients are talking, I listen to them
        /// </summary>
        public void ListenForClients(bool debug)
        {
            settings.debugger = debug;
            this.tcpListener = new TcpListener(IPAddress.Any, 3000);
            tcpListener.Start();

            

            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                NetworkStream clientStream = client.GetStream();

                //create a thread to handle communication
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));

                logging.screamer("Client connected " + client.Client.RemoteEndPoint, true, settings.debugger);

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

            if (tcpClient.Connected == true)
            {
                NetworkStream clientStream = tcpClient.GetStream();
                //clientStream.ReadTimeout = 5000;

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
                        logging.screamer("Received a mesage", settings.debugger, settings.debugger);
                    }
                    catch (TimeoutException ex)
                    {
                        logging.screamer("Timeout for reading client data. Error: " + ex, settings.debugger, settings.debugger);
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
                    logging.screamer("Original Msg: " + logging.ByteArrayToString(data), settings.debugger, settings.debugger);
                    readMessage = logging.ByteArrayToString(data);
                    sendMsg(protV2(readMessage, client), client);
                    logging.screamer("Message send", settings.debugger, settings.debugger);
                }
            }
        }



        /// <summary>
        /// Sending a message to the client
        /// </summary>
        /// <param name="msg">The message, check the readme</param>
        /// <param name="client">tcpclient object</param>
        /// <returns>true message was send, false message was not send</returns>
        public bool sendMsg(string msg, object client)
        {
            try
            {
                TcpClient tcpClient = (TcpClient)client;
                NetworkStream clientStream = tcpClient.GetStream();
                clientStream.WriteTimeout = 5000;

                Byte[] data = logging.StringToByteArray(msg);

                clientStream.Write(data, 0, data.Length);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string protV2(string readMessage, object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            Offsets.OffsetClass offsets = new OffsetClass();

            Lib.json.RootObject rootMsg = JsonConvert.DeserializeObject<Lib.json.RootObject>(readMessage);
            Lib.json.RootObject rootSend = new Lib.json.RootObject();

            if (rootMsg.READ != null && rootMsg.READ.Offset.Count > 0)
            {
                rootSend.READ = new json.READ();

                rootSend.READ.Offset = new List<string>();
                rootSend.READ.Value = new List<string>();

                for (int i = 0; i <= rootMsg.READ.Offset.Count - 1; i++)
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
                if (rootMsg.WRITE.Offset.Count == rootMsg.WRITE.Value.Count)
                {
                    rootSend.WRITE = new json.WRITE();

                    rootSend.WRITE.Offset = new List<string>();
                    rootSend.WRITE.Value = new List<string>();

                    for (int i = 0; i <= rootMsg.WRITE.Offset.Count - 1; i++)
                    {
                        
                        rootSend.WRITE.Offset.Add(rootMsg.WRITE.Offset[i]);
                        rootSend.WRITE.Value.Add(offsets.processData("WRITE", rootMsg.WRITE.Offset[i], rootMsg.WRITE.Value[i]));
                        /*
                         * send result as Msg via tcpclient
                         * result as an json array
                         */
                    }
                }
                else
                {
                    rootSend.ACTION = new json.ACTION();
                    rootSend.ACTION.Req = new List<string>();
                    rootSend.ACTION.Req.Add("ERROR_WRITE");
                }
            }

            if (rootMsg.TRAFFIC != null && rootMsg.TRAFFIC.Flight[0] == "Position")
            {
                rootSend.TRAFFIC = new json.TRAFFIC();
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
                for (int i = 0; i < rootMsg.ACTION.Req.Count - 1; i++)
                {
                    if (rootMsg.ACTION.Req[i] == "CLOSE")
                    {
                        tcpClient.Close();
                        logging.screamer("Connection closed by " + tcpClient.Client.RemoteEndPoint, settings.debugger, settings.debugger);
                    }
                    else if (rootMsg.ACTION.Req[i] == "ERROR_READ")
                    {
                        logging.screamer("Last read request could not be processed.", settings.debugger, settings.debugger);
                    }
                    else if (rootMsg.ACTION.Req[i] == "ERROR_WRITE")
                    {
                        logging.screamer("Last write request could not be processed.", settings.debugger, settings.debugger);
                    }
                }
            }
            logging.screamer("Result to Client " + JsonConvert.SerializeObject(rootSend), settings.debugger, settings.debugger);
            return JsonConvert.SerializeObject(rootSend);
        }
    }
}
