/*
 * Using the JSON.NET framework of James Newton-King
 * http://james.newtonking.com/pages/json-net.aspx
 * 
 * Using FSUIPC client of Paul Henty
 * http://forum.simflight.com/topic/40989-fsuipc-client-dll-for-net-version-20/
 * 
 * 
 * FS LanTalker V2.1 BETA (C) Oliver Strauss 2013
 */

using System;
using System.Net.Sockets;
using System.Threading;
using FSUIPC;

namespace LanTalker2
{
	/// <summary>
	/// Server class
	/// </summary>
	public class Server
	{
		public TcpListener tcpListener;                                    //tcpListener - waiting for incoming tcp connections
		LanTalker2.Lib.stringLib logging = new Lib.stringLib();               //byter - class for coneverting strings and logging
		LanTalker2.Lib.fsuipcError uipcerror = new Lib.fsuipcError();       //uipcerror - handling uipc error msg
		LanTalker2.Lib.settings settings = new Lib.settings();              //debugger - if debug mode is active or not
		LanTalker2.Lib.network network = new Lib.network();

		const String lanTalker = "FS LanTalker V2.1 BETA (C) Oliver Strauss 2013";

		/// <summary>
		/// Starting the server
		/// </summary>
		/// <param name="debug">if debug mode is active (true) or not (false)</param>
		public void startServer(bool debug)
		{
			settings.debugger = debug;
			Console.Title = lanTalker;

			//Starting the tcpclient to listen for clients
			try
			{
				Thread listenToClients = new Thread(() => network.ListenForClients(settings.debugger));
				listenToClients.Start();
			}
			catch (Exception ex)
			{
				logging.screamer("Unable to listen for clients: " + ex, true, settings.debugger);
				logging.screamer("Closing", true, settings.debugger);
				Thread.Sleep(5000);

				//Can't work without a network, bye bye!
				Environment.Exit(0);
			}

			logging.screamer(lanTalker, true, settings.debugger);

			if (settings.debugger == true)
				logging.screamer("Running in debug-mode", false, settings.debugger);

			logging.screamer("Server is running ..", true, settings.debugger);
			
			//Looking for the local ip
			string HostName = System.Net.Dns.GetHostName();
			System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostEntry(HostName);

			logging.screamer("Server IP: ", true, settings.debugger);
			int h = 1;
			for (int i = 0; i < hostInfo.AddressList.Length; i++)
			{
				logging.screamer(h.ToString() + ") " + hostInfo.AddressList[i].ToString(), true, settings.debugger);
				h++;
			}
				
			

			//Try to connect to the FS via the FSUIPC Client for .NET
			try
			{
				FSUIPCConnection.Open();
				logging.screamer("Connected to Microsoft Flight Simulator " + FSUIPCConnection.FlightSimVersionConnected, true, settings.debugger);
				logging.screamer("Uses the FSUIPC Client DLL for .NET by Paul Henty V" + FSUIPCConnection.DLLVersion, true, settings.debugger);
			}
			catch (FSUIPCException ex)
			{
				logging.screamer(uipcerror.errorMsg(ex), true, settings.debugger);
				logging.screamer("Closing", true, settings.debugger);
				Thread.Sleep(5000);
				Environment.Exit(0);
			}
		}

		
		

  
	}
}

