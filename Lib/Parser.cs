using System;
using System.Globalization;
using FSUIPC;
using Offsets;

namespace LanTalker2.Lib
{
	public class Parser
	{
		/// <summary>
		/// It's a little DLL to read an write the FS data.
		/// Check the offsets folder for the c# code
		/// </summary>
		Offsets.OffsetClass offsets = new OffsetClass();
		

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

		/// <summary>
		/// Writing to the FS
		/// </summary>
		/// <param name="size">The offset size</param>
		/// <param name="offset"The offset itself</param>
		/// <param name="newValue">The new offset value</param>
		/// <returns>Returns OK or NOK</returns>
		public string writeFS(string size, string offset, string newValue)
		{
			string result = "NOK";

			int switchSize = Int32.Parse(size);

			if (switchSize > 8)
			{
				switchSize = 9;
			}

			switch (switchSize)
			{
				case 1:
					{
						try
						{
							Offset<Byte> shortVar = new Offset<Byte>(Byte.Parse(offset, NumberStyles.HexNumber));
							shortVar.Value = Convert.ToByte(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch (Exception ex)
						{
							result = "Error writing Byte Var " + ex;
						}
						break;
					}

				case 2:
					{
						try
						{
							Offset<short> shortVar = new Offset<short>(Int16.Parse(offset, NumberStyles.HexNumber));
							shortVar.Value = Convert.ToInt16(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch (Exception ex)
						{
							result = "Error writing Short Var " + ex;
						}
						break;
					}

				case 4:
					{
						try
						{
							Offset<Int32> shortVar = new Offset<Int32>(Int32.Parse(offset, NumberStyles.HexNumber));
							shortVar.Value = Convert.ToInt32(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch (Exception ex)
						{
							result = "Error writing Int32 Var " + ex;
						}
						break;
					}

				case 8:
					{
						try
						{
							Offset<Int64> shortVar = new Offset<Int64>(Int32.Parse(offset, NumberStyles.HexNumber));
							shortVar.Value = Convert.ToInt64(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch (Exception ex)
						{
							result = "Error writing Int64 Var " + ex;
						}
						break;
					}

				case 9:
					{
						try
						{
							Offset<string> shortVar = new Offset<string>(Int32.Parse(offset, NumberStyles.HexNumber), Int32.Parse(size), true);
							shortVar.Value = newValue;
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch (Exception ex)
						{
							result = "Error writing Int64 Var " + ex;
						}
						break;
					}
			}

			return result;
		}

		/// <summary>
		/// The function reads the data via the FSUIPC interface
		/// </summary>
		/// <param name="size">The offsets size: 1 = Byte; 2 = Int16; 4 = Int32; 8 = Int64</param>
		/// <param name="offset">The FS offset</param>
		/// <returns>The value of the requested offset</returns>
		public string readFsData(string size, string offset)
		{
			string result = "NOK";

			int switchSize = Int32.Parse(size);

			// If bigger then 8 it must be a string
			if (switchSize > 8)
			{
				switchSize = 9;
			}

			switch (switchSize)
			{
				case 1:
					{
						try
						{
							Offset<Byte> shortVar = new Offset<Byte>(Byte.Parse(offset, NumberStyles.HexNumber));
							try
							{
								FSUIPCConnection.Process();
							}
							catch (FSUIPCException ex)
							{
								break;
							}

							result = Convert.ToString((Byte)shortVar.Value);
						}
						catch
						{
							Console.WriteLine("Error reading Byte Var");
						}
						break;
					}

				case 2:
					{
						try
						{
							Offset<short> shortVar = new Offset<short>(Int16.Parse(offset, NumberStyles.HexNumber));
							try
							{
								FSUIPCConnection.Process();
							}
							catch (FSUIPCException ex)
							{
								break;
							}

							result = Convert.ToString((short)shortVar.Value);
						}
						catch
						{
							Console.WriteLine("Error reading Short Var");
						}
						break;
					}

				case 4:
					{
						try
						{
							Offset<Int32> shortVar = new Offset<Int32>(Int32.Parse(offset, NumberStyles.HexNumber));
							try
							{
								FSUIPCConnection.Process();
							}
							catch (FSUIPCException ex)
							{
								result = "Error writing Int32 Var " + ex;
								break;
							}

							result = Convert.ToString((Int32)shortVar.Value);
						}
						catch (Exception ex)
						{
							result = "Error writing Int32 Var " + ex;
						}
						break;
					}

				case 8:
					{
						try
						{
							Offset<long> shortVar = new Offset<long>(Int32.Parse(offset, NumberStyles.HexNumber));
							try
							{
								FSUIPCConnection.Process();
							}
							catch (FSUIPCException ex)
							{
								result = "Error writing Int64 Var " + ex;
								break;
							}

							result = Convert.ToString((Int32)shortVar.Value);
						}
						catch (Exception ex)
						{
							result = "Error writing Int64 Var " + ex;
						}
						break;
					}

				case 9:
					{
						try
						{
							try
							{
								Offset<string> shortVar = new Offset<string>(Int32.Parse(offset, NumberStyles.HexNumber), Int32.Parse(size));
								FSUIPCConnection.Process();
								result = Convert.ToString((string)shortVar.Value);
							}
							catch (FSUIPCException ex)
							{
								result = "Error writing String Var " + ex;
								break;
							}

						}
						catch
						{
							Console.WriteLine("Error reading String Var");
						}
						break;
					}
			}

			return result;
		}
	}
}
