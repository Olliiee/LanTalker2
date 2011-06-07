using Offsets;
using FSUIPC;

namespace LanTalker2
{
	public class Parser
	{
		
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

			if (clientData[0] == "READ")
			{
				result = offsets.processData(clientData[0], clientData[1]);
			}
			else if (clientData[0] == "WRITE")
			{
				result = offsets.processData(clientData[0], clientData[1], clientData[2]);
			}
			else if (clientData[0] == "TRAFFIC")
			{
				result = traffic(clientText);
			}
			
			return result;
		}

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
