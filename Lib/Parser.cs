using Offsets;
using FSUIPC;

namespace LanTalker2
{
	public class Parser
	{
		/// <summary>
		/// It's a little DLL to read an write the FS data.
		/// Check the offsets folder for the c# code
		/// </summary>
		Offsets.OffsetClass offsets = new OffsetClass();
		
		/// <summary>
		/// Parse the received message from client and load the fs data
		/// </summary>
		/// <param name="clientText">The message received from client</param>
		/// <returns>The result msg send to the client</returns>
		public string parseText(string clientText)
		{
			string[] clientData = clientText.Split(':');
			string result = "NOK";

			switch (clientData[0])
			{
				case "READ":
					{
						result = offsets.processData(clientData[0], clientData[1]);
						break;
					}
				case "WRITE":
					{
					   result = offsets.processData(clientData[0], clientData[1], clientData[2]);
					   break;
					}

				case "TRAFFIC":
					{
						result = traffic(clientText);
						break;
					}
			
			}
			
			return result;
		}

		/// <summary>
		/// Requests the AI traffic information
		/// </summary>
		/// <param name="clientText">In normale cases it should be 'POSITION'</param>
		/// <returns>Returns a resultset for the client</returns>
		private string traffic(string clientText)
		{
			string[] clientData = clientText.Split(':');
			string result = "NOK";

			AITrafficServices AI = FSUIPCConnection.AITrafficServices;
			AI.RefreshAITrafficInformation();

			switch (clientData[1])
			{
				case "POSITION":
					{
						try
						{

							result = "";
							foreach (AIPlaneInfo plane in FSUIPCConnection.AITrafficServices.AllTraffic)
							{
								//plane.GetExtendedPlaneIndentifiers(false, false, false, false);
								result = plane.ID.ToString();
								result = result + ":" + plane.ATCIdentifier;
								result = result + ":" + plane.Location.Latitude.DecimalDegrees.ToString();
								result = result + ":" + plane.Location.Longitude.DecimalDegrees.ToString();
								result = result + ":" + plane.HeadingDegrees.ToString();
								result = result + ":" + plane.AltitudeFeet.ToString();
								result = result + "|";
							}
						}
						catch
						{
							result = "NOK";
						}
						break;
					}
				
			}

			return result;
		}
	}
}
