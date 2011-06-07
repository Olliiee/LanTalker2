using System;
using FSUIPC;

namespace LanTalker2.Lib
{
	class Readfs
	{
		/*
		 * Size Comment                         .Net                            C#
		 * 1                                    System.Byte                     byte
		 * 2                                    System.Int16 / System.UInt16    short / ushort
		 * 4                                    System.Int32 / System.UInt32    int / uint
		 * 4    (Specified as 32-Bit Float)     System.Single                   float
		 * 8                                    System.Int64 / System.UInt64    long / ulong
		 */
		
		LanTalker2.Lib.fsuipcError uipcerror = new Lib.fsuipcError();
		
		public string readFsData(string size, string offset)
		{
			string result = "NOK";

			switch (size)
			{
				case "1":
				{
					try
					{
						Offset<Byte> shortVar = new Offset<Byte>(Convert.ToByte(offset));
						try
						{
							FSUIPCConnection.Process();
						}
						catch (FSUIPCException ex)
						{
							Console.WriteLine(uipcerror.errorMsg(ex));
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

				case "2":
				{
					try
					{ 
						Offset<short> shortVar = new Offset<short>(0x02B4);
						try
						{
							FSUIPCConnection.Process();
						}
						catch (FSUIPCException ex)
						{
							Console.WriteLine(uipcerror.errorMsg(ex));
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

				case "4":
				{
					try 
					{ 
						Offset<Int32> shortVar = new Offset<Int32>(0x02B4);
						try
						{
							FSUIPCConnection.Process();
						}
						catch (FSUIPCException ex)
						{
							Console.WriteLine(uipcerror.errorMsg(ex));
							break;
						}

						result = Convert.ToString((Int32)shortVar.Value);
					}
					catch (Exception ex)
					{
						Console.WriteLine("Error reading Int32 Var " + ex);
					}
					break;
				}

				case "8":
				{
					try
					{ 
						Offset<Int64> shortVar = new Offset<Int64>(int.Parse(offset));
						result = Convert.ToString((Int64)shortVar.Value);
					}
					catch
					{
						Console.WriteLine("Error reading Int64 Var");
					}
					break;
				}
			}

			return result;
		}

		public string writeFS(string size, string offset, string newValue)
		{
			string result = "NOK";

			switch (size)
			{
				case "1":
					{
						try
						{
							Offset<Byte> shortVar = new Offset<Byte>(Convert.ToByte(offset));
							shortVar.Value = Convert.ToByte(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch
						{
							Console.WriteLine("Error writing Byte Var");
							result = "NOK";
						}
						break;
					}

				case "2":
					{
						try
						{
							Offset<short> shortVar = new Offset<short>(Convert.ToInt16(offset));
							shortVar.Value = Convert.ToInt16(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch
						{
							Console.WriteLine("Error writing Short Var");
							result = "NOK";
						}
						break;
					}

				case "4":
					{
						try
						{
							Offset<Int32> shortVar = new Offset<Int32>(Convert.ToInt32(offset));
							shortVar.Value = Convert.ToInt32(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch
						{
							Console.WriteLine("Error writing Int32 Var");
							result = "NOK";
						}
						break;
					}

				case "8":
					{
						try
						{
							Offset<Int64> shortVar = new Offset<Int64>(int.Parse(offset));
							shortVar.Value = Convert.ToInt64(newValue);
							FSUIPCConnection.Process();
							result = "OK";
						}
						catch
						{
							Console.WriteLine("Error writing Int64 Var");							
							result = "NOK";
						}
						break;
					}
			}

			return result;
		}
	}
}
