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
        Offsets.OffsetClass offsets = new OffsetClass();

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

                    //Encoding the received message
                    UTF8Encoding encoder = new UTF8Encoding();
                    
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(encoder.GetString(message, 0, bytesRead));
                    logging.screamer("Original Msg: " + logging.ByteArrayToString(data), settings.debugger, settings.debugger);
                    
                    sendMsg(protV2(encoder.GetString(message, 0, bytesRead), client), client);
                                        
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

        /// <summary>
        /// The protocl witch handles the client comunication
        /// </summary>
        /// <param name="readMessage">The received message</param>
        /// <param name="client">The TCP client object</param>
        /// <returns></returns>
        public string protV2(string readMessage, object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            
            Parser parser = new Parser();

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

                    bool cacheFound = false;
                    string indexCache = IndexOfInt(rootMsg.READ.Offset[i], "offsetCache");

                    if (indexCache == "-1")
                    {
                        indexCache = IndexOfInt(rootMsg.READ.Offset[i], "offsetSize");
                    }
                    else
                    {
                        cacheFound = true;
                    }

                    if (indexCache != "-1")
                    {
                        //string size = offsets.offsetsSize[0, index, 2];

                        //if (parser.readFsData(size, rootMsg.READ.Offset[i]) != null)
                        rootSend.READ.Value.Add(parser.readFsData(indexCache, rootMsg.READ.Offset[i]));
                        //else
                            //rootSend.READ.Value.Add("NOK");

                        if (cacheFound == false)
                        {
                            offsets.offsetCacheRead[offsets.cacheRunnerRead, 0] = rootMsg.READ.Offset[i];
                            offsets.offsetCacheRead[offsets.cacheRunnerRead++, 1] = indexCache;

                            if (offsets.cacheRunnerRead == offsets.offsetCacheRead.Length / 2)
                                offsets.cacheRunnerRead = 0;
                        }
                    }
                    else
                    {
                        rootSend.READ.Value.Add("NOK");
                    }
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
                        bool cacheFound = false;
                        string indexCache = IndexOfInt(rootMsg.WRITE.Offset[i], "offsetCache");

                        if (indexCache == "-1")
                        {
                            indexCache = IndexOfInt(rootMsg.WRITE.Offset[i], "offsetSize");
                        }
                        else
                        {
                            cacheFound = true;
                        }
                        if (indexCache != "-1")
                        {
                            //string size = offsets.offsetsSize[0, index, 2];

                            //if (parser.readFsData(size, rootMsg.WRITE.Offset[i]) != null)
                            rootSend.WRITE.Value.Add(parser.writeFS(indexCache, rootMsg.WRITE.Offset[i], rootMsg.WRITE.Value[i]));
                            //else
                              //  rootSend.WRITE.Value.Add("NOK");

                            if (cacheFound == false)
                            {
                                offsets.offsetCacheWrite[offsets.cacheRunnerWrite, 0] = rootMsg.WRITE.Offset[i];
                                offsets.offsetCacheWrite[offsets.cacheRunnerWrite++, 1] = indexCache;

                                if (offsets.cacheRunnerWrite == offsets.offsetCacheWrite.Length / 2)
                                    offsets.cacheRunnerWrite = 0;
                            }
                        }
                        else
                        {
                            rootSend.WRITE.Value.Add("NOK");
                        }
                       
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

        public string IndexOfInt(string offset, string arrayName)
        {
            string size = "-1";
            switch (arrayName)
            {
                case "offsetSize":
                    {
                        for (int i = 0; i < (offsets.offsetsSize.Length / 3); i++)
                        {
                            if (offsets.offsetsSize[0, i, 0] == offset)
                            {
                                size = offsets.offsetsSize[0, i, 2];
                            }
                        }
                        break;
                    }

                case "offsetCacheWrite":
                    {
                        for (int i = 0; i < (offsets.offsetCacheWrite.Length / 2); i++)
                        {
                            if (offsets.offsetCacheWrite[i, 0] == offset)
                            {
                                size = offsets.offsetCacheWrite[i, 1];
                            }
                        }
                        break;
                    }

                case "offsetCacheRead":
                    {
                        for (int i = 0; i < (offsets.offsetCacheRead.Length / 2); i++)
                        {
                            if (offsets.offsetCacheRead[i, 0] == offset)
                            {
                                size = offsets.offsetCacheRead[i, 1];
                            }
                        }
                        break;
                    }
            }

            return size;
        }
    }
}
