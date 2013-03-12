using System;
using System.Collections.Generic;
using System.Text;
using FSUIPC;


 /*
 * This is an automated created offset file. Created by the Offsetparser at Dienstag, 12. März 2013 14:37:38
 */

namespace Offsets
{
	public class OffsetClass
	{
		private Offset<int> Offset0020 = new Offset<int>(0x0020);						// Size = 4 Ground elevation
		private Offset<string> Offset0024 = new Offset<string>(0x0024, 256, true);						// Size = 256 Startup situation/flight
		private Offset<string> Offset012C = new Offset<string>(0x012C, 256, true);						// Size = 256 Log Book name [FS2002+]
		private Offset<byte> Offset0238 = new Offset<byte>(0x0238);						// Size = 2 Clock Hour
		private Offset<byte> Offset0239 = new Offset<byte>(0x0239);						// Size = 2 Clock Min
		private Offset<byte> Offset023A = new Offset<byte>(0x023A);						// Size = 2 Clock Sec
		private Offset<byte> Offset023B = new Offset<byte>(0x023B);						// Size = 2 Zulu Hour
		private Offset<byte> Offset023C = new Offset<byte>(0x023C);						// Size = 2 Zulu Min
		private Offset<ushort> Offset023E = new Offset<ushort>(0x023E);						// Size = 2 Day of Year
		private Offset<ushort> Offset0240 = new Offset<ushort>(0x0240);						// Size = 2 Year
		private Offset<short> Offset0246 = new Offset<short>(0x0246);						// Size = 2 Time Zone offset to Zulu (minutes)
		private Offset<ushort> Offset0248 = new Offset<ushort>(0x0248);						// Size = 2 Season
		private Offset<ushort> Offset0262 = new Offset<ushort>(0x0262);						// Size = 2 Pause control
		private Offset<short> Offset0264 = new Offset<short>(0x0264);						// Size = 2 Pause flag
		private Offset<ushort> Offset0274 = new Offset<ushort>(0x0274);						// Size = 2 Frame Rate
		private Offset<short> Offset0278 = new Offset<short>(0x0278);						// Size = 2 Auto-rudder
		private Offset<byte> Offset0280 = new Offset<byte>(0x0280);						// Size = 2 Nav Lights
		private Offset<byte> Offset0281 = new Offset<byte>(0x0281);						// Size = 2 Strobe/Beacon Lights
		private Offset<ushort> Offset028C = new Offset<ushort>(0x028C);						// Size = 2 Landing Lights
		private Offset<short> Offset029C = new Offset<short>(0x029C);						// Size = 2 Pitot heat
		private Offset<short> Offset02A0 = new Offset<short>(0x02A0);						// Size = 2 MagVar
		private Offset<ushort> Offset02B2 = new Offset<ushort>(0x02B2);						// Size = 2 Zoom factor (FS2002+)
		private Offset<int> Offset02B4 = new Offset<int>(0x02B4);						// Size = 4 Ground Speed
		private Offset<int> Offset02B8 = new Offset<int>(0x02B8);						// Size = 4 True Air Speed
		private Offset<int> Offset02BC = new Offset<int>(0x02BC);						// Size = 4 Indicated Air Speed
		private Offset<uint> Offset02C4 = new Offset<uint>(0x02C4);						// Size = 4 Barber pole airspeed
		private Offset<int> Offset02C8 = new Offset<int>(0x02C8);						// Size = 4 Vertical speed
		private Offset<double> Offset02CC = new Offset<double>(0x02CC);						// Size = 8 Whiskey Compass
		private Offset<ushort> Offset02D4 = new Offset<ushort>(0x02D4);						// Size = 2 ADF2 freq (FS2004)
		private Offset<ushort> Offset02D6 = new Offset<ushort>(0x02D6);						// Size = 2 ADF2 Extended Freq (FS2004)
		private Offset<short> Offset02D8 = new Offset<short>(0x02D8);						// Size = 2 ADF2 Rel Bearing (FS2004)
		private Offset<uint> Offset02DC = new Offset<uint>(0x02DC);						// Size = 4 NDB2 identity (FS2004)
		private Offset<uint> Offset02E2 = new Offset<uint>(0x02E2);						// Size = 4 NDB2 name (FS2004)
		private Offset<byte> Offset02FB = new Offset<byte>(0x02FB);						// Size = 2 ADF2 ident sound switch (FS2004)
		private Offset<ushort> Offset0300 = new Offset<ushort>(0x0300);						// Size = 2 VOR1 DME distance (tenths nm)
		private Offset<ushort> Offset0302 = new Offset<ushort>(0x0302);						// Size = 2 VOR1 DME speed (tenths kts)
		private Offset<ushort> Offset0304 = new Offset<ushort>(0x0304);						// Size = 2 VOR1 DME time to stn (tenths secs)
		private Offset<ushort> Offset0306 = new Offset<ushort>(0x0306);						// Size = 2 VOR2 DME distance (tenths nm)
		private Offset<ushort> Offset0308 = new Offset<ushort>(0x0308);						// Size = 2 VOR2 DME speed (tenths kts)
		private Offset<ushort> Offset030A = new Offset<ushort>(0x030A);						// Size = 2 VOR2 DME time to stn (tenths secs)
		private Offset<int> Offset030C = new Offset<int>(0x030C);						// Size = 4 Vertical speed at touchdown
		private Offset<double> Offset0310 = new Offset<double>(0x0310);						// Size = 8 Control Timer 1 (FS2002+ see 0368)
		private Offset<ushort> Offset032C = new Offset<ushort>(0x032C);						// Size = 2 Plane in fuel box flag
		private Offset<ushort> Offset0330 = new Offset<ushort>(0x0330);						// Size = 2 Altimeter setting (mb)
		private Offset<ushort> Offset034C = new Offset<ushort>(0x034C);						// Size = 2 ADF Freq
		private Offset<ushort> Offset034E = new Offset<ushort>(0x034E);						// Size = 2 COM Freq
		private Offset<ushort> Offset0350 = new Offset<ushort>(0x0350);						// Size = 2 NAV1 Freq
		private Offset<ushort> Offset0352 = new Offset<ushort>(0x0352);						// Size = 2 NAV2 Freq
		private Offset<ushort> Offset0354 = new Offset<ushort>(0x0354);						// Size = 2 XPND - Transponser Freq.
		private Offset<ushort> Offset0356 = new Offset<ushort>(0x0356);						// Size = 2 ADF Extended Freq
		private Offset<ushort> Offset0366 = new Offset<ushort>(0x0366);						// Size = 2 Plane on ground
		private Offset<float> Offset0368 = new Offset<float>(0x0368);						// Size = 4 Control Timer 2 (FS2002 see 0310)
		private Offset<byte> Offset036C = new Offset<byte>(0x036C);						// Size = 2 Stall Warning
		private Offset<byte> Offset036D = new Offset<byte>(0x036D);						// Size = 2 Overspeed Warning
		private Offset<sbyte> Offset036E = new Offset<sbyte>(0x036E);						// Size = 2 Turn coordinator ball
		private Offset<ushort> Offset0378 = new Offset<ushort>(0x0378);						// Size = 2 DME1/2 Select
		private Offset<short> Offset037C = new Offset<short>(0x037C);						// Size = 2 Turn Rate
		private Offset<string> Offset0400 = new Offset<string>(0x0400, 128, true);						// Size = 128 Name of last saved flight
		private Offset<double> Offset0480 = new Offset<double>(0x0480);						// Size = 8 Aileron trim axis input from FSUIPC
		private Offset<double> Offset0488 = new Offset<double>(0x0488);						// Size = 8 Rudder trim axis input from FSUIPC
		private Offset<double> Offset0490 = new Offset<double>(0x0490);						// Size = 8 Aileron trim axis control to FSUIPC
		private Offset<double> Offset0498 = new Offset<double>(0x0498);						// Size = 8 Rudder trim axis control to FSUIPC
		private Offset<byte> Offset04A0 = new Offset<byte>(0x04A0);						// Size = 2 Disconnection of trim axes
		private Offset<double> Offset04A8 = new Offset<double>(0x04A8);						// Size = 8 Elapsed seconds 
		private Offset<ushort> Offset04B4 = new Offset<ushort>(0x04B4);						// Size = 2 METAR station altitude (FSMeteo)
		private Offset<ushort> Offset04BC = new Offset<ushort>(0x04BC);						// Size = 2 METAR barometric adder (FSMeteo)
		private Offset<short> Offset04C8 = new Offset<short>(0x04C8);						// Size = 2 Dew point (FS2000+)
		private Offset<byte> Offset04CB = new Offset<byte>(0x04CB);						// Size = 2 Precipitation rate [FS2000+]
		private Offset<byte> Offset04CC = new Offset<byte>(0x04CC);						// Size = 2 Precipitation type (FS2000+]
		private Offset<ushort> Offset04D2 = new Offset<ushort>(0x04D2);						// Size = 2 Rain/Snow control [FS2000+]
		private Offset<short> Offset04D4 = new Offset<short>(0x04D4);						// Size = 2 Dew point control [FS2000+]
		private Offset<ushort> Offset04D8 = new Offset<ushort>(0x04D8);						// Size = 2 Surface wind speed (FS2000+)
		private Offset<ushort> Offset04DA = new Offset<ushort>(0x04DA);						// Size = 2 Surface wind direction (FS2000+)
		private Offset<ushort> Offset04F0 = new Offset<ushort>(0x04F0);						// Size = 2 PM MCP lights
		private Offset<ushort> Offset04F4 = new Offset<ushort>(0x04F4);						// Size = 2 PM GC Controls parameter
		private Offset<double> Offset0538 = new Offset<double>(0x0538);						// Size = 8 Design speed VS0
		private Offset<double> Offset0540 = new Offset<double>(0x0540);						// Size = 8 Design speed VS1
		private Offset<double> Offset0548 = new Offset<double>(0x0548);						// Size = 8 Design speed VC
		private Offset<double> Offset0550 = new Offset<double>(0x0550);						// Size = 8 Minimum drag velocity
		private Offset<long> Offset0560 = new Offset<long>(0x0560);						// Size = 8 Latitude of aircraft
		private Offset<long> Offset0568 = new Offset<long>(0x0568);						// Size = 8 Longitude of aircraft
		private Offset<long> Offset0570 = new Offset<long>(0x0570);						// Size = 8 Altitude of aircraft
		private Offset<int> Offset0578 = new Offset<int>(0x0578);						// Size = 4 Pitch
		private Offset<int> Offset057C = new Offset<int>(0x057C);						// Size = 4 Bank
		private Offset<uint> Offset0580 = new Offset<uint>(0x0580);						// Size = 4 Heading
		private Offset<long> Offset05B0 = new Offset<long>(0x05B0);						// Size = 8 Viewpoint Latitude
		private Offset<long> Offset05B8 = new Offset<long>(0x05B8);						// Size = 8 Viewpoint Longitude
		private Offset<long> Offset05C0 = new Offset<long>(0x05C0);						// Size = 8 Viewpoint Altitude
		private Offset<uint> Offset05D0 = new Offset<uint>(0x05D0);						// Size = 4 View direction (TRUE)
		private Offset<ushort> Offset05D8 = new Offset<ushort>(0x05D8);						// Size = 2 Smoke System control
		private Offset<ushort> Offset05DC = new Offset<ushort>(0x05DC);						// Size = 2 Slew Mode
		private Offset<ushort> Offset05DE = new Offset<ushort>(0x05DE);						// Size = 2 Slew control
		private Offset<short> Offset05E4 = new Offset<short>(0x05E4);						// Size = 2 Slew roll rate
		private Offset<short> Offset05E6 = new Offset<short>(0x05E6);						// Size = 2 Slew yaw rate
		private Offset<short> Offset05E8 = new Offset<short>(0x05E8);						// Size = 2 Slew vertical rate
		private Offset<sbyte> Offset05EB = new Offset<sbyte>(0x05EB);						// Size = 2 Slew fwd/bwd rate
		private Offset<sbyte> Offset05ED = new Offset<sbyte>(0x05ED);						// Size = 2 Slew left/right rate
		private Offset<short> Offset05EE = new Offset<short>(0x05EE);						// Size = 2 Slew pitch rate
		private Offset<ushort> Offset05F4 = new Offset<ushort>(0x05F4);						// Size = 2 Slew mode display
		private Offset<ushort> Offset05FC = new Offset<ushort>(0x05FC);						// Size = 2 Flight mode display
		private Offset<byte> Offset0609 = new Offset<byte>(0x0609);						// Size = 2 Engine type
		private Offset<uint> Offset0628 = new Offset<uint>(0x0628);						// Size = 4 Replay in action flag & control
		private Offset<uint> Offset062C = new Offset<uint>(0x062C);						// Size = 4 Replay timer count-down
		private Offset<double> Offset0700 = new Offset<double>(0x0700);						// Size = 8 Target pitch for elevator feedback control
		private Offset<byte> Offset0708 = new Offset<byte>(0x0708);						// Size = 2 Switch to enable/disable elevator feedback control
		private Offset<double> Offset0718 = new Offset<double>(0x0718);						// Size = 8 Target bank for aileron feedback control
		private Offset<byte> Offset0720 = new Offset<byte>(0x0720);						// Size = 2 Switch to enable/disable aileron feedback control
		private Offset<double> Offset0730 = new Offset<double>(0x0730);						// Size = 8 Target speed for throttle feedback control
		private Offset<byte> Offset0738 = new Offset<byte>(0x0738);						// Size = 2 Switch to enable/disable speed feedback control
		private Offset<double> Offset0748 = new Offset<double>(0x0748);						// Size = 8 Target mach for throttle feedback control
		private Offset<byte> Offset0750 = new Offset<byte>(0x0750);						// Size = 2 Switch to enable/disable mach feedback control
		private Offset<byte> Offset0760 = new Offset<byte>(0x0760);						// Size = 2 Video recording flag (FS2002+)
		private Offset<uint> Offset0764 = new Offset<uint>(0x0764);						// Size = 4 Autopilot available
		private Offset<uint> Offset0778 = new Offset<uint>(0x0778);						// Size = 4 Flap Fitted
		private Offset<uint> Offset0780 = new Offset<uint>(0x0780);						// Size = 4 Has mixture control
		private Offset<uint> Offset0784 = new Offset<uint>(0x0784);						// Size = 4 Has carb heat control
		private Offset<uint> Offset078C = new Offset<uint>(0x078C);						// Size = 4 Has spoilers
		private Offset<uint> Offset0790 = new Offset<uint>(0x0790);						// Size = 4 Aircraft is tail dragger
		private Offset<uint> Offset0794 = new Offset<uint>(0x0794);						// Size = 4 Has strobes
		private Offset<uint> Offset079C = new Offset<uint>(0x079C);						// Size = 4 Has toe brakes
		private Offset<uint> Offset07A0 = new Offset<uint>(0x07A0);						// Size = 4 Has NAV1
		private Offset<uint> Offset07A4 = new Offset<uint>(0x07A4);						// Size = 4 Has NAV2
		private Offset<uint> Offset07BC = new Offset<uint>(0x07BC);						// Size = 4 AP Master Switch
		private Offset<uint> Offset07C0 = new Offset<uint>(0x07C0);						// Size = 4 AP Wing LVL
		private Offset<uint> Offset07C4 = new Offset<uint>(0x07C4);						// Size = 4 AP Nav1 Hold
		private Offset<uint> Offset07C8 = new Offset<uint>(0x07C8);						// Size = 4 AP Heading Hold
		private Offset<ushort> Offset07CC = new Offset<ushort>(0x07CC);						// Size = 2 AP Heading Value
		private Offset<uint> Offset07D0 = new Offset<uint>(0x07D0);						// Size = 4 AP Altitude Hold
		private Offset<int> Offset07D4 = new Offset<int>(0x07D4);						// Size = 4 AP Altitude Value
		private Offset<uint> Offset07D8 = new Offset<uint>(0x07D8);						// Size = 4 AP Attitude Hold
		private Offset<uint> Offset07DC = new Offset<uint>(0x07DC);						// Size = 4 AP Air Speed Hold
		private Offset<ushort> Offset07E2 = new Offset<ushort>(0x07E2);						// Size = 2 AP Air Speed Value
		private Offset<uint> Offset07E4 = new Offset<uint>(0x07E4);						// Size = 4 AP Mach Hold
		private Offset<uint> Offset07E8 = new Offset<uint>(0x07E8);						// Size = 4 AP Mach Value
		private Offset<short> Offset07F2 = new Offset<short>(0x07F2);						// Size = 2 AP V/S Value
		private Offset<uint> Offset07FC = new Offset<uint>(0x07FC);						// Size = 4 AP GS Hold
		private Offset<uint> Offset0800 = new Offset<uint>(0x0800);						// Size = 4 AP Approach Hold
		private Offset<uint> Offset0804 = new Offset<uint>(0x0804);						// Size = 4 AP BackCourse Hold
		private Offset<uint> Offset0808 = new Offset<uint>(0x0808);						// Size = 4 AP Yaw damper
		private Offset<uint> Offset080C = new Offset<uint>(0x080C);						// Size = 4 AP TO/GA
		private Offset<uint> Offset0830 = new Offset<uint>(0x0830);						// Size = 4 Crash detection
		private Offset<int> Offset0834 = new Offset<int>(0x0834);						// Size = 4 VOR2 DME Lat (FS2002+)
		private Offset<int> Offset0838 = new Offset<int>(0x0838);						// Size = 4 VOR2 DME Long (FS2002+)
		private Offset<int> Offset083C = new Offset<int>(0x083C);						// Size = 4 VOR2 DME Elevation (FS2002+]
		private Offset<short> Offset0840 = new Offset<short>(0x0840);						// Size = 2 Crashed
		private Offset<short> Offset0842 = new Offset<short>(0x0842);						// Size = 2 Vertical speed
		private Offset<ushort> Offset0844 = new Offset<ushort>(0x0844);						// Size = 2 VOR2 Loc Heading (True) (FS2002+)
		private Offset<short> Offset0846 = new Offset<short>(0x0846);						// Size = 2 VOR2 GS angle (FS2002+)
		private Offset<int> Offset084C = new Offset<int>(0x084C);						// Size = 4 VOR2 LOC Lat (FS2002+)
		private Offset<int> Offset0850 = new Offset<int>(0x0850);						// Size = 4 VOR2 LOC Long (FS2002+)
		private Offset<int> Offset0854 = new Offset<int>(0x0854);						// Size = 4 VOR2 LOC Elevation (FS2002+)
		private Offset<int> Offset0858 = new Offset<int>(0x0858);						// Size = 4 VOR2 or GS Lat (FS2002+)
		private Offset<int> Offset085C = new Offset<int>(0x085C);						// Size = 4 VOR1 or GS Lat
		private Offset<int> Offset0860 = new Offset<int>(0x0860);						// Size = 4 VOR2 or GS Long (FS2002+)
		private Offset<int> Offset0864 = new Offset<int>(0x0864);						// Size = 4 VOR1 or GS Long
		private Offset<int> Offset0868 = new Offset<int>(0x0868);						// Size = 4 VOR2 or GS Elevation (FS2002+)
		private Offset<int> Offset086C = new Offset<int>(0x086C);						// Size = 4 VOR1 or GS Elevation
		private Offset<ushort> Offset0870 = new Offset<ushort>(0x0870);						// Size = 2 VOR1 Loc Heading (True)
		private Offset<short> Offset0872 = new Offset<short>(0x0872);						// Size = 2 VOR1 GS angle
		private Offset<int> Offset0878 = new Offset<int>(0x0878);						// Size = 4 VOR1 LOC Long (FS2002+)
		private Offset<int> Offset087C = new Offset<int>(0x087C);						// Size = 4 VOR1 LOC Elevation (FS2002+)
		private Offset<int> Offset0880 = new Offset<int>(0x0880);						// Size = 4 VOR1 DME Lat (FS2002+)
		private Offset<int> Offset0884 = new Offset<int>(0x0884);						// Size = 4 VOR1 DME Long (FS2002+)
		private Offset<byte> Offset0888 = new Offset<byte>(0x0888);						// Size = 2 Active Engine bit-pattern
		private Offset<byte> Offset0889 = new Offset<byte>(0x0889);						// Size = 2 Rotor clutch switch [FS2004]
		private Offset<short> Offset088A = new Offset<short>(0x088A);						// Size = 2 VOR1 DME Elevation (FS2002+]
		private Offset<short> Offset088C = new Offset<short>(0x088C);						// Size = 2 ENG1 Throttle lever
		private Offset<short> Offset088E = new Offset<short>(0x088E);						// Size = 2 ENG1 Prop lever
		private Offset<short> Offset0890 = new Offset<short>(0x0890);						// Size = 2 ENG1 Mixture lever
		private Offset<ushort> Offset0892 = new Offset<ushort>(0x0892);						// Size = 2 ENG1 Starter switch pos
		private Offset<ushort> Offset0894 = new Offset<ushort>(0x0894);						// Size = 2 ENG1 Combustion flag
		private Offset<short> Offset0896 = new Offset<short>(0x0896);						// Size = 2 ENG1 N2
		private Offset<short> Offset0898 = new Offset<short>(0x0898);						// Size = 2 ENG1 N1
		private Offset<short> Offset089A = new Offset<short>(0x089A);						// Size = 2 Eng1 throttle
		private Offset<int> Offset08A0 = new Offset<int>(0x08A0);						// Size = 4 ENG1 Fuel Flow PPH SSL
		private Offset<short> Offset08B2 = new Offset<short>(0x08B2);						// Size = 2 ENG1 Ant-Ice / Carb heat
		private Offset<short> Offset08B8 = new Offset<short>(0x08B8);						// Size = 2 ENG1 Oil temp
		private Offset<ushort> Offset08BA = new Offset<ushort>(0x08BA);						// Size = 2 ENG1 Oil pressure
		private Offset<short> Offset08BC = new Offset<short>(0x08BC);						// Size = 2 ENG1 Pressure Ratio (EPR)
		private Offset<short> Offset08BE = new Offset<short>(0x08BE);						// Size = 2 ENG1 EGT
		private Offset<ushort> Offset08C0 = new Offset<ushort>(0x08C0);						// Size = 2 ENG1 Manifold Pressure
		private Offset<ushort> Offset08C8 = new Offset<ushort>(0x08C8);						// Size = 2 ENG1 RPM scaler
		private Offset<int> Offset08D0 = new Offset<int>(0x08D0);						// Size = 4 ENG1 Oil Quantity
		private Offset<int> Offset08D4 = new Offset<int>(0x08D4);						// Size = 4 ENG1 Vibration
		private Offset<int> Offset08D8 = new Offset<int>(0x08D8);						// Size = 4 ENG1 Hydraulic pressure
		private Offset<int> Offset08DC = new Offset<int>(0x08DC);						// Size = 4 ENG1 Hydraulic quantity
		private Offset<double> Offset08E8 = new Offset<double>(0x08E8);						// Size = 8 ENG1 CHT
		private Offset<int> Offset08F0 = new Offset<int>(0x08F0);						// Size = 4 ENG1 Turbine temp
		private Offset<int> Offset08F4 = new Offset<int>(0x08F4);						// Size = 4 ENG1 Torque %
		private Offset<int> Offset08F8 = new Offset<int>(0x08F8);						// Size = 4 ENG1 Fuel pressure
		private Offset<int> Offset08FC = new Offset<int>(0x08FC);						// Size = 4 ENG1 Electrical load (helo)
		private Offset<int> Offset0900 = new Offset<int>(0x0900);						// Size = 4 ENG1 Transmission pressure (helo)
		private Offset<int> Offset0904 = new Offset<int>(0x0904);						// Size = 4 ENG1 Transmission temp (helo)
		private Offset<int> Offset0908 = new Offset<int>(0x0908);						// Size = 4 ENG1 Rotor RPM % (helo)
		private Offset<double> Offset0918 = new Offset<double>(0x0918);						// Size = 8 ENG1 Fuel Flow PPH
		private Offset<float> Offset0920 = new Offset<float>(0x0920);						// Size = 4 ENG1 Torque (ft-lbs)
		private Offset<short> Offset0924 = new Offset<short>(0x0924);						// Size = 2 ENG2 Throttle lever
		private Offset<short> Offset0926 = new Offset<short>(0x0926);						// Size = 2 ENG2 Prop lever
		private Offset<short> Offset0928 = new Offset<short>(0x0928);						// Size = 2 ENG2 Mixture lever
		private Offset<ushort> Offset092A = new Offset<ushort>(0x092A);						// Size = 2 ENG2 Starter switch pos
		private Offset<ushort> Offset092C = new Offset<ushort>(0x092C);						// Size = 2 ENG2 Combustion flag
		private Offset<short> Offset092E = new Offset<short>(0x092E);						// Size = 2 ENG2 N2
		private Offset<short> Offset0930 = new Offset<short>(0x0930);						// Size = 2 ENG2 N1
		private Offset<short> Offset0932 = new Offset<short>(0x0932);						// Size = 2 Eng2 throttle
		private Offset<int> Offset0938 = new Offset<int>(0x0938);						// Size = 4 ENG2 Fuel Flow PPH SSL
		private Offset<short> Offset094A = new Offset<short>(0x094A);						// Size = 2 ENG2 Ant-Ice / Carb heat
		private Offset<short> Offset0950 = new Offset<short>(0x0950);						// Size = 2 ENG2 Oil temp
		private Offset<ushort> Offset0952 = new Offset<ushort>(0x0952);						// Size = 2 ENG2 Oil pressure
		private Offset<short> Offset0954 = new Offset<short>(0x0954);						// Size = 2 ENG2 Pressure Ratio (EPR)
		private Offset<short> Offset0956 = new Offset<short>(0x0956);						// Size = 2 ENG2 EGT
		private Offset<ushort> Offset0958 = new Offset<ushort>(0x0958);						// Size = 2 ENG2 Manifold Pressure
		private Offset<ushort> Offset0960 = new Offset<ushort>(0x0960);						// Size = 2 ENG2 RPM scaler
		private Offset<int> Offset0968 = new Offset<int>(0x0968);						// Size = 4 ENG2 Oil Quantity
		private Offset<int> Offset096C = new Offset<int>(0x096C);						// Size = 4 ENG2 Vibration
		private Offset<int> Offset0970 = new Offset<int>(0x0970);						// Size = 4 ENG2 Hydraulic pressure
		private Offset<int> Offset0974 = new Offset<int>(0x0974);						// Size = 4 ENG2 Hydraulic quantity
		private Offset<double> Offset0980 = new Offset<double>(0x0980);						// Size = 8 ENG2 CHT
		private Offset<int> Offset0988 = new Offset<int>(0x0988);						// Size = 4 ENG2 Turbine temp
		private Offset<int> Offset098C = new Offset<int>(0x098C);						// Size = 4 ENG2 Torque %
		private Offset<int> Offset0990 = new Offset<int>(0x0990);						// Size = 4 ENG2 Fuel pressure
		private Offset<double> Offset09B0 = new Offset<double>(0x09B0);						// Size = 8 ENG2 Fuel Flow PPH
		private Offset<float> Offset09B8 = new Offset<float>(0x09B8);						// Size = 4 ENG2 Torque (ft-lbs)
		private Offset<short> Offset09BC = new Offset<short>(0x09BC);						// Size = 2 ENG3 Throttle lever
		private Offset<short> Offset09BE = new Offset<short>(0x09BE);						// Size = 2 ENG3 Prop lever
		private Offset<short> Offset09C0 = new Offset<short>(0x09C0);						// Size = 2 ENG3 Mixture lever
		private Offset<ushort> Offset09C2 = new Offset<ushort>(0x09C2);						// Size = 2 ENG3 Starter switch pos
		private Offset<ushort> Offset09C4 = new Offset<ushort>(0x09C4);						// Size = 2 ENG3 Combustion flag
		private Offset<short> Offset09C6 = new Offset<short>(0x09C6);						// Size = 2 ENG3 N2
		private Offset<short> Offset09C8 = new Offset<short>(0x09C8);						// Size = 2 ENG3 N1
		private Offset<short> Offset09CA = new Offset<short>(0x09CA);						// Size = 2 Eng3 throttle
		private Offset<int> Offset09D0 = new Offset<int>(0x09D0);						// Size = 4 ENG3 Fuel Flow PPH SSL
		private Offset<short> Offset09E2 = new Offset<short>(0x09E2);						// Size = 2 ENG3 Ant-Ice / Carb heat
		private Offset<short> Offset09E8 = new Offset<short>(0x09E8);						// Size = 2 ENG3 Oil temp
		private Offset<ushort> Offset09EA = new Offset<ushort>(0x09EA);						// Size = 2 ENG3 Oil pressure
		private Offset<short> Offset09EC = new Offset<short>(0x09EC);						// Size = 2 ENG3 Pressure Ratio (EPR)
		private Offset<short> Offset09EE = new Offset<short>(0x09EE);						// Size = 2 ENG3 EGT
		private Offset<ushort> Offset09F0 = new Offset<ushort>(0x09F0);						// Size = 2 ENG3 Manifold Pressure
		private Offset<ushort> Offset09F8 = new Offset<ushort>(0x09F8);						// Size = 2 ENG3 RPM scaler
		private Offset<int> Offset0A00 = new Offset<int>(0x0A00);						// Size = 4 ENG3 Oil Quantity
		private Offset<int> Offset0A04 = new Offset<int>(0x0A04);						// Size = 4 ENG3 Vibration
		private Offset<int> Offset0A08 = new Offset<int>(0x0A08);						// Size = 4 ENG3 Hydraulic pressure
		private Offset<int> Offset0A0C = new Offset<int>(0x0A0C);						// Size = 4 ENG3 Hydraulic quantity
		private Offset<double> Offset0A18 = new Offset<double>(0x0A18);						// Size = 8 ENG3 CHT
		private Offset<int> Offset0A20 = new Offset<int>(0x0A20);						// Size = 4 ENG3 Turbine temp
		private Offset<int> Offset0A24 = new Offset<int>(0x0A24);						// Size = 4 ENG3 Torque %
		private Offset<int> Offset0A28 = new Offset<int>(0x0A28);						// Size = 4 ENG3 Fuel pressure
		private Offset<double> Offset0A48 = new Offset<double>(0x0A48);						// Size = 8 ENG3 Fuel Flow PPH
		private Offset<float> Offset0A50 = new Offset<float>(0x0A50);						// Size = 4 ENG3 Torque (ft-lbs)
		private Offset<short> Offset0A54 = new Offset<short>(0x0A54);						// Size = 2 ENG4 Throttle lever
		private Offset<short> Offset0A56 = new Offset<short>(0x0A56);						// Size = 2 ENG4 Prop lever
		private Offset<short> Offset0A58 = new Offset<short>(0x0A58);						// Size = 2 ENG4 Mixture lever
		private Offset<ushort> Offset0A5A = new Offset<ushort>(0x0A5A);						// Size = 2 ENG4 Starter switch pos
		private Offset<ushort> Offset0A5C = new Offset<ushort>(0x0A5C);						// Size = 2 ENG4 Combustion flag
		private Offset<short> Offset0A5E = new Offset<short>(0x0A5E);						// Size = 2 ENG4 N2
		private Offset<short> Offset0A60 = new Offset<short>(0x0A60);						// Size = 2 ENG4 N1
		private Offset<short> Offset0A62 = new Offset<short>(0x0A62);						// Size = 2 Eng4 throttle
		private Offset<int> Offset0A68 = new Offset<int>(0x0A68);						// Size = 4 ENG4 Fuel Flow PPH SSL
		private Offset<short> Offset0A7A = new Offset<short>(0x0A7A);						// Size = 2 ENG4 Ant-Ice / Carb heat
		private Offset<short> Offset0A80 = new Offset<short>(0x0A80);						// Size = 2 ENG4 Oil temp
		private Offset<ushort> Offset0A82 = new Offset<ushort>(0x0A82);						// Size = 2 ENG4 Oil pressure
		private Offset<short> Offset0A84 = new Offset<short>(0x0A84);						// Size = 2 ENG4 Pressure Ratio (EPR)
		private Offset<short> Offset0A86 = new Offset<short>(0x0A86);						// Size = 2 ENG4 EGT
		private Offset<ushort> Offset0A88 = new Offset<ushort>(0x0A88);						// Size = 2 ENG4 Manifold Pressure
		private Offset<ushort> Offset0A90 = new Offset<ushort>(0x0A90);						// Size = 2 ENG4 RPM scaler
		private Offset<int> Offset0A98 = new Offset<int>(0x0A98);						// Size = 4 ENG4 Oil Quantity
		private Offset<int> Offset0A9C = new Offset<int>(0x0A9C);						// Size = 4 ENG4 Vibration
		private Offset<int> Offset0AA0 = new Offset<int>(0x0AA0);						// Size = 4 ENG4 Hydraulic pressure
		private Offset<int> Offset0AA4 = new Offset<int>(0x0AA4);						// Size = 4 ENG4 Hydraulic quantity
		private Offset<double> Offset0AB0 = new Offset<double>(0x0AB0);						// Size = 8 ENG4 CHT
		private Offset<int> Offset0AB8 = new Offset<int>(0x0AB8);						// Size = 4 ENG4 Turbine temp
		private Offset<int> Offset0ABC = new Offset<int>(0x0ABC);						// Size = 4 ENG4 Torque %
		private Offset<int> Offset0AC0 = new Offset<int>(0x0AC0);						// Size = 4 ENG4 Fuel pressure
		private Offset<double> Offset0AE0 = new Offset<double>(0x0AE0);						// Size = 8 ENG4 Fuel Flow PPH
		private Offset<float> Offset0AE8 = new Offset<float>(0x0AE8);						// Size = 4 ENG4 Torque (ft-lbs)
		private Offset<short> Offset0AEC = new Offset<short>(0x0AEC);						// Size = 2 Number of engines
		private Offset<ushort> Offset0AF0 = new Offset<ushort>(0x0AF0);						// Size = 2 Prop pitch system
		private Offset<short> Offset0AF4 = new Offset<short>(0x0AF4);						// Size = 2 Fuel weight
		private Offset<short> Offset0AF8 = new Offset<short>(0x0AF8);						// Size = 2 Fuel tank select
		private Offset<short> Offset0B00 = new Offset<short>(0x0B00);						// Size = 2 Throttle low limit %
		private Offset<double> Offset0B18 = new Offset<double>(0x0B18);						// Size = 8 Suction pressure
		private Offset<short> Offset0B20 = new Offset<short>(0x0B20);						// Size = 2 Sound control
		private Offset<short> Offset0B24 = new Offset<short>(0x0B24);						// Size = 2 Sound flag
		private Offset<short> Offset0B4C = new Offset<short>(0x0B4C);						// Size = 2 Ground Altitude
		private Offset<ushort> Offset0B60 = new Offset<ushort>(0x0B60);						// Size = 2 Scenery Complexity
		private Offset<byte> Offset0B64 = new Offset<byte>(0x0B64);						// Size = 2 Fail ADF
		private Offset<byte> Offset0B65 = new Offset<byte>(0x0B65);						// Size = 2 Fail ASI
		private Offset<byte> Offset0B66 = new Offset<byte>(0x0B66);						// Size = 2 Fail Altimeter
		private Offset<byte> Offset0B67 = new Offset<byte>(0x0B67);						// Size = 2 Fail Attitude Indicator
		private Offset<byte> Offset0B68 = new Offset<byte>(0x0B68);						// Size = 2 Fail COM1 radio
		private Offset<byte> Offset0B69 = new Offset<byte>(0x0B69);						// Size = 2 Fail Compass
		private Offset<byte> Offset0B6A = new Offset<byte>(0x0B6A);						// Size = 2 Fail Electrics
		private Offset<byte> Offset0B6B = new Offset<byte>(0x0B6B);						// Size = 2 Fail Engine
		private Offset<byte> Offset0B6C = new Offset<byte>(0x0B6C);						// Size = 2 Fail Fuel indicators
		private Offset<byte> Offset0B6D = new Offset<byte>(0x0B6D);						// Size = 2 Fail Heading Indicator
		private Offset<byte> Offset0B6E = new Offset<byte>(0x0B6E);						// Size = 2 Fail VSI
		private Offset<byte> Offset0B6F = new Offset<byte>(0x0B6F);						// Size = 2 Fail Transponder
		private Offset<byte> Offset0B70 = new Offset<byte>(0x0B70);						// Size = 2 Fail NAV radios
		private Offset<byte> Offset0B71 = new Offset<byte>(0x0B71);						// Size = 2 Fail Pitot
		private Offset<byte> Offset0B72 = new Offset<byte>(0x0B72);						// Size = 2 Fail turn coordinator
		private Offset<byte> Offset0B73 = new Offset<byte>(0x0B73);						// Size = 2 Fail vacuum
		private Offset<int> Offset0B74 = new Offset<int>(0x0B74);						// Size = 4 Fuel Centre Level (%)
		private Offset<int> Offset0B78 = new Offset<int>(0x0B78);						// Size = 4 Fuel Centre Capacity
		private Offset<int> Offset0B7C = new Offset<int>(0x0B7C);						// Size = 4 Fuel Left Main Level (%)
		private Offset<int> Offset0B80 = new Offset<int>(0x0B80);						// Size = 4 Fuel Left Main Capacity
		private Offset<int> Offset0B84 = new Offset<int>(0x0B84);						// Size = 4 Fuel Left Aux Level (%)
		private Offset<int> Offset0B88 = new Offset<int>(0x0B88);						// Size = 4 Fuel Left Aux Capacity
		private Offset<int> Offset0B8C = new Offset<int>(0x0B8C);						// Size = 4 Fuel Left Tip Level (%)
		private Offset<int> Offset0B90 = new Offset<int>(0x0B90);						// Size = 4 Fuel Left Tip Capacity
		private Offset<int> Offset0B94 = new Offset<int>(0x0B94);						// Size = 4 Fuel Right Main Level (%)
		private Offset<int> Offset0B98 = new Offset<int>(0x0B98);						// Size = 4 Fuel Right Main Capacity
		private Offset<int> Offset0B9C = new Offset<int>(0x0B9C);						// Size = 4 Fuel Right Aux Level (%)
		private Offset<int> Offset0BA0 = new Offset<int>(0x0BA0);						// Size = 4 Fuel Right Aux Capacify
		private Offset<int> Offset0BA4 = new Offset<int>(0x0BA4);						// Size = 4 Fuel Right Tip Level (%)
		private Offset<int> Offset0BA8 = new Offset<int>(0x0BA8);						// Size = 4 Fuel Right Tip Capacity
		private Offset<short> Offset0BAC = new Offset<short>(0x0BAC);						// Size = 2 Inner Marker
		private Offset<short> Offset0BAE = new Offset<short>(0x0BAE);						// Size = 2 Middle Marker
		private Offset<short> Offset0BB0 = new Offset<short>(0x0BB0);						// Size = 2 Outer Marker
		private Offset<short> Offset0BB2 = new Offset<short>(0x0BB2);						// Size = 2 Elevator position control
		private Offset<short> Offset0BB4 = new Offset<short>(0x0BB4);						// Size = 2 Elevator indicator
		private Offset<short> Offset0BB6 = new Offset<short>(0x0BB6);						// Size = 2 Alieron position control
		private Offset<short> Offset0BB8 = new Offset<short>(0x0BB8);						// Size = 2 Alieron indicator
		private Offset<short> Offset0BBA = new Offset<short>(0x0BBA);						// Size = 2 Rudder position control
		private Offset<short> Offset0BBC = new Offset<short>(0x0BBC);						// Size = 2 Rudder indicator
		private Offset<short> Offset0BBE = new Offset<short>(0x0BBE);						// Size = 2 Helicopter pitch trim
		private Offset<short> Offset0BC0 = new Offset<short>(0x0BC0);						// Size = 2 Trim position control
		private Offset<short> Offset0BC2 = new Offset<short>(0x0BC2);						// Size = 2 Trim indicator
		private Offset<short> Offset0BC4 = new Offset<short>(0x0BC4);						// Size = 2 Brake actual (left)
		private Offset<short> Offset0BC6 = new Offset<short>(0x0BC6);						// Size = 2 Brake actual (right)
		private Offset<short> Offset0BC8 = new Offset<short>(0x0BC8);						// Size = 2 Brake parking
		private Offset<short> Offset0BCA = new Offset<short>(0x0BCA);						// Size = 2 Brake Commanded
		private Offset<int> Offset0BCC = new Offset<int>(0x0BCC);						// Size = 4 Spoiler arm
		private Offset<int> Offset0BD0 = new Offset<int>(0x0BD0);						// Size = 4 Spoiler control
		private Offset<int> Offset0BD4 = new Offset<int>(0x0BD4);						// Size = 4 Spolier actual (left)
		private Offset<int> Offset0BD8 = new Offset<int>(0x0BD8);						// Size = 4 Spoiler actual (right)
		private Offset<int> Offset0BDC = new Offset<int>(0x0BDC);						// Size = 4 Flaps control
		private Offset<int> Offset0BE0 = new Offset<int>(0x0BE0);						// Size = 4 Flaps indicator (Left)
		private Offset<int> Offset0BE4 = new Offset<int>(0x0BE4);						// Size = 4 Flaps indicator (right)
		private Offset<int> Offset0BE8 = new Offset<int>(0x0BE8);						// Size = 4 Gear Commanded
		private Offset<int> Offset0BEC = new Offset<int>(0x0BEC);						// Size = 4 Gear actual (nose)
		private Offset<int> Offset0BF0 = new Offset<int>(0x0BF0);						// Size = 4 Gear actual (right)
		private Offset<int> Offset0BF4 = new Offset<int>(0x0BF4);						// Size = 4 Gear actual (left)
		private Offset<int> Offset0BF8 = new Offset<int>(0x0BF8);						// Size = 4 Unlimited Visibility value
		private Offset<byte> Offset0C00 = new Offset<byte>(0x0C00);						// Size = 2 Right Brake Timer
		private Offset<byte> Offset0C01 = new Offset<byte>(0x0C01);						// Size = 2 Left Brake Timer
		private Offset<short> Offset0C06 = new Offset<short>(0x0C06);						// Size = 2 Helicopter bank trim
		private Offset<short> Offset0C18 = new Offset<short>(0x0C18);						// Size = 2 International: Units
		private Offset<short> Offset0C1A = new Offset<short>(0x0C1A);						// Size = 2 Simulation rate
		private Offset<string> Offset0C20 = new Offset<string>(0x0C20, 9, true);						// Size = 9 Time String
		private Offset<string> Offset0C29 = new Offset<string>(0x0C29, 5, true);						// Size = 5 VOR 1 DMEdistance string
		private Offset<string> Offset0C2E = new Offset<string>(0x0C2E, 5, true);						// Size = 5 VOR 1 DME Speed  string
		private Offset<string> Offset0C33 = new Offset<string>(0x0C33, 5, true);						// Size = 5 VOR 2 DMEdistance string
		private Offset<string> Offset0C38 = new Offset<string>(0x0C38, 5, true);						// Size = 5 VOR 2 DME Speed string
		private Offset<short> Offset0C3E = new Offset<short>(0x0C3E);						// Size = 2 Gyro Drift
		private Offset<sbyte> Offset0C48 = new Offset<sbyte>(0x0C48);						// Size = 2 NAV1 Loc Needle
		private Offset<sbyte> Offset0C49 = new Offset<sbyte>(0x0C49);						// Size = 2 NAV1 GS  Needle
		private Offset<byte> Offset0C4A = new Offset<byte>(0x0C4A);						// Size = 2 NAV1 BC flags
		private Offset<byte> Offset0C4B = new Offset<byte>(0x0C4B);						// Size = 2 NAV1 To/From Flag
		private Offset<byte> Offset0C4C = new Offset<byte>(0x0C4C);						// Size = 2 NAV1 GS Active
		private Offset<byte> Offset0C4D = new Offset<byte>(0x0C4D);						// Size = 2 NAV1 code
		private Offset<short> Offset0C4E = new Offset<short>(0x0C4E);						// Size = 2 NAV1 OBS (CRS)
		private Offset<uint> Offset0C52 = new Offset<uint>(0x0C52);						// Size = 4 NAV1 signal strength
		private Offset<ushort> Offset0C56 = new Offset<ushort>(0x0C56);						// Size = 2 NAV1 bearing to VOR
		private Offset<sbyte> Offset0C59 = new Offset<sbyte>(0x0C59);						// Size = 2 NAV2 Loc Needle
		private Offset<byte> Offset0C5A = new Offset<byte>(0x0C5A);						// Size = 2 NAV2 BC flags
		private Offset<byte> Offset0C5B = new Offset<byte>(0x0C5B);						// Size = 2 NAV2 To/From Flag
		private Offset<ushort> Offset0C5C = new Offset<ushort>(0x0C5C);						// Size = 2 NAV2 bearing to VOR
		private Offset<short> Offset0C5E = new Offset<short>(0x0C5E);						// Size = 2 NAV2 OBS (CRS)
		private Offset<ushort> Offset0C60 = new Offset<ushort>(0x0C60);						// Size = 2 NAV2 Radial
		private Offset<uint> Offset0C62 = new Offset<uint>(0x0C62);						// Size = 4 NAV2 signal strength
		private Offset<short> Offset0C6A = new Offset<short>(0x0C6A);						// Size = 2 ADF Relative Bearing
		private Offset<ushort> Offset0C6C = new Offset<ushort>(0x0C6C);						// Size = 2 ADF dial heading
		private Offset<sbyte> Offset0C6E = new Offset<sbyte>(0x0C6E);						// Size = 2 NAV2 GS Needle (FS2002+)
		private Offset<byte> Offset0C6F = new Offset<byte>(0x0C6F);						// Size = 2 NAV2 GS Active (FS2002+)
		private Offset<byte> Offset0C70 = new Offset<byte>(0x0C70);						// Size = 2 NAV2 code
		private Offset<short> Offset0D0C = new Offset<short>(0x0D0C);						// Size = 2 Lights [FS2000+)
		private Offset<long> Offset0D50 = new Offset<long>(0x0D50);						// Size = 8 Tower Latitude
		private Offset<long> Offset0D58 = new Offset<long>(0x0D58);						// Size = 8 Tower Longitude
		private Offset<long> Offset0D60 = new Offset<long>(0x0D60);						// Size = 8 Tower Elevation
		private Offset<uint> Offset0D6C = new Offset<uint>(0x0D6C);						// Size = 4 Parameter for Lua Script
		private Offset<string> Offset0D70 = new Offset<string>(0x0D70, 40, true);						// Size = 40 Lua Script to call
		private Offset<ushort> Offset0DD6 = new Offset<ushort>(0x0DD6);						// Size = 2 Scenery variable USRVAR (0312h)
		private Offset<ushort> Offset0DD8 = new Offset<ushort>(0x0DD8);						// Size = 2 Scenery variable USRVR2 (0314h)
		private Offset<ushort> Offset0DDA = new Offset<ushort>(0x0DDA);						// Size = 2 Scenery variable USRVR3 (0316h)
		private Offset<ushort> Offset0DDC = new Offset<ushort>(0x0DDC);						// Size = 2 Scenery variable USRVR4 (0318h)
		private Offset<ushort> Offset0DDE = new Offset<ushort>(0x0DDE);						// Size = 2 Scenery variable USRVR5 (031Ah)
		private Offset<short> Offset0E8A = new Offset<short>(0x0E8A);						// Size = 2 Current visibillity
		private Offset<short> Offset0E8C = new Offset<short>(0x0E8C);						// Size = 2 OAT
		private Offset<ushort> Offset0E90 = new Offset<ushort>(0x0E90);						// Size = 2 Ambient wind speed
		private Offset<ushort> Offset0E92 = new Offset<ushort>(0x0E92);						// Size = 2 Ambient wind direction
		private Offset<ushort> Offset0E9A = new Offset<ushort>(0x0E9A);						// Size = 2 Upper cloud ceiling
		private Offset<ushort> Offset0E9C = new Offset<ushort>(0x0E9C);						// Size = 2 Upper cloud base
		private Offset<ushort> Offset0E9E = new Offset<ushort>(0x0E9E);						// Size = 2 Upper cloud cover
		private Offset<ushort> Offset0EA0 = new Offset<ushort>(0x0EA0);						// Size = 2 Upper cloud variation
		private Offset<ushort> Offset0EA2 = new Offset<ushort>(0x0EA2);						// Size = 2 Lower cloud ceiling
		private Offset<ushort> Offset0EA4 = new Offset<ushort>(0x0EA4);						// Size = 2 Lower cloud base
		private Offset<ushort> Offset0EA6 = new Offset<ushort>(0x0EA6);						// Size = 2 Lower cloud cover
		private Offset<ushort> Offset0EA8 = new Offset<ushort>(0x0EA8);						// Size = 2 Lower cloud variation
		private Offset<ushort> Offset0EAA = new Offset<ushort>(0x0EAA);						// Size = 2 Storm cloud ceiling
		private Offset<ushort> Offset0EAC = new Offset<ushort>(0x0EAC);						// Size = 2 Storm cloud base
		private Offset<ushort> Offset0EAE = new Offset<ushort>(0x0EAE);						// Size = 2 Storm cloud cover
		private Offset<ushort> Offset0EB0 = new Offset<ushort>(0x0EB0);						// Size = 2 Storm cloud variation
		private Offset<ushort> Offset0EB2 = new Offset<ushort>(0x0EB2);						// Size = 2 Upper temp level
		private Offset<short> Offset0EB4 = new Offset<short>(0x0EB4);						// Size = 2 Upper temperature
		private Offset<ushort> Offset0EB6 = new Offset<ushort>(0x0EB6);						// Size = 2 Middle temp level
		private Offset<short> Offset0EB8 = new Offset<short>(0x0EB8);						// Size = 2 Middle temperature
		private Offset<ushort> Offset0EBA = new Offset<ushort>(0x0EBA);						// Size = 2 Lower temp level
		private Offset<short> Offset0EBC = new Offset<short>(0x0EBC);						// Size = 2 Lower temperature
		private Offset<short> Offset0EBE = new Offset<short>(0x0EBE);						// Size = 2 Surface temp level
		private Offset<short> Offset0EC0 = new Offset<short>(0x0EC0);						// Size = 2 Surface temperature
		private Offset<short> Offset0EC2 = new Offset<short>(0x0EC2);						// Size = 2 Temperature drift
		private Offset<short> Offset0EC4 = new Offset<short>(0x0EC4);						// Size = 2 Temperature day/night variation
		private Offset<ushort> Offset0EC6 = new Offset<ushort>(0x0EC6);						// Size = 2 Pressure (QNH)
		private Offset<short> Offset0EC8 = new Offset<short>(0x0EC8);						// Size = 2 Pressure Drift
		private Offset<ushort> Offset0ECA = new Offset<ushort>(0x0ECA);						// Size = 2 Upper wind ceiling
		private Offset<ushort> Offset0ECC = new Offset<ushort>(0x0ECC);						// Size = 2 Upper wind base
		private Offset<ushort> Offset0ECE = new Offset<ushort>(0x0ECE);						// Size = 2 Upper wind speed
		private Offset<ushort> Offset0ED0 = new Offset<ushort>(0x0ED0);						// Size = 2 Upper wind direction
		private Offset<ushort> Offset0ED2 = new Offset<ushort>(0x0ED2);						// Size = 2 Upper wind turbulence
		private Offset<ushort> Offset0ED4 = new Offset<ushort>(0x0ED4);						// Size = 2 Upper wind gusts
		private Offset<ushort> Offset0ED6 = new Offset<ushort>(0x0ED6);						// Size = 2 Middle wind ceiling
		private Offset<ushort> Offset0ED8 = new Offset<ushort>(0x0ED8);						// Size = 2 Middle wind base
		private Offset<ushort> Offset0EDA = new Offset<ushort>(0x0EDA);						// Size = 2 Middle wind speed
		private Offset<ushort> Offset0EDC = new Offset<ushort>(0x0EDC);						// Size = 2 Middle wind direction
		private Offset<ushort> Offset0EDE = new Offset<ushort>(0x0EDE);						// Size = 2 Middle wind turbulence
		private Offset<ushort> Offset0EE0 = new Offset<ushort>(0x0EE0);						// Size = 2 Middle wind gusts
		private Offset<ushort> Offset0EE2 = new Offset<ushort>(0x0EE2);						// Size = 2 Lower wind ceiling
		private Offset<short> Offset0EE4 = new Offset<short>(0x0EE4);						// Size = 2 Lower wind base
		private Offset<ushort> Offset0EE6 = new Offset<ushort>(0x0EE6);						// Size = 2 Lower wind speed
		private Offset<ushort> Offset0EE8 = new Offset<ushort>(0x0EE8);						// Size = 2 Lower wind direction
		private Offset<ushort> Offset0EEA = new Offset<ushort>(0x0EEA);						// Size = 2 Lower wind turbulence
		private Offset<ushort> Offset0EEC = new Offset<ushort>(0x0EEC);						// Size = 2 Lower wind gusts
		private Offset<short> Offset0EEE = new Offset<short>(0x0EEE);						// Size = 2 Surface wind ceiling
		private Offset<ushort> Offset0EF0 = new Offset<ushort>(0x0EF0);						// Size = 2 Surface wind speed
		private Offset<ushort> Offset0EF2 = new Offset<ushort>(0x0EF2);						// Size = 2 Surface wind direction
		private Offset<ushort> Offset0EF4 = new Offset<ushort>(0x0EF4);						// Size = 2 Surface wind turbulence
		private Offset<ushort> Offset0EF6 = new Offset<ushort>(0x0EF6);						// Size = 2 Surface wind gusts
		private Offset<ushort> Offset0EF8 = new Offset<ushort>(0x0EF8);						// Size = 2 Upper cloud type
		private Offset<ushort> Offset0EFA = new Offset<ushort>(0x0EFA);						// Size = 2 Upper cloud icing
		private Offset<ushort> Offset0EFC = new Offset<ushort>(0x0EFC);						// Size = 2 Upper cloud turbulence
		private Offset<ushort> Offset0EFE = new Offset<ushort>(0x0EFE);						// Size = 2 Lower cloud type
		private Offset<ushort> Offset0F00 = new Offset<ushort>(0x0F00);						// Size = 2 Lower cloud icing
		private Offset<ushort> Offset0F02 = new Offset<ushort>(0x0F02);						// Size = 2 Lower cloud turbulence
		private Offset<ushort> Offset0F04 = new Offset<ushort>(0x0F04);						// Size = 2 Storm cloud type
		private Offset<ushort> Offset0F06 = new Offset<ushort>(0x0F06);						// Size = 2 Storm cloud icing
		private Offset<ushort> Offset0F08 = new Offset<ushort>(0x0F08);						// Size = 2 Storm cloud turbulence
		private Offset<ushort> Offset0F1C = new Offset<ushort>(0x0F1C);						// Size = 2 Upper cloud ceiling
		private Offset<ushort> Offset0F1E = new Offset<ushort>(0x0F1E);						// Size = 2 Upper cloud base
		private Offset<ushort> Offset0F20 = new Offset<ushort>(0x0F20);						// Size = 2 Upper cloud cover
		private Offset<ushort> Offset0F22 = new Offset<ushort>(0x0F22);						// Size = 2 Upper cloud variation
		private Offset<ushort> Offset0F24 = new Offset<ushort>(0x0F24);						// Size = 2 Lower cloud ceiling
		private Offset<ushort> Offset0F26 = new Offset<ushort>(0x0F26);						// Size = 2 Lower cloud base
		private Offset<ushort> Offset0F28 = new Offset<ushort>(0x0F28);						// Size = 2 Lower cloud cover
		private Offset<ushort> Offset0F2A = new Offset<ushort>(0x0F2A);						// Size = 2 Lower cloud variation
		private Offset<ushort> Offset0F2C = new Offset<ushort>(0x0F2C);						// Size = 2 Storm cloud ceiling
		private Offset<ushort> Offset0F2E = new Offset<ushort>(0x0F2E);						// Size = 2 Storm cloud base
		private Offset<ushort> Offset0F30 = new Offset<ushort>(0x0F30);						// Size = 2 Storm cloud cover
		private Offset<ushort> Offset0F32 = new Offset<ushort>(0x0F32);						// Size = 2 Storm cloud variation
		private Offset<ushort> Offset0F34 = new Offset<ushort>(0x0F34);						// Size = 2 Upper temp level
		private Offset<short> Offset0F36 = new Offset<short>(0x0F36);						// Size = 2 Upper temperature
		private Offset<ushort> Offset0F38 = new Offset<ushort>(0x0F38);						// Size = 2 Middle temp level
		private Offset<short> Offset0F3A = new Offset<short>(0x0F3A);						// Size = 2 Middle temperature
		private Offset<ushort> Offset0F3C = new Offset<ushort>(0x0F3C);						// Size = 2 Lower temp level
		private Offset<short> Offset0F3E = new Offset<short>(0x0F3E);						// Size = 2 Lower temperature
		private Offset<short> Offset0F40 = new Offset<short>(0x0F40);						// Size = 2 Surface temp level
		private Offset<short> Offset0F42 = new Offset<short>(0x0F42);						// Size = 2 Surface temperature
		private Offset<short> Offset0F44 = new Offset<short>(0x0F44);						// Size = 2 Temperature drift
		private Offset<short> Offset0F46 = new Offset<short>(0x0F46);						// Size = 2 Temperature day/night variation
		private Offset<ushort> Offset0F48 = new Offset<ushort>(0x0F48);						// Size = 2 Pressure (QNH)
		private Offset<short> Offset0F4A = new Offset<short>(0x0F4A);						// Size = 2 Pressure Drift
		private Offset<ushort> Offset0F4C = new Offset<ushort>(0x0F4C);						// Size = 2 Upper wind ceiling
		private Offset<ushort> Offset0F4E = new Offset<ushort>(0x0F4E);						// Size = 2 Upper wind base
		private Offset<ushort> Offset0F50 = new Offset<ushort>(0x0F50);						// Size = 2 Upper wind speed
		private Offset<ushort> Offset0F52 = new Offset<ushort>(0x0F52);						// Size = 2 Upper wind direction
		private Offset<ushort> Offset0F54 = new Offset<ushort>(0x0F54);						// Size = 2 Upper wind turbulence
		private Offset<ushort> Offset0F56 = new Offset<ushort>(0x0F56);						// Size = 2 Upper wind gusts
		private Offset<ushort> Offset0F58 = new Offset<ushort>(0x0F58);						// Size = 2 Middle wind ceiling
		private Offset<ushort> Offset0F5A = new Offset<ushort>(0x0F5A);						// Size = 2 Middle wind base
		private Offset<ushort> Offset0F5C = new Offset<ushort>(0x0F5C);						// Size = 2 Middle wind speed
		private Offset<ushort> Offset0F5E = new Offset<ushort>(0x0F5E);						// Size = 2 Middle wind direction
		private Offset<ushort> Offset0F60 = new Offset<ushort>(0x0F60);						// Size = 2 Middle wind turbulence
		private Offset<ushort> Offset0F62 = new Offset<ushort>(0x0F62);						// Size = 2 Middle wind gusts
		private Offset<ushort> Offset0F64 = new Offset<ushort>(0x0F64);						// Size = 2 Lower wind ceiling
		private Offset<short> Offset0F66 = new Offset<short>(0x0F66);						// Size = 2 Lower wind base
		private Offset<ushort> Offset0F68 = new Offset<ushort>(0x0F68);						// Size = 2 Lower wind speed
		private Offset<ushort> Offset0F6A = new Offset<ushort>(0x0F6A);						// Size = 2 Lower wind direction
		private Offset<ushort> Offset0F6C = new Offset<ushort>(0x0F6C);						// Size = 2 Lower wind turbulence
		private Offset<ushort> Offset0F6E = new Offset<ushort>(0x0F6E);						// Size = 2 Lower wind gusts
		private Offset<short> Offset0F70 = new Offset<short>(0x0F70);						// Size = 2 Surface wind ceiling
		private Offset<ushort> Offset0F72 = new Offset<ushort>(0x0F72);						// Size = 2 Surface wind speed
		private Offset<ushort> Offset0F74 = new Offset<ushort>(0x0F74);						// Size = 2 Surface wind direction
		private Offset<ushort> Offset0F76 = new Offset<ushort>(0x0F76);						// Size = 2 Surface wind turbulence
		private Offset<ushort> Offset0F78 = new Offset<ushort>(0x0F78);						// Size = 2 Surface wind gusts
		private Offset<ushort> Offset0F7A = new Offset<ushort>(0x0F7A);						// Size = 2 Upper cloud type
		private Offset<ushort> Offset0F7C = new Offset<ushort>(0x0F7C);						// Size = 2 Upper cloud icing
		private Offset<ushort> Offset0F7E = new Offset<ushort>(0x0F7E);						// Size = 2 Upper cloud turbulence
		private Offset<ushort> Offset0F80 = new Offset<ushort>(0x0F80);						// Size = 2 Lower cloud type
		private Offset<ushort> Offset0F82 = new Offset<ushort>(0x0F82);						// Size = 2 Lower cloud icing
		private Offset<ushort> Offset0F84 = new Offset<ushort>(0x0F84);						// Size = 2 Lower cloud turbulence
		private Offset<ushort> Offset0F86 = new Offset<ushort>(0x0F86);						// Size = 2 Storm cloud type
		private Offset<ushort> Offset0F88 = new Offset<ushort>(0x0F88);						// Size = 2 Storm cloud icing
		private Offset<ushort> Offset0F8A = new Offset<ushort>(0x0F8A);						// Size = 2 Storm cloud turbulence
		private Offset<ushort> Offset0F8C = new Offset<ushort>(0x0F8C);						// Size = 2 Visibility
		private Offset<uint> Offset0FF0 = new Offset<uint>(0x0FF0);						// Size = 4 Path read signature / flag
		private Offset<ushort> Offset0FF4 = new Offset<ushort>(0x0FF4);						// Size = 2 Path read command
		private Offset<ushort> Offset0FF6 = new Offset<ushort>(0x0FF6);						// Size = 2 Path read options
		private Offset<int> Offset0FF8 = new Offset<int>(0x0FF8);						// Size = 4 Path read parameter
		private Offset<uint> Offset0FFC = new Offset<uint>(0x0FFC);						// Size = 4 Path read timestamp
		private Offset<string> Offset1000 = new Offset<string>(0x1000, 256, true);						// Size = 256 Path area (256) -- FLT path on FSX
		private Offset<byte> Offset115E = new Offset<byte>(0x115E);						// Size = 2 Time of Day Indicator
		private Offset<byte> Offset11A2 = new Offset<byte>(0x11A2);						// Size = 2 Ground scenery shadows
		private Offset<ushort> Offset11A4 = new Offset<ushort>(0x11A4);						// Size = 2 Aircraft shadows
		private Offset<byte> Offset11B6 = new Offset<byte>(0x11B6);						// Size = 2 Aircraft reflections
		private Offset<short> Offset11BA = new Offset<short>(0x11BA);						// Size = 2 G-Force
		private Offset<short> Offset11BE = new Offset<short>(0x11BE);						// Size = 2 AOA (Angle Of Attack)
		private Offset<ushort> Offset11C6 = new Offset<ushort>(0x11C6);						// Size = 2 Mach speed
		private Offset<short> Offset11D0 = new Offset<short>(0x11D0);						// Size = 2 TAT (Total Air Temperature)
		private Offset<int> Offset1244 = new Offset<int>(0x1244);						// Size = 4 Fuel centre2 level (%) (FS2000+)
		private Offset<int> Offset1248 = new Offset<int>(0x1248);						// Size = 4 Fuel centre2 capacity (FS2000+)
		private Offset<int> Offset124C = new Offset<int>(0x124C);						// Size = 4 Fuel centre3 level (%) (FS2000+)
		private Offset<int> Offset1250 = new Offset<int>(0x1250);						// Size = 4 Fuel centre3 capacity (FS2000+)
		private Offset<int> Offset1254 = new Offset<int>(0x1254);						// Size = 4 Fuel external1 level (%) (FS2000+)
		private Offset<int> Offset1258 = new Offset<int>(0x1258);						// Size = 4 Fuel external1 capacity (FS2000+)
		private Offset<int> Offset125C = new Offset<int>(0x125C);						// Size = 4 Fuel external2 level (%) (FS2000+)
		private Offset<int> Offset1260 = new Offset<int>(0x1260);						// Size = 4 Fuel external2 capacity (FS2000+)
		private Offset<ushort> Offset1274 = new Offset<ushort>(0x1274);						// Size = 2 Text display mode [FS2000+]
		private Offset<uint> Offset132C = new Offset<uint>(0x132C);						// Size = 4 GPS/NAV switch [FS2000+]
		private Offset<uint> Offset1334 = new Offset<uint>(0x1334);						// Size = 4 Max Gross Weight [FSX]
		private Offset<uint> Offset13FC = new Offset<uint>(0x13FC);						// Size = 4 Payload station count (FS2004)
		private Offset<double> Offset1400 = new Offset<double>(0x1400);						// Size = 8 Payload weight lbs (FS2004)
		private Offset<double> Offset1408 = new Offset<double>(0x1408);						// Size = 8 Payload lateral feet (FS2004)
		private Offset<double> Offset1410 = new Offset<double>(0x1410);						// Size = 8 Payload vertical feet (FS2004)
		private Offset<double> Offset1418 = new Offset<double>(0x1418);						// Size = 8 Payload longitudinal feet (FS2004)
		private Offset<string> Offset1420 = new Offset<string>(0x1420, 16, true);						// Size = 16 Payload name (16 ch ASCIIZ) (FS2004)
		private Offset<int> Offset1F80 = new Offset<int>(0x1F80);						// Size = 4 TCAS injection Id
		private Offset<float> Offset1F84 = new Offset<float>(0x1F84);						// Size = 4 TCAS injection Latitude
		private Offset<float> Offset1F88 = new Offset<float>(0x1F88);						// Size = 4 TCAS injection Longitude
		private Offset<float> Offset1F8C = new Offset<float>(0x1F8C);						// Size = 4 TCAS injection Alt
		private Offset<ushort> Offset1F90 = new Offset<ushort>(0x1F90);						// Size = 2 TCAS injection Hdg True
		private Offset<ushort> Offset1F92 = new Offset<ushort>(0x1F92);						// Size = 2 TCAS injection GS
		private Offset<short> Offset1F94 = new Offset<short>(0x1F94);						// Size = 2 TCAS injection VS
		private Offset<string> Offset1F96 = new Offset<string>(0x1F96, 15, true);						// Size = 15 TCAS injection ATC ident string
		private Offset<byte> Offset1FA5 = new Offset<byte>(0x1FA5);						// Size = 2 TCAS injection state flag
		private Offset<ushort> Offset1FA6 = new Offset<ushort>(0x1FA6);						// Size = 2 TCAS injection COM1 freq
		private Offset<double> Offset2000 = new Offset<double>(0x2000);						// Size = 8 Turb. ENG1 N1 %
		private Offset<double> Offset2008 = new Offset<double>(0x2008);						// Size = 8 Turb. ENG1 N2 %
		private Offset<double> Offset2010 = new Offset<double>(0x2010);						// Size = 8 Turb. ENG1 Corrected N1 %
		private Offset<double> Offset2018 = new Offset<double>(0x2018);						// Size = 8 Turb. ENG1 Corrected N2 %
		private Offset<double> Offset2020 = new Offset<double>(0x2020);						// Size = 8 Turb. ENG1 Corrected Fuel Flow
		private Offset<double> Offset2028 = new Offset<double>(0x2028);						// Size = 8 Turb. ENG1 Max Torque fraction
		private Offset<double> Offset2030 = new Offset<double>(0x2030);						// Size = 8 Turb. ENG1 EPR
		private Offset<double> Offset2038 = new Offset<double>(0x2038);						// Size = 8 Turb. ENG1 ITT
		private Offset<uint> Offset2048 = new Offset<uint>(0x2048);						// Size = 4 Turb. ENG1 Afterburner
		private Offset<double> Offset204C = new Offset<double>(0x204C);						// Size = 8 Turb. ENG1 JET Thrust
		private Offset<uint> Offset205C = new Offset<uint>(0x205C);						// Size = 4 Turb. ENG1 number Tanks
		private Offset<double> Offset2060 = new Offset<double>(0x2060);						// Size = 8 Turb. ENG1 FuelFlow PPH
		private Offset<double> Offset206C = new Offset<double>(0x206C);						// Size = 8 Turb. ENG1 Bleed air PSI
		private Offset<double> Offset207C = new Offset<double>(0x207C);						// Size = 8 Turb. ENG1 Reverser fraction
		private Offset<double> Offset2100 = new Offset<double>(0x2100);						// Size = 8 Turb. ENG2 N1 %
		private Offset<double> Offset2108 = new Offset<double>(0x2108);						// Size = 8 Turb. ENG2 N2 %
		private Offset<double> Offset2110 = new Offset<double>(0x2110);						// Size = 8 Turb. ENG2 Corrected N1 %
		private Offset<double> Offset2118 = new Offset<double>(0x2118);						// Size = 8 Turb. ENG2 Corrected N2 %
		private Offset<double> Offset2120 = new Offset<double>(0x2120);						// Size = 8 Turb. ENG2 Corrected FF
		private Offset<double> Offset2128 = new Offset<double>(0x2128);						// Size = 8 Turb. ENG2 Max Torque fraction
		private Offset<double> Offset2130 = new Offset<double>(0x2130);						// Size = 8 Turb. ENG2  EPR
		private Offset<double> Offset2138 = new Offset<double>(0x2138);						// Size = 8 Turb. ENG2  ITT
		private Offset<double> Offset2148 = new Offset<double>(0x2148);						// Size = 8 Turb. ENG2 Afterburner
		private Offset<double> Offset214C = new Offset<double>(0x214C);						// Size = 8 Turb. ENG2 Jet Thrust
		private Offset<uint> Offset215C = new Offset<uint>(0x215C);						// Size = 4 Turb. ENG2 number Tanks
		private Offset<double> Offset2160 = new Offset<double>(0x2160);						// Size = 8 Turb. ENG2 FuelFlow PPH
		private Offset<double> Offset216C = new Offset<double>(0x216C);						// Size = 8 Turb. ENG2 Bleed air PSI
		private Offset<double> Offset217C = new Offset<double>(0x217C);						// Size = 8 Turb. ENG2 Reverser fraction
		private Offset<double> Offset2184 = new Offset<double>(0x2184);						// Size = 8 Turb. ENG2 Vibration
		private Offset<double> Offset2200 = new Offset<double>(0x2200);						// Size = 8 Turb. ENG3 N1 %
		private Offset<double> Offset2208 = new Offset<double>(0x2208);						// Size = 8 Turb. ENG3 N2 %
		private Offset<double> Offset2210 = new Offset<double>(0x2210);						// Size = 8 Turb. ENG3 Corrected N1 %
		private Offset<double> Offset2218 = new Offset<double>(0x2218);						// Size = 8 Turb. ENG3 Corrected N2 %
		private Offset<double> Offset2220 = new Offset<double>(0x2220);						// Size = 8 Turb. ENG3 Corrected FF
		private Offset<double> Offset2228 = new Offset<double>(0x2228);						// Size = 8 Turb. ENG3 Max Torque fraction
		private Offset<double> Offset2230 = new Offset<double>(0x2230);						// Size = 8 Turb. ENG3  EPR
		private Offset<double> Offset2238 = new Offset<double>(0x2238);						// Size = 8 Turb. ENG3  ITT
		private Offset<uint> Offset2248 = new Offset<uint>(0x2248);						// Size = 4 Turb. ENG3 Afterburner
		private Offset<double> Offset224C = new Offset<double>(0x224C);						// Size = 8 Turb. ENG3 Jet Thrust
		private Offset<uint> Offset225C = new Offset<uint>(0x225C);						// Size = 4 Turb. ENG3 number Tanks
		private Offset<double> Offset2260 = new Offset<double>(0x2260);						// Size = 8 Turb. ENG3 FuelFlow PPH
		private Offset<double> Offset226C = new Offset<double>(0x226C);						// Size = 8 Turb. ENG3 Bleed air PSI
		private Offset<double> Offset227C = new Offset<double>(0x227C);						// Size = 8 Turb. ENG3 Reverser fraction
		private Offset<double> Offset2300 = new Offset<double>(0x2300);						// Size = 8 Turb. ENG4 N1 %
		private Offset<double> Offset2308 = new Offset<double>(0x2308);						// Size = 8 Turb. ENG4 N2 %
		private Offset<double> Offset2310 = new Offset<double>(0x2310);						// Size = 8 Turb. ENG4 Corrected N1 %
		private Offset<double> Offset2318 = new Offset<double>(0x2318);						// Size = 8 Turb. ENG4 Corrected N2 %
		private Offset<double> Offset2320 = new Offset<double>(0x2320);						// Size = 8 Turb. ENG4 Corrected FF
		private Offset<double> Offset2328 = new Offset<double>(0x2328);						// Size = 8 Turb. ENG4 Max Torque fraction
		private Offset<double> Offset2330 = new Offset<double>(0x2330);						// Size = 8 Turb. ENG4  EPR
		private Offset<double> Offset2338 = new Offset<double>(0x2338);						// Size = 8 Turb. ENG4  ITT
		private Offset<uint> Offset2348 = new Offset<uint>(0x2348);						// Size = 4 Turb. ENG4 Afterburner
		private Offset<double> Offset234C = new Offset<double>(0x234C);						// Size = 8 Turb. ENG4 Jet Thrust
		private Offset<uint> Offset235C = new Offset<uint>(0x235C);						// Size = 4 Turb. ENG4 number Tanks
		private Offset<double> Offset2360 = new Offset<double>(0x2360);						// Size = 8 Turb. ENG4 FuelFlow PPH
		private Offset<double> Offset236C = new Offset<double>(0x236C);						// Size = 8 Turb. ENG4 Bleed air PSI
		private Offset<double> Offset237C = new Offset<double>(0x237C);						// Size = 8 Turb. ENG4 Reverser fraction
		private Offset<double> Offset2400 = new Offset<double>(0x2400);						// Size = 8 Prop1 RPM
		private Offset<double> Offset2408 = new Offset<double>(0x2408);						// Size = 8 Prop1 RPM fraction
		private Offset<double> Offset2410 = new Offset<double>(0x2410);						// Size = 8 Prop1 Thrust
		private Offset<double> Offset2418 = new Offset<double>(0x2418);						// Size = 8 Prop1 Beta
		private Offset<double> Offset2500 = new Offset<double>(0x2500);						// Size = 8 Prop2 RPM
		private Offset<double> Offset2508 = new Offset<double>(0x2508);						// Size = 8 Prop2 RPM fraction
		private Offset<double> Offset2510 = new Offset<double>(0x2510);						// Size = 8 Prop2 Thrust
		private Offset<double> Offset2518 = new Offset<double>(0x2518);						// Size = 8 Prop2 Beta
		private Offset<double> Offset2600 = new Offset<double>(0x2600);						// Size = 8 Prop3 RPM
		private Offset<double> Offset2608 = new Offset<double>(0x2608);						// Size = 8 Prop3 RPM fraction
		private Offset<double> Offset2610 = new Offset<double>(0x2610);						// Size = 8 Prop3 Thrust
		private Offset<double> Offset2618 = new Offset<double>(0x2618);						// Size = 8 Prop3 Beta
		private Offset<double> Offset2700 = new Offset<double>(0x2700);						// Size = 8 Prop4 RPM
		private Offset<double> Offset2708 = new Offset<double>(0x2708);						// Size = 8 Prop4 RPM fraction
		private Offset<double> Offset2710 = new Offset<double>(0x2710);						// Size = 8 Prop4 Thrust
		private Offset<double> Offset2718 = new Offset<double>(0x2718);						// Size = 8 Prop4 Beta
		private Offset<uint> Offset281C = new Offset<uint>(0x281C);						// Size = 4 Master Battery Switch
		private Offset<double> Offset2834 = new Offset<double>(0x2834);						// Size = 8 Battery Volt.
		private Offset<double> Offset28C0 = new Offset<double>(0x28C0);						// Size = 8 Ambient Air Density [FS2002+]
		private Offset<double> Offset28C8 = new Offset<double>(0x28C8);						// Size = 8 Ambient Air Pressure lbs/sqft [FS2002+]
		private Offset<double> Offset28D0 = new Offset<double>(0x28D0);						// Size = 8 Static Air Temperature F [FS2002+]
		private Offset<double> Offset28D8 = new Offset<double>(0x28D8);						// Size = 8 Static Air Temperature R [FS2002+}
		private Offset<double> Offset28E0 = new Offset<double>(0x28E0);						// Size = 8 Standard Temperature Ratio [FS2002+]
		private Offset<double> Offset28E8 = new Offset<double>(0x28E8);						// Size = 8 Standard Pressure Ratio [FS2002+]
		private Offset<double> Offset28F0 = new Offset<double>(0x28F0);						// Size = 8 Standard Density Ratio [FS2002+]
		private Offset<int> Offset2900 = new Offset<int>(0x2900);						// Size = 4 AI traffic ID for control
		private Offset<uint> Offset2904 = new Offset<uint>(0x2904);						// Size = 4 AI traffic control number
		private Offset<int> Offset2908 = new Offset<int>(0x2908);						// Size = 4 AI traffic control parameter
		private Offset<uint> Offset290C = new Offset<uint>(0x290C);						// Size = 4 Hot buttons: # of slots
		private Offset<byte> Offset2910 = new Offset<byte>(0x2910);						// Size = 2 Hot Button Joystick + 128
		private Offset<byte> Offset2911 = new Offset<byte>(0x2911);						// Size = 2 Hot Button number 0-39
		private Offset<byte> Offset2912 = new Offset<byte>(0x2912);						// Size = 2 Hot Button change required
		private Offset<byte> Offset2913 = new Offset<byte>(0x2913);						// Size = 2 Hot Button result
		private Offset<double> Offset2A48 = new Offset<double>(0x2A48);						// Size = 8 Left folding wing %
		private Offset<double> Offset2A50 = new Offset<double>(0x2A50);						// Size = 8 Right folding wing %
		private Offset<double> Offset2A70 = new Offset<double>(0x2A70);						// Size = 8 Canopy open
		private Offset<double> Offset2A78 = new Offset<double>(0x2A78);						// Size = 8 Water left rudder extension
		private Offset<double> Offset2A80 = new Offset<double>(0x2A80);						// Size = 8 Water right rudder extension
		private Offset<ushort> Offset2A88 = new Offset<ushort>(0x2A88);						// Size = 2 Water rudder handle position
		private Offset<float> Offset2AAC = new Offset<float>(0x2AAC);						// Size = 4 VOR1 Localiser needle
		private Offset<float> Offset2AB0 = new Offset<float>(0x2AB0);						// Size = 4 VOR1 Glideslope needle
		private Offset<float> Offset2AB4 = new Offset<float>(0x2AB4);						// Size = 4 VOR2 Localiser needle
		private Offset<float> Offset2AB8 = new Offset<float>(0x2AB8);						// Size = 4 VOR2 Glideslope needle
		private Offset<double> Offset2B00 = new Offset<double>(0x2B00);						// Size = 8 Gyro Compass
		private Offset<ushort> Offset2DC6 = new Offset<ushort>(0x2DC6);						// Size = 2 Heli Beep
		private Offset<double> Offset2DC8 = new Offset<double>(0x2DC8);						// Size = 8 Aircraft wind X [FS2004]
		private Offset<double> Offset2DD0 = new Offset<double>(0x2DD0);						// Size = 8 Aircraft wind Y [FS2004]
		private Offset<double> Offset2DD8 = new Offset<double>(0x2DD8);						// Size = 8 Aircraft wind Z [FS2004]
		private Offset<double> Offset2DE0 = new Offset<double>(0x2DE0);						// Size = 8 Wind direction at aircraft [FS2004]
		private Offset<double> Offset2DE8 = new Offset<double>(0x2DE8);						// Size = 8 Wind speed at aircraft [FS2004]
		private Offset<double> Offset2DF0 = new Offset<double>(0x2DF0);						// Size = 8 Visibility at aircraft [FS2004] metres
		private Offset<uint> Offset2E80 = new Offset<uint>(0x2E80);						// Size = 4 Avionics Master Switch
		private Offset<uint> Offset2E88 = new Offset<uint>(0x2E88);						// Size = 4 Panel Autofeather Switch
		private Offset<double> Offset2E98 = new Offset<double>(0x2E98);						// Size = 8 Elevator Deflection
		private Offset<double> Offset2EA0 = new Offset<double>(0x2EA0);						// Size = 8 Elevator Trim
		private Offset<double> Offset2EA8 = new Offset<double>(0x2EA8);						// Size = 8 Aileron Deflection
		private Offset<double> Offset2EB0 = new Offset<double>(0x2EB0);						// Size = 8 Aileron Trim
		private Offset<double> Offset2EB8 = new Offset<double>(0x2EB8);						// Size = 8 Rudder Deflection
		private Offset<double> Offset2EC0 = new Offset<double>(0x2EC0);						// Size = 8 Rudder Trim
		private Offset<ushort> Offset2EC8 = new Offset<ushort>(0x2EC8);						// Size = 2 Prop.sync Active
		private Offset<double> Offset2ED0 = new Offset<double>(0x2ED0);						// Size = 8 Incidence Alpha
		private Offset<double> Offset2ED8 = new Offset<double>(0x2ED8);						// Size = 8 Incidence Beta
		private Offset<uint> Offset2EE0 = new Offset<uint>(0x2EE0);						// Size = 4 Flight Director Active
		private Offset<double> Offset2EE8 = new Offset<double>(0x2EE8);						// Size = 8 Flight Director Pitch
		private Offset<double> Offset2EF0 = new Offset<double>(0x2EF0);						// Size = 8 Flight Director Bank
		private Offset<double> Offset2EF8 = new Offset<double>(0x2EF8);						// Size = 8 CG %
		private Offset<double> Offset2F70 = new Offset<double>(0x2F70);						// Size = 8 Attitude Indicator Pitch
		private Offset<double> Offset2F78 = new Offset<double>(0x2F78);						// Size = 8 Attitude Indicator Bank
		private Offset<byte> Offset2F80 = new Offset<byte>(0x2F80);						// Size = 2 Panel Autobrake Switch
		private Offset<double> Offset2F88 = new Offset<double>(0x2F88);						// Size = 8 HSI CDI needle
		private Offset<double> Offset2F90 = new Offset<double>(0x2F90);						// Size = 8 HSI GSI needle
		private Offset<double> Offset2F98 = new Offset<double>(0x2F98);						// Size = 8 HSI speed indication (metres/sec)
		private Offset<double> Offset2FA0 = new Offset<double>(0x2FA0);						// Size = 8 HSI distance indication (metres)
		private Offset<byte> Offset2FAB = new Offset<byte>(0x2FAB);						// Size = 2 HSI GSI valid flag
		private Offset<byte> Offset2FAD = new Offset<byte>(0x2FAD);						// Size = 2 HSI To/From flag
		private Offset<byte> Offset2FAE = new Offset<byte>(0x2FAE);						// Size = 2 HSI has LOC flag
		private Offset<string> Offset2FB0 = new Offset<string>(0x2FB0, 6, true);						// Size = 6 HSI station ID
		private Offset<byte> Offset2FE0 = new Offset<byte>(0x2FE0);						// Size = 2 Modules/Add-ons menu
		private Offset<string> Offset3000 = new Offset<string>(0x3000, 6, true);						// Size = 6 VOR1 identity
		private Offset<string> Offset3006 = new Offset<string>(0x3006, 25, true);						// Size = 25 VOR1 name
		private Offset<string> Offset301F = new Offset<string>(0x301F, 6, true);						// Size = 6 VOR2 identity
		private Offset<string> Offset3025 = new Offset<string>(0x3025, 25, true);						// Size = 25 VOR2 name
		private Offset<string> Offset303E = new Offset<string>(0x303E, 6, true);						// Size = 6 NDB identity
		private Offset<string> Offset3044 = new Offset<string>(0x3044, 25, true);						// Size = 25 NDB name
		private Offset<double> Offset3060 = new Offset<double>(0x3060);						// Size = 8 X (Lateral) Acceleration [FS2000+]
		private Offset<double> Offset3068 = new Offset<double>(0x3068);						// Size = 8 Y (Vertical) Acceleration [FS2000+]
		private Offset<double> Offset3070 = new Offset<double>(0x3070);						// Size = 8 Z (Longitudinal) Acceleration [FS2000+]
		private Offset<double> Offset3078 = new Offset<double>(0x3078);						// Size = 8 Pitch Acceleration [FS2000+]
		private Offset<double> Offset3080 = new Offset<double>(0x3080);						// Size = 8 Roll Acceleration [FS2000+]
		private Offset<double> Offset3088 = new Offset<double>(0x3088);						// Size = 8 Yaw Acceleration [FS2000+]
		private Offset<double> Offset3090 = new Offset<double>(0x3090);						// Size = 8 Z (Longitudinal) GS-velocity [FS2000+]
		private Offset<double> Offset3098 = new Offset<double>(0x3098);						// Size = 8 X (Lateral) GS-velocity [FS2000+]
		private Offset<double> Offset30A0 = new Offset<double>(0x30A0);						// Size = 8 Y (Vertical) GS-velocity [FS2000+]
		private Offset<double> Offset30A8 = new Offset<double>(0x30A8);						// Size = 8 Pitch Velocity [FS2000+]
		private Offset<double> Offset30B0 = new Offset<double>(0x30B0);						// Size = 8 Roll Velocity [FS2000+]
		private Offset<double> Offset30B8 = new Offset<double>(0x30B8);						// Size = 8 Yaw Velocity [FS2000+]
		private Offset<double> Offset30C0 = new Offset<double>(0x30C0);						// Size = 8 Current loaded weight [FS2000+]
		private Offset<double> Offset30C8 = new Offset<double>(0x30C8);						// Size = 8 Plane's mass [FS2000+]
		private Offset<double> Offset30D8 = new Offset<double>(0x30D8);						// Size = 8 Dynamic pressure [FS2000+]
		private Offset<ushort> Offset30E0 = new Offset<ushort>(0x30E0);						// Size = 2 Trailing edge flaps left inboard %
		private Offset<ushort> Offset30E2 = new Offset<ushort>(0x30E2);						// Size = 2 Trailing edge flaps left outboard %
		private Offset<ushort> Offset30E4 = new Offset<ushort>(0x30E4);						// Size = 2 Trailing edge flaps right inboard %
		private Offset<ushort> Offset30E6 = new Offset<ushort>(0x30E6);						// Size = 2 Trailing edge flaps right outboard %
		private Offset<ushort> Offset30E8 = new Offset<ushort>(0x30E8);						// Size = 2 Leading edge flaps left inboard %
		private Offset<ushort> Offset30EA = new Offset<ushort>(0x30EA);						// Size = 2 Leading edge flaps left outboard %
		private Offset<ushort> Offset30EC = new Offset<ushort>(0x30EC);						// Size = 2 Leading edge flaps right inboard %
		private Offset<ushort> Offset30EE = new Offset<ushort>(0x30EE);						// Size = 2 Leading edge flaps right outboard %
		private Offset<short> Offset30F0 = new Offset<short>(0x30F0);						// Size = 2 Trailing edge flaps left inboard angle
		private Offset<short> Offset30F2 = new Offset<short>(0x30F2);						// Size = 2 Trailing edge flaps left outboard angle
		private Offset<short> Offset30F4 = new Offset<short>(0x30F4);						// Size = 2 Trailing edge flaps right inboard angle
		private Offset<short> Offset30F6 = new Offset<short>(0x30F6);						// Size = 2 Trailing edge flaps right outboard angle
		private Offset<short> Offset30F8 = new Offset<short>(0x30F8);						// Size = 2 Leading edge flaps left inboard angle
		private Offset<short> Offset30FA = new Offset<short>(0x30FA);						// Size = 2 Leading edge flaps left outboard angle
		private Offset<short> Offset30FC = new Offset<short>(0x30FC);						// Size = 2 Leading edge flaps right inboard angle
		private Offset<short> Offset30FE = new Offset<short>(0x30FE);						// Size = 2 Leading edge flaps right outboard angle
		private Offset<byte> Offset3100 = new Offset<byte>(0x3100);						// Size = 2 Engine primer
		private Offset<byte> Offset3101 = new Offset<byte>(0x3101);						// Size = 2 Master Alternator switch
		private Offset<byte> Offset3102 = new Offset<byte>(0x3102);						// Size = 2 Master Battery switch
		private Offset<byte> Offset3103 = new Offset<byte>(0x3103);						// Size = 2 Avionics switch
		private Offset<byte> Offset3104 = new Offset<byte>(0x3104);						// Size = 2 Fuel pump swittch
		private Offset<byte> Offset3105 = new Offset<byte>(0x3105);						// Size = 2 VOR1 morse ID switch
		private Offset<byte> Offset3106 = new Offset<byte>(0x3106);						// Size = 2 VOR2 morse ID switch
		private Offset<byte> Offset3107 = new Offset<byte>(0x3107);						// Size = 2 NDB morse ID switch
		private Offset<byte> Offset3108 = new Offset<byte>(0x3108);						// Size = 2 Autotune ADF1 disable
		private Offset<byte> Offset3109 = new Offset<byte>(0x3109);						// Size = 2 Axis calibration disable
		private Offset<byte> Offset310A = new Offset<byte>(0x310A);						// Size = 2 Joystick axis disable flags
		private Offset<byte> Offset310B = new Offset<byte>(0x310B);						// Size = 2 Slew axis (plus thr 3/4) disable flags
		private Offset<ushort> Offset310C = new Offset<ushort>(0x310C);						// Size = 2 PFC switch code input simulation
		private Offset<uint> Offset3110 = new Offset<uint>(0x3110);						// Size = 4 FS Control to be executed
		private Offset<int> Offset3114 = new Offset<int>(0x3114);						// Size = 4 FS Control parameter value
		private Offset<ushort> Offset3118 = new Offset<ushort>(0x3118);						// Size = 2 COM2 freq (FS2002+)
		private Offset<ushort> Offset311A = new Offset<ushort>(0x311A);						// Size = 2 COM1 STBY freq (FS2002+)
		private Offset<ushort> Offset311C = new Offset<ushort>(0x311C);						// Size = 2 COM2 STBY freq (FS2002+)
		private Offset<ushort> Offset311E = new Offset<ushort>(0x311E);						// Size = 2 NAV1 STBY freq (FS2002+)
		private Offset<ushort> Offset3120 = new Offset<ushort>(0x3120);						// Size = 2 NAV2 STBY freq (FS2002+)
		private Offset<byte> Offset3122 = new Offset<byte>(0x3122);						// Size = 2 Radio sound select switches (FS2002+)
		private Offset<byte> Offset3123 = new Offset<byte>(0x3123);						// Size = 2 Radio swap controls (FS2002+)
		private Offset<byte> Offset3125 = new Offset<byte>(0x3125);						// Size = 2 Fuel pump switches (separate per engine))
		private Offset<byte> Offset3127 = new Offset<byte>(0x3127);						// Size = 2 FSUIPC Option Control Timer
		private Offset<uint> Offset3128 = new Offset<uint>(0x3128);						// Size = 4 FSUIPC Option Mask
		private Offset<uint> Offset312C = new Offset<uint>(0x312C);						// Size = 4 FSUIPC Option Settings
		private Offset<string> Offset3130 = new Offset<string>(0x3130, 12, true);						// Size = 12 ATC flight no. [FS2002+]
		private Offset<string> Offset313C = new Offset<string>(0x313C, 12, true);						// Size = 12 ATC id (tail no.) [FS2002+]
		private Offset<string> Offset3148 = new Offset<string>(0x3148, 24, true);						// Size = 24 ATC airline [FS2002+]
		private Offset<string> Offset3160 = new Offset<string>(0x3160, 24, true);						// Size = 24 ATC aircraft type [FS2002+]
		private Offset<double> Offset3178 = new Offset<double>(0x3178);						// Size = 8 Z (Longitudinal) TAS-vel body axes (FS2000+)
		private Offset<double> Offset3180 = new Offset<double>(0x3180);						// Size = 8 X (Lateral) TAS-vel body axes (FS2000+)
		private Offset<double> Offset3188 = new Offset<double>(0x3188);						// Size = 8 Y (Vertical) TAS-vel body axes (FS2000+)
		private Offset<double> Offset3190 = new Offset<double>(0x3190);						// Size = 8 Z (Longitudinal) GS-vel world axes (FS2000+)
		private Offset<double> Offset3198 = new Offset<double>(0x3198);						// Size = 8 X (Lateral) GS-vel world axes (FS2000+)
		private Offset<double> Offset31A0 = new Offset<double>(0x31A0);						// Size = 8 Y (Vertical) GS-vel world axes (FS2000+)
		private Offset<double> Offset31A8 = new Offset<double>(0x31A8);						// Size = 8 Pitch vel world axes (FS2000+)
		private Offset<double> Offset31B0 = new Offset<double>(0x31B0);						// Size = 8 Roll vel world axes (FS2000+)
		private Offset<double> Offset31B8 = new Offset<double>(0x31B8);						// Size = 8 Yaw vel world axes (FS2000+)
		private Offset<double> Offset31C0 = new Offset<double>(0x31C0);						// Size = 8 X (Lateral) Acceleration [FS2002+]
		private Offset<double> Offset31C8 = new Offset<double>(0x31C8);						// Size = 8 Y (Vertical) Acceleration [FS2002+]
		private Offset<double> Offset31D0 = new Offset<double>(0x31D0);						// Size = 8 Z (Longitudinal) Acceleration [FS2002+]
		private Offset<short> Offset31D8 = new Offset<short>(0x31D8);						// Size = 2 Slew axis longitudinal axis input
		private Offset<short> Offset31DA = new Offset<short>(0x31DA);						// Size = 2 Slew axis lateral axis input
		private Offset<short> Offset31DC = new Offset<short>(0x31DC);						// Size = 2 Slew axis yaw axis input
		private Offset<short> Offset31DE = new Offset<short>(0x31DE);						// Size = 2 Slew axis vertical axis input
		private Offset<short> Offset31E0 = new Offset<short>(0x31E0);						// Size = 2 Slew axis roll axis input
		private Offset<short> Offset31E2 = new Offset<short>(0x31E2);						// Size = 2 Slew axis pitch axis input
		private Offset<uint> Offset31E4 = new Offset<uint>(0x31E4);						// Size = 4 Radio altitude
		private Offset<uint> Offset31E8 = new Offset<uint>(0x31E8);						// Size = 4 Surface type (FS2002)
		private Offset<uint> Offset31EC = new Offset<uint>(0x31EC);						// Size = 4 Surface condition (FS2002)
		private Offset<uint> Offset31F0 = new Offset<uint>(0x31F0);						// Size = 4 Pushback State (FS2002+]
		private Offset<uint> Offset31F4 = new Offset<uint>(0x31F4);						// Size = 4 Pushback Control [FS2002+]
		private Offset<uint> Offset31F8 = new Offset<uint>(0x31F8);						// Size = 4 Tug heading [FS2002+] for gliders?
		private Offset<uint> Offset31FC = new Offset<uint>(0x31FC);						// Size = 4 Tug speed [FS2002+] for gliders?
		private Offset<uint> Offset3200 = new Offset<uint>(0x3200);						// Size = 4 Key press to FS
		private Offset<uint> Offset320C = new Offset<uint>(0x320C);						// Size = 4 Hot keys: # of slots
		private Offset<byte> Offset3210 = new Offset<byte>(0x3210);						// Size = 2 Hot Key keycode
		private Offset<byte> Offset3211 = new Offset<byte>(0x3211);						// Size = 2 Hot Key shift states
		private Offset<byte> Offset3212 = new Offset<byte>(0x3212);						// Size = 2 Hot Key App flags
		private Offset<byte> Offset3213 = new Offset<byte>(0x3213);						// Size = 2 Hot Key result
		private Offset<uint> Offset32F0 = new Offset<uint>(0x32F0);						// Size = 4 Protected Options control
		private Offset<ushort> Offset32F6 = new Offset<ushort>(0x32F6);						// Size = 2 FSUIPC tech opts inhibits (if user allows)
		private Offset<ushort> Offset32F8 = new Offset<ushort>(0x32F8);						// Size = 2 Assorted facility inhibits [FS2004 only]
		private Offset<byte> Offset32F9 = new Offset<byte>(0x32F9);						// Size = 2 Brakes being used flag
		private Offset<short> Offset32FA = new Offset<short>(0x32FA);						// Size = 2 Text display control
		private Offset<ushort> Offset32FC = new Offset<ushort>(0x32FC);						// Size = 2 AIR file change counter
		private Offset<byte> Offset32FE = new Offset<byte>(0x32FE);						// Size = 2 Hot Key flags changed counter
		private Offset<byte> Offset32FF = new Offset<byte>(0x32FF);						// Size = 2 Hot Buttons changed counter
		private Offset<ushort> Offset3300 = new Offset<ushort>(0x3300);						// Size = 2 Navaid status flags
		private Offset<ushort> Offset3302 = new Offset<ushort>(0x3302);						// Size = 2 FSUIPC option flags
		private Offset<ushort> Offset3304 = new Offset<ushort>(0x3304);						// Size = 2 FSUIPC interim version Id
		private Offset<ushort> Offset3306 = new Offset<ushort>(0x3306);						// Size = 2 FSUIPC version
		private Offset<ushort> Offset3308 = new Offset<ushort>(0x3308);						// Size = 2 FS version
		private Offset<ushort> Offset330A = new Offset<ushort>(0x330A);						// Size = 2 Validity pattern FADE
		private Offset<byte> Offset330E = new Offset<byte>(0x330E);						// Size = 2 IPC application counter
		private Offset<ushort> Offset3320 = new Offset<ushort>(0x3320);						// Size = 2 WideFS Shutdown Option
		private Offset<ushort> Offset3322 = new Offset<ushort>(0x3322);						// Size = 2 WideServer version
		private Offset<int> Offset3324 = new Offset<int>(0x3324);						// Size = 4 Altimeter altitude in feet OR metres
		private Offset<short> Offset3328 = new Offset<short>(0x3328);						// Size = 2 Elevator axis input
		private Offset<short> Offset332A = new Offset<short>(0x332A);						// Size = 2 Ailerons axis input
		private Offset<short> Offset332C = new Offset<short>(0x332C);						// Size = 2 Rudder axis input
		private Offset<short> Offset332E = new Offset<short>(0x332E);						// Size = 2 Throttle (common) axis input
		private Offset<short> Offset3330 = new Offset<short>(0x3330);						// Size = 2 Throttle 1 axis input
		private Offset<short> Offset3332 = new Offset<short>(0x3332);						// Size = 2 Throttle 2 axis input
		private Offset<short> Offset3334 = new Offset<short>(0x3334);						// Size = 2 Throttle 3 axis input
		private Offset<short> Offset3336 = new Offset<short>(0x3336);						// Size = 2 Throttle 4 axis input
		private Offset<short> Offset3338 = new Offset<short>(0x3338);						// Size = 2 Elevator trim axis input
		private Offset<short> Offset333A = new Offset<short>(0x333A);						// Size = 2 Throttle reverse limit
		private Offset<ushort> Offset333C = new Offset<ushort>(0x333C);						// Size = 2 WideFS flags
		private Offset<ushort> Offset333E = new Offset<ushort>(0x333E);						// Size = 2 Weather clear count
		private Offset<uint> Offset3340 = new Offset<uint>(0x3340);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset3344 = new Offset<uint>(0x3344);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset3348 = new Offset<uint>(0x3348);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset334C = new Offset<uint>(0x334C);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset3350 = new Offset<uint>(0x3350);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset3354 = new Offset<uint>(0x3354);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset3358 = new Offset<uint>(0x3358);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset335C = new Offset<uint>(0x335C);						// Size = 4 Virtual Buttons
		private Offset<uint> Offset3360 = new Offset<uint>(0x3360);						// Size = 4 Virtual Buttons
		private Offset<byte> Offset3364 = new Offset<byte>(0x3364);						// Size = 2 FS2004 ready to fly flag
		private Offset<byte> Offset3365 = new Offset<byte>(0x3365);						// Size = 2 Paused in menu flag
		private Offset<byte> Offset3366 = new Offset<byte>(0x3366);						// Size = 2 Engine Fire Flags
		private Offset<byte> Offset3367 = new Offset<byte>(0x3367);						// Size = 2 Doors open flags [FS2004]
		private Offset<uint> Offset3368 = new Offset<uint>(0x3368);						// Size = 4 PFC MCP events flags
		private Offset<ushort> Offset336C = new Offset<ushort>(0x336C);						// Size = 2 Frame rate entry counter
		private Offset<ushort> Offset336E = new Offset<ushort>(0x336E);						// Size = 2 Toe brakes handled by FSUIPC
		private Offset<uint> Offset3370 = new Offset<uint>(0x3370);						// Size = 4 PFC driver diagnostic area
		private Offset<uint> Offset3374 = new Offset<uint>(0x3374);						// Size = 4 Live millisecond expired counter
		private Offset<uint> Offset3378 = new Offset<uint>(0x3378);						// Size = 4 Last log message time
		private Offset<byte> Offset337C = new Offset<byte>(0x337C);						// Size = 2 Prop De-ice switch [FS2002+]
		private Offset<byte> Offset337D = new Offset<byte>(0x337D);						// Size = 2 Structural De-ice switch [FS2002+]
		private Offset<ushort> Offset337E = new Offset<ushort>(0x337E);						// Size = 2 FSUIPC activity counter
		private Offset<string> Offset3380 = new Offset<string>(0x3380, 128, true);						// Size = 128 Text display in FS
		private Offset<short> Offset3412 = new Offset<short>(0x3412);						// Size = 2 Spoiler axis input
		private Offset<short> Offset3414 = new Offset<short>(0x3414);						// Size = 2 Flaps axis input
		private Offset<short> Offset3416 = new Offset<short>(0x3416);						// Size = 2 Left Brake axis input
		private Offset<short> Offset3418 = new Offset<short>(0x3418);						// Size = 2 Right Brake axis input
		private Offset<byte> Offset341A = new Offset<byte>(0x341A);						// Size = 2 Additional axis disable flags
		private Offset<double> Offset3470 = new Offset<double>(0x3470);						// Size = 8 Ambient wind X [FS2002+] m/sec
		private Offset<double> Offset3478 = new Offset<double>(0x3478);						// Size = 8 Ambient wind Y [FS2002+] m/sec
		private Offset<double> Offset3480 = new Offset<double>(0x3480);						// Size = 8 Ambient wind Z [FS2002+] m/sec
		private Offset<double> Offset3488 = new Offset<double>(0x3488);						// Size = 8 Ambient wind velocity [FS2002+] m/sec
		private Offset<double> Offset3490 = new Offset<double>(0x3490);						// Size = 8 Ambient wind direction [FS2002+]
		private Offset<double> Offset3498 = new Offset<double>(0x3498);						// Size = 8 Ambient pressure [FS2002+]
		private Offset<double> Offset34A0 = new Offset<double>(0x34A0);						// Size = 8 Sea level pressure (QNH) [FS2002+]
		private Offset<double> Offset34A8 = new Offset<double>(0x34A8);						// Size = 8 Ambient temperature [FS2002+]
		private Offset<double> Offset34B0 = new Offset<double>(0x34B0);						// Size = 8 Pressure Altitude
		private Offset<double> Offset34B8 = new Offset<double>(0x34B8);						// Size = 8 Standard ATM Temperature
		private Offset<double> Offset34C8 = new Offset<double>(0x34C8);						// Size = 8 Total Velocity
		private Offset<string> Offset3500 = new Offset<string>(0x3500, 24, true);						// Size = 24 ATC aircraft model [FS2002+]
		private Offset<double> Offset3518 = new Offset<double>(0x3518);						// Size = 8 Ambient Wind Y (vertical wind) original
		private Offset<ushort> Offset3520 = new Offset<ushort>(0x3520);						// Size = 2 WideClient lowest version number if > 6441
		private Offset<byte> Offset3541 = new Offset<byte>(0x3541);						// Size = 2 Lat/Lon freeze timer
		private Offset<ushort> Offset3542 = new Offset<ushort>(0x3542);						// Size = 2 Standby altimeter pressure setting (mb x 16)
		private Offset<int> Offset3544 = new Offset<int>(0x3544);						// Size = 4 Standby altimeter altitude reading
		private Offset<double> Offset3548 = new Offset<double>(0x3548);						// Size = 8 Horizon Bar / Attitude Bars
		private Offset<short> Offset3550 = new Offset<short>(0x3550);						// Size = 2 ENG4 Throttle Lever Pos
		private Offset<ushort> Offset3552 = new Offset<ushort>(0x3552);						// Size = 2 ENG4 Prop. Lever Pos
		private Offset<ushort> Offset3554 = new Offset<ushort>(0x3554);						// Size = 2 ENG4 Mixture Lever Pos
		private Offset<ushort> Offset3556 = new Offset<ushort>(0x3556);						// Size = 2 ENG4 Starter Switch Pos
		private Offset<ushort> Offset3558 = new Offset<ushort>(0x3558);						// Size = 2 ENG4 Magneto Left
		private Offset<ushort> Offset355A = new Offset<ushort>(0x355A);						// Size = 2 ENG4 Magneto Right
		private Offset<ushort> Offset3560 = new Offset<ushort>(0x3560);						// Size = 2 ENG3 Throttle Lever Pos
		private Offset<ushort> Offset3562 = new Offset<ushort>(0x3562);						// Size = 2 ENG3 Prop. Lever Pos
		private Offset<ushort> Offset3564 = new Offset<ushort>(0x3564);						// Size = 2 ENG3 Mixture Lever Pos
		private Offset<ushort> Offset3566 = new Offset<ushort>(0x3566);						// Size = 2 ENG3 Starter Switch Pos
		private Offset<ushort> Offset3568 = new Offset<ushort>(0x3568);						// Size = 2 ENG3 Magneto Left
		private Offset<ushort> Offset356A = new Offset<ushort>(0x356A);						// Size = 2 ENG3 Magneto Right
		private Offset<ushort> Offset3570 = new Offset<ushort>(0x3570);						// Size = 2 ENG2 Throttle Lever Pos
		private Offset<ushort> Offset3572 = new Offset<ushort>(0x3572);						// Size = 2 ENG2 Throttle Lever Pos
		private Offset<ushort> Offset3574 = new Offset<ushort>(0x3574);						// Size = 2 ENG2 Mixture Lever Pos
		private Offset<ushort> Offset3576 = new Offset<ushort>(0x3576);						// Size = 2 ENG2 Starter Switch Pos
		private Offset<ushort> Offset3578 = new Offset<ushort>(0x3578);						// Size = 2 ENG2 Magneto Left
		private Offset<ushort> Offset357A = new Offset<ushort>(0x357A);						// Size = 2 ENG2 Magneto Right
		private Offset<ushort> Offset3580 = new Offset<ushort>(0x3580);						// Size = 2 ENG1 Throttle Lever Pos
		private Offset<ushort> Offset3582 = new Offset<ushort>(0x3582);						// Size = 2 ENG1 Throttle Lever Pos
		private Offset<ushort> Offset3584 = new Offset<ushort>(0x3584);						// Size = 2 ENG1 Mixture Lever Pos
		private Offset<ushort> Offset3586 = new Offset<ushort>(0x3586);						// Size = 2 ENG1 Starter Switch Pos
		private Offset<ushort> Offset3588 = new Offset<ushort>(0x3588);						// Size = 2 ENG1 Magneto Left
		private Offset<ushort> Offset358A = new Offset<ushort>(0x358A);						// Size = 2 ENG1 Magneto Right
		private Offset<uint> Offset3590 = new Offset<uint>(0x3590);						// Size = 4 Engine 1 Fuel Valve [FS2002+]
		private Offset<uint> Offset3594 = new Offset<uint>(0x3594);						// Size = 4 Engine 2 Fuel Valve [FS2002+]
		private Offset<uint> Offset3598 = new Offset<uint>(0x3598);						// Size = 4 Engine 3 Fuel Valve [FS2002+]
		private Offset<uint> Offset359C = new Offset<uint>(0x359C);						// Size = 4 Engine 4 Fuel Valve [FS2002+]
		private Offset<double> Offset35A0 = new Offset<double>(0x35A0);						// Size = 8 Airspeed Mach value
		private Offset<double> Offset35A8 = new Offset<double>(0x35A8);						// Size = 8 Recip. ENG4 Manif. Press.
		private Offset<double> Offset35E0 = new Offset<double>(0x35E0);						// Size = 8 Recip. ENG4 Brake Power
		private Offset<double> Offset35E8 = new Offset<double>(0x35E8);						// Size = 8 Recip ENG4 Carb temp [FS2002+]
		private Offset<double> Offset35F0 = new Offset<double>(0x35F0);						// Size = 8 Recip. ENG4 Starter Torque
		private Offset<uint> Offset35F8 = new Offset<uint>(0x35F8);						// Size = 4 Recip. ENG4 Turbocharger Failed
		private Offset<uint> Offset35FC = new Offset<uint>(0x35FC);						// Size = 4 Recip. ENG4 Emergency Boost Active
		private Offset<double> Offset3600 = new Offset<double>(0x3600);						// Size = 8 Recip. ENG4 Emergency Boost Elapsed Time
		private Offset<double> Offset3608 = new Offset<double>(0x3608);						// Size = 8 Recip. ENG4 Wastegate Pos
		private Offset<double> Offset3610 = new Offset<double>(0x3610);						// Size = 8 Recip. ENG4 TIT Degr.
		private Offset<double> Offset3618 = new Offset<double>(0x3618);						// Size = 8 Recip. ENG4 CHT Degr.
		private Offset<double> Offset3620 = new Offset<double>(0x3620);						// Size = 8 Recip. ENG4 Radiator Degr.
		private Offset<double> Offset3628 = new Offset<double>(0x3628);						// Size = 8 Recip. ENG4 Fuel Pressure PSF
		private Offset<uint> Offset3640 = new Offset<uint>(0x3640);						// Size = 4 Recip. ENG4 Tank Selector
		private Offset<uint> Offset3644 = new Offset<uint>(0x3644);						// Size = 4 Recip. ENG4 Tanks used
		private Offset<uint> Offset3648 = new Offset<uint>(0x3648);						// Size = 4 Recip. ENG4 Number of Tanks used
		private Offset<double> Offset364C = new Offset<double>(0x364C);						// Size = 8 Recip. ENG4 FuelFlow PPH
		private Offset<uint> Offset3654 = new Offset<uint>(0x3654);						// Size = 4 Recip. ENG4 Fuel available
		private Offset<double> Offset3660 = new Offset<double>(0x3660);						// Size = 8 Recip. ENG3 Engine RPM
		private Offset<double> Offset3668 = new Offset<double>(0x3668);						// Size = 8 Recip. ENG3 Mainf. Press.
		private Offset<double> Offset3670 = new Offset<double>(0x3670);						// Size = 8 Recip. ENG3 Cowl Flap Pos
		private Offset<double> Offset3678 = new Offset<double>(0x3678);						// Size = 8 Recip. ENG3 Carb Heat Pos
		private Offset<double> Offset3680 = new Offset<double>(0x3680);						// Size = 8 Recip. ENG3 Alt. Air Pos
		private Offset<double> Offset3688 = new Offset<double>(0x3688);						// Size = 8 Recip. ENG3 Coolant Reservoir Pct.
		private Offset<uint> Offset3690 = new Offset<uint>(0x3690);						// Size = 4 Recip. ENG3 Left Mag Select
		private Offset<uint> Offset3694 = new Offset<uint>(0x3694);						// Size = 4 Recip. ENG3 Right Mag Select
		private Offset<double> Offset3698 = new Offset<double>(0x3698);						// Size = 8 Recip. ENG3 fuel/air mass ratio
		private Offset<double> Offset36A0 = new Offset<double>(0x36A0);						// Size = 8 Recip. ENG3 Brake Power
		private Offset<double> Offset36A8 = new Offset<double>(0x36A8);						// Size = 8 Recip. ENG3 Carb Temp [FS2002+]
		private Offset<double> Offset36B0 = new Offset<double>(0x36B0);						// Size = 8 Recip. ENG3 Starter Torque
		private Offset<uint> Offset36B8 = new Offset<uint>(0x36B8);						// Size = 4 Recip. ENG3 Turbocharger Failed
		private Offset<uint> Offset36BC = new Offset<uint>(0x36BC);						// Size = 4 Recip. ENG3 Emergency Boost Active
		private Offset<double> Offset36C0 = new Offset<double>(0x36C0);						// Size = 8 Recip. ENG3 Emergency Boost Elapsed time
		private Offset<double> Offset36C8 = new Offset<double>(0x36C8);						// Size = 8 Recip. ENG3 Wastegate Pos
		private Offset<double> Offset36D0 = new Offset<double>(0x36D0);						// Size = 8 Recip. ENG3 TIT Degr.
		private Offset<double> Offset36D8 = new Offset<double>(0x36D8);						// Size = 8 Recip. ENG3 CHT Degr.
		private Offset<double> Offset36E0 = new Offset<double>(0x36E0);						// Size = 8 Recip. ENG3 Radiator Degr.
		private Offset<double> Offset36E8 = new Offset<double>(0x36E8);						// Size = 8 Recip. ENG3 Fuel Pressure PSF
		private Offset<uint> Offset3700 = new Offset<uint>(0x3700);						// Size = 4 Recip. ENG3 Tank Selector
		private Offset<uint> Offset3704 = new Offset<uint>(0x3704);						// Size = 4 Recip. ENG3 Tanks used
		private Offset<uint> Offset3708 = new Offset<uint>(0x3708);						// Size = 4 Recip. ENG3 Number of Tanks user
		private Offset<double> Offset370C = new Offset<double>(0x370C);						// Size = 8 Recip. ENG3 FuelFlow PPH
		private Offset<uint> Offset3714 = new Offset<uint>(0x3714);						// Size = 4 Recip. ENG3 Fuel Available
		private Offset<double> Offset3720 = new Offset<double>(0x3720);						// Size = 8 Recip. ENG2 Engine RPM
		private Offset<double> Offset3728 = new Offset<double>(0x3728);						// Size = 8 Recip. ENG2 Manif. Press.
		private Offset<double> Offset3730 = new Offset<double>(0x3730);						// Size = 8 Recip. ENG2 Cowl Flap Pos
		private Offset<double> Offset3738 = new Offset<double>(0x3738);						// Size = 8 Recip. ENG2 Carb Heat Pos
		private Offset<double> Offset3740 = new Offset<double>(0x3740);						// Size = 8 Recip. ENG2 Alt. Air Pos
		private Offset<double> Offset3748 = new Offset<double>(0x3748);						// Size = 8 Recip. ENG2 Coolant Reservoir Pct
		private Offset<uint> Offset3750 = new Offset<uint>(0x3750);						// Size = 4 Recip. ENG2 Left Mag Select
		private Offset<uint> Offset3754 = new Offset<uint>(0x3754);						// Size = 4 Recip. ENG2 Right Mag Select
		private Offset<double> Offset3758 = new Offset<double>(0x3758);						// Size = 8 Recip. ENG2 fuel/air mass ratio
		private Offset<double> Offset3760 = new Offset<double>(0x3760);						// Size = 8 Recip. ENG2 Brake Power
		private Offset<double> Offset3768 = new Offset<double>(0x3768);						// Size = 8 Recip. ENG2 Carb temp [FS2002+]
		private Offset<double> Offset3770 = new Offset<double>(0x3770);						// Size = 8 Recip. ENG2 Starter Torque
		private Offset<uint> Offset3778 = new Offset<uint>(0x3778);						// Size = 4 Recip. ENG2 Turbocharger Failed
		private Offset<uint> Offset377C = new Offset<uint>(0x377C);						// Size = 4 Recip. ENG2 Emergency Boost Active
		private Offset<double> Offset3780 = new Offset<double>(0x3780);						// Size = 8 Recip. ENG2 Emergency Boost Elapsed Time
		private Offset<double> Offset3788 = new Offset<double>(0x3788);						// Size = 8 Recip. ENG2 Wastegate Pos
		private Offset<double> Offset3790 = new Offset<double>(0x3790);						// Size = 8 Recip. ENG2 TIT Degr.
		private Offset<double> Offset3798 = new Offset<double>(0x3798);						// Size = 8 Recip. ENG2 CHT Degr.
		private Offset<double> Offset37A0 = new Offset<double>(0x37A0);						// Size = 8 Recip. ENG2 Radiator Degr
		private Offset<double> Offset37A8 = new Offset<double>(0x37A8);						// Size = 8 Recip. ENG2 Fuel Pressure PSF
		private Offset<uint> Offset37C0 = new Offset<uint>(0x37C0);						// Size = 4 Recip. ENG2 Tank Selector
		private Offset<uint> Offset37C4 = new Offset<uint>(0x37C4);						// Size = 4 Recip. ENG2 Tanks used
		private Offset<uint> Offset37C8 = new Offset<uint>(0x37C8);						// Size = 4 Recip. ENG2 Number of Tanks used
		private Offset<double> Offset37CC = new Offset<double>(0x37CC);						// Size = 8 Recip. ENG2 FuelFlow PPH
		private Offset<uint> Offset37D4 = new Offset<uint>(0x37D4);						// Size = 4 Recip. ENG2 Fuel Available
		private Offset<double> Offset37E0 = new Offset<double>(0x37E0);						// Size = 8 Recip. ENG1 Engine RPM
		private Offset<double> Offset37E8 = new Offset<double>(0x37E8);						// Size = 8 Recip. ENG1 Manif. Press.
		private Offset<double> Offset37F0 = new Offset<double>(0x37F0);						// Size = 8 Recip. ENG1 Cowl Flap Pos
		private Offset<double> Offset37F8 = new Offset<double>(0x37F8);						// Size = 8 Recip. ENG1 Carb. Heat Pos
		private Offset<double> Offset3800 = new Offset<double>(0x3800);						// Size = 8 Recip. ENG1 Alt. Air Pos
		private Offset<double> Offset3808 = new Offset<double>(0x3808);						// Size = 8 Recip. ENG1 Coolant Reservoir Pct.
		private Offset<uint> Offset3810 = new Offset<uint>(0x3810);						// Size = 4 Recip. ENG1 Left Mag Select
		private Offset<uint> Offset3814 = new Offset<uint>(0x3814);						// Size = 4 Recip. ENG1 Right Mag Select
		private Offset<double> Offset3818 = new Offset<double>(0x3818);						// Size = 8 Recip. ENG1 fuel/air mass ratio
		private Offset<double> Offset3820 = new Offset<double>(0x3820);						// Size = 8 Recip. ENG1 Brake Power
		private Offset<double> Offset3828 = new Offset<double>(0x3828);						// Size = 8 Recip. ENG1 Carb temp [FS2002+]
		private Offset<double> Offset3830 = new Offset<double>(0x3830);						// Size = 8 Recip. ENG1 Starter Torque
		private Offset<uint> Offset3838 = new Offset<uint>(0x3838);						// Size = 4 Recip. ENG1 Turbocharger Failed
		private Offset<uint> Offset383C = new Offset<uint>(0x383C);						// Size = 4 Recip. ENG1 Emergency Boost Active
		private Offset<double> Offset3840 = new Offset<double>(0x3840);						// Size = 8 Recip. ENG1 Emergency Boost Elapsed Time
		private Offset<double> Offset3848 = new Offset<double>(0x3848);						// Size = 8 Recip. ENG1 Wastgate Pos
		private Offset<double> Offset3850 = new Offset<double>(0x3850);						// Size = 8 Recip. ENG1 TIT Degr.
		private Offset<double> Offset3858 = new Offset<double>(0x3858);						// Size = 8 Recip. ENG1 CHT Degr.
		private Offset<double> Offset3860 = new Offset<double>(0x3860);						// Size = 8 Recip. ENG1 Radiator Degr.
		private Offset<double> Offset3868 = new Offset<double>(0x3868);						// Size = 8 Recip. ENG1 Fuel Pressure PSF
		private Offset<double> Offset3870 = new Offset<double>(0x3870);						// Size = 8 Engine Primer ???
		private Offset<uint> Offset3880 = new Offset<uint>(0x3880);						// Size = 4 Recip. ENG1 Tank Selector
		private Offset<uint> Offset3884 = new Offset<uint>(0x3884);						// Size = 4 Recip. ENG1 Tanks used
		private Offset<uint> Offset3888 = new Offset<uint>(0x3888);						// Size = 4 Recip. ENG1 Number of Tanks used
		private Offset<double> Offset388C = new Offset<double>(0x388C);						// Size = 8 Recip. ENG1 FuelFlow PPH
		private Offset<uint> Offset3894 = new Offset<uint>(0x3894);						// Size = 4 Recip. ENG1 Fuel Available
		private Offset<uint> Offset38A0 = new Offset<uint>(0x38A0);						// Size = 4 ENG4 General Failure
		private Offset<uint> Offset38A4 = new Offset<uint>(0x38A4);						// Size = 4 ENG4 Recip. Combustion
		private Offset<double> Offset38A8 = new Offset<double>(0x38A8);						// Size = 8 ENG4 (Recip./General) Throttle Lever Pos
		private Offset<double> Offset38B0 = new Offset<double>(0x38B0);						// Size = 8 ENG4 (Recip./General) Mixture Lever Pos
		private Offset<double> Offset38B8 = new Offset<double>(0x38B8);						// Size = 8 ENG4 (Recip./General) Prop. Lever Pos
		private Offset<uint> Offset38C0 = new Offset<uint>(0x38C0);						// Size = 4 ENG4 (Recip./General) Starter
		private Offset<double> Offset3918 = new Offset<double>(0x3918);						// Size = 8 ENG4 (Recip./General) Oil Temp
		private Offset<double> Offset3920 = new Offset<double>(0x3920);						// Size = 8 ENG4 (Recip./General) Oil Press.
		private Offset<double> Offset3928 = new Offset<double>(0x3928);						// Size = 8 ENG4 Recip. Oil leak
		private Offset<double> Offset3930 = new Offset<double>(0x3930);						// Size = 8 ENG4 (Recip./General) EGT
		private Offset<uint> Offset3938 = new Offset<uint>(0x3938);						// Size = 4 ENG4 General Generator Switch
		private Offset<uint> Offset393C = new Offset<uint>(0x393C);						// Size = 4 ENG4 General Generator Active
		private Offset<double> Offset3940 = new Offset<double>(0x3940);						// Size = 8 ENG4 Recip. Damage Pct.
		private Offset<double> Offset3948 = new Offset<double>(0x3948);						// Size = 8 ENG4 Recip. Combustion Sound Pct.
		private Offset<uint> Offset3958 = new Offset<uint>(0x3958);						// Size = 4 ENG4 Recip. Fuel Pump Switch
		private Offset<uint> Offset3960 = new Offset<uint>(0x3960);						// Size = 4 ENG3 General Failure
		private Offset<uint> Offset3964 = new Offset<uint>(0x3964);						// Size = 4 ENG3 Recip. Combustion
		private Offset<double> Offset3968 = new Offset<double>(0x3968);						// Size = 8 ENG3 (Recip./General) Throttle Lever Pos
		private Offset<double> Offset3970 = new Offset<double>(0x3970);						// Size = 8 ENG3 (Recip./General) Mixture Lever Pos
		private Offset<double> Offset3978 = new Offset<double>(0x3978);						// Size = 8 ENG3 (Recip./General) Prop. Lever Pos
		private Offset<uint> Offset3980 = new Offset<uint>(0x3980);						// Size = 4 ENG3 (Recip./General) Starter
		private Offset<double> Offset39D8 = new Offset<double>(0x39D8);						// Size = 8 ENG3 (Recip./General) Oil Temp
		private Offset<double> Offset39E0 = new Offset<double>(0x39E0);						// Size = 8 ENG3 (Recip./General) Oil Press.
		private Offset<double> Offset39E8 = new Offset<double>(0x39E8);						// Size = 8 ENG3 Recip. Oil leak
		private Offset<double> Offset39F0 = new Offset<double>(0x39F0);						// Size = 8 ENG3 (Recip./General) EGT
		private Offset<uint> Offset39F8 = new Offset<uint>(0x39F8);						// Size = 4 ENG3 General Generator Switch
		private Offset<uint> Offset39FC = new Offset<uint>(0x39FC);						// Size = 4 ENG3 General Generator Active
		private Offset<double> Offset3A00 = new Offset<double>(0x3A00);						// Size = 8 ENG3 Recip. Damage Pct.
		private Offset<double> Offset3A08 = new Offset<double>(0x3A08);						// Size = 8 ENG3 Recip. Combustion Sound Pct.
		private Offset<uint> Offset3A18 = new Offset<uint>(0x3A18);						// Size = 4 ENG3 Recip. Fuel Pump Switch
		private Offset<uint> Offset3A20 = new Offset<uint>(0x3A20);						// Size = 4 ENG2 General Failure
		private Offset<uint> Offset3A24 = new Offset<uint>(0x3A24);						// Size = 4 ENG2 Recip. Combustion
		private Offset<double> Offset3A28 = new Offset<double>(0x3A28);						// Size = 8 ENG2 (Recip./General) Throttle Lever Pos
		private Offset<double> Offset3A30 = new Offset<double>(0x3A30);						// Size = 8 ENG2 (Recip./General) Mixture Lever Pos
		private Offset<double> Offset3A38 = new Offset<double>(0x3A38);						// Size = 8 ENG2 (Recip./General) Prop. Lever Pos
		private Offset<uint> Offset3A40 = new Offset<uint>(0x3A40);						// Size = 4 ENG2 (Recip./General) Starter
		private Offset<double> Offset3A98 = new Offset<double>(0x3A98);						// Size = 8 ENG2 (Recip./General) Oil Temp
		private Offset<double> Offset3AA0 = new Offset<double>(0x3AA0);						// Size = 8 ENG2 (Recip./General) Oil Press.
		private Offset<double> Offset3AA8 = new Offset<double>(0x3AA8);						// Size = 8 ENG2 Recip. Oil leak
		private Offset<double> Offset3AB0 = new Offset<double>(0x3AB0);						// Size = 8 ENG2 (Recip./General) EGT
		private Offset<uint> Offset3AB8 = new Offset<uint>(0x3AB8);						// Size = 4 ENG2 General Generator Switch
		private Offset<uint> Offset3ABC = new Offset<uint>(0x3ABC);						// Size = 4 ENG2 General Generator Active
		private Offset<double> Offset3AC0 = new Offset<double>(0x3AC0);						// Size = 8 ENG2 Recip. Damage Pct.
		private Offset<double> Offset3AC8 = new Offset<double>(0x3AC8);						// Size = 8 ENG2 Recip. Combustion Sound Pct.
		private Offset<uint> Offset3AD8 = new Offset<uint>(0x3AD8);						// Size = 4 ENG2 Recip. Fuel Pump Switch
		private Offset<uint> Offset3AE0 = new Offset<uint>(0x3AE0);						// Size = 4 ENG1 General Failure
		private Offset<uint> Offset3AE4 = new Offset<uint>(0x3AE4);						// Size = 4 ENG1 Recip. Combustion
		private Offset<double> Offset3AE8 = new Offset<double>(0x3AE8);						// Size = 8 ENG1 (Recip./General) Throttle Lever Pos
		private Offset<double> Offset3AF0 = new Offset<double>(0x3AF0);						// Size = 8 ENG1 (Recip./General) Mixture Lever Pos
		private Offset<double> Offset3AF8 = new Offset<double>(0x3AF8);						// Size = 8 ENG1 (Recip./General) Prop. Lever Pos
		private Offset<uint> Offset3B00 = new Offset<uint>(0x3B00);						// Size = 4 ENG1 (Recip./General) Starter
		private Offset<double> Offset3B58 = new Offset<double>(0x3B58);						// Size = 8 ENG1 (Recip./General) Oil Temp
		private Offset<double> Offset3B60 = new Offset<double>(0x3B60);						// Size = 8 ENG1 (Recip./General) Oil Press.
		private Offset<double> Offset3B68 = new Offset<double>(0x3B68);						// Size = 8 ENG1 Recip. Oil leak
		private Offset<double> Offset3B70 = new Offset<double>(0x3B70);						// Size = 8 ENG1 (Recip./General) EGT
		private Offset<uint> Offset3B78 = new Offset<uint>(0x3B78);						// Size = 4 ENG1 General Generator Switch
		private Offset<uint> Offset3B7C = new Offset<uint>(0x3B7C);						// Size = 4 ENG1 General Generator Active
		private Offset<double> Offset3B80 = new Offset<double>(0x3B80);						// Size = 8 ENG1 Recip. Damage Pct.
		private Offset<double> Offset3B88 = new Offset<double>(0x3B88);						// Size = 8 ENG1 Recip. Combustion Sound Pct.
		private Offset<uint> Offset3B98 = new Offset<uint>(0x3B98);						// Size = 4 ENG1 Recip. Fuel Pump Switch
		private Offset<double> Offset3BA0 = new Offset<double>(0x3BA0);						// Size = 8 Tailhook position
		private Offset<ushort> Offset3BA8 = new Offset<ushort>(0x3BA8);						// Size = 2 PFC raw axis 0 (aileron)
		private Offset<ushort> Offset3BAA = new Offset<ushort>(0x3BAA);						// Size = 2 PFC raw axis 1 (elevator)
		private Offset<ushort> Offset3BAC = new Offset<ushort>(0x3BAC);						// Size = 2 PFC raw axis 2 (rudder)
		private Offset<ushort> Offset3BB0 = new Offset<ushort>(0x3BB0);						// Size = 2 PFC raw axis 4 (quad #3)
		private Offset<ushort> Offset3BB2 = new Offset<ushort>(0x3BB2);						// Size = 2 PFC raw axis 5 (quad #1)
		private Offset<ushort> Offset3BB4 = new Offset<ushort>(0x3BB4);						// Size = 2 PFC raw axis 6 (left brakes)
		private Offset<ushort> Offset3BB6 = new Offset<ushort>(0x3BB6);						// Size = 2 PFC raw axis 7 (quad #6)
		private Offset<ushort> Offset3BB8 = new Offset<ushort>(0x3BB8);						// Size = 2 PFC raw axis 8 (quad #4)
		private Offset<ushort> Offset3BBA = new Offset<ushort>(0x3BBA);						// Size = 2 PFC raw axis 9 (quad #2)
		private Offset<ushort> Offset3BBC = new Offset<ushort>(0x3BBC);						// Size = 2 PFC raw axis 10 (right brakes)
		private Offset<ushort> Offset3BBE = new Offset<ushort>(0x3BBE);						// Size = 2 PFC raw axis 11 (elev trim)
		private Offset<ushort> Offset3BC0 = new Offset<ushort>(0x3BC0);						// Size = 2 PFC raw axis 12 (ail trim)
		private Offset<ushort> Offset3BC2 = new Offset<ushort>(0x3BC2);						// Size = 2 PFC raw axis 13 (rud trim)
		private Offset<ushort> Offset3BC4 = new Offset<ushort>(0x3BC4);						// Size = 2 PFC raw axis 14 (tiller)
		private Offset<ushort> Offset3BC6 = new Offset<ushort>(0x3BC6);						// Size = 2 PFC raw axis 15 (unassigned))
		private Offset<ushort> Offset3BC8 = new Offset<ushort>(0x3BC8);						// Size = 2 PFC axis disconnect control
		private Offset<ushort> Offset3BD2 = new Offset<ushort>(0x3BD2);						// Size = 2 Count of FLT files saved
		private Offset<byte> Offset3BD6 = new Offset<byte>(0x3BD6);						// Size = 2 Panel failure ADF (FS2002+) Both on FS2004
		private Offset<byte> Offset3BD7 = new Offset<byte>(0x3BD7);						// Size = 2 Panel failure ASI (FS2002+)
		private Offset<byte> Offset3BD8 = new Offset<byte>(0x3BD8);						// Size = 2 Panel failure Altimeter (FS2002+)
		private Offset<byte> Offset3BD9 = new Offset<byte>(0x3BD9);						// Size = 2 Panel failure AI (FS2002+)
		private Offset<byte> Offset3BDA = new Offset<byte>(0x3BDA);						// Size = 2 Panel failure COM1 (FS2002+)
		private Offset<byte> Offset3BDB = new Offset<byte>(0x3BDB);						// Size = 2 Panel failure COM2 (FS2002+)
		private Offset<byte> Offset3BDC = new Offset<byte>(0x3BDC);						// Size = 2 Panel failure Compass (FS2002+)
		private Offset<byte> Offset3BDD = new Offset<byte>(0x3BDD);						// Size = 2 Panel failure ? unknown (FS2002+)
		private Offset<byte> Offset3BDE = new Offset<byte>(0x3BDE);						// Size = 2 Panel failure Engine (FS2002+)
		private Offset<byte> Offset3BDF = new Offset<byte>(0x3BDF);						// Size = 2 Panel failure Fuel ind (FS2002+)
		private Offset<byte> Offset3BE0 = new Offset<byte>(0x3BE0);						// Size = 2 Panel failure Heading ind (FS2002+)
		private Offset<byte> Offset3BE1 = new Offset<byte>(0x3BE1);						// Size = 2 Panel failure NAV1 (FS2002+)
		private Offset<byte> Offset3BE2 = new Offset<byte>(0x3BE2);						// Size = 2 Panel failure NAV2 (FS2002+)
		private Offset<byte> Offset3BE3 = new Offset<byte>(0x3BE3);						// Size = 2 Panel failure pitot heat (FS2002+)
		private Offset<byte> Offset3BE4 = new Offset<byte>(0x3BE4);						// Size = 2 Panel failure transponder (FS2002+)
		private Offset<byte> Offset3BE5 = new Offset<byte>(0x3BE5);						// Size = 2 Panel failure turn coord (FS2002+)
		private Offset<byte> Offset3BE6 = new Offset<byte>(0x3BE6);						// Size = 2 Panel failure vacuum (FS2002+)
		private Offset<byte> Offset3BE7 = new Offset<byte>(0x3BE7);						// Size = 2 Panel failure VSI (FS2002+)
		private Offset<ushort> Offset3BFA = new Offset<ushort>(0x3BFA);						// Size = 2 Flap detent increment [FS2000+]
		private Offset<uint> Offset3BFC = new Offset<uint>(0x3BFC);						// Size = 4 Zero Fuel Weight
		private Offset<string> Offset3C00 = new Offset<string>(0x3C00, 256, true);						// Size = 256 Current AIR file
		private Offset<string> Offset3D00 = new Offset<string>(0x3D00, 256, true);						// Size = 256 Aircraft name string
		private Offset<string> Offset3E00 = new Offset<string>(0x3E00, 256, true);						// Size = 256 Folder path to Flight Sim
		private Offset<ushort> Offset3F00 = new Offset<ushort>(0x3F00);						// Size = 2 Load/Save Flight Control
		private Offset<ushort> Offset3F02 = new Offset<ushort>(0x3F02);						// Size = 2 Flight load count [FS2k]
		private Offset<string> Offset3F04 = new Offset<string>(0x3F04, 252, true);						// Size = 252 Flight/situation name
		private Offset<byte> Offset5280 = new Offset<byte>(0x5280);						// Size = 2 Aerosoft EICAS/EFIS switch command
		private Offset<byte> Offset5281 = new Offset<byte>(0x5281);						// Size = 2 Aerosoft EICAS/EFIS switch data
		private Offset<ushort> Offset5530 = new Offset<ushort>(0x5530);						// Size = 2 PM / PFC cautions and warnings
		private Offset<ushort> Offset57FC = new Offset<ushort>(0x57FC);						// Size = 2 PMsystems Options Included
		private Offset<ushort> Offset57FE = new Offset<ushort>(0x57FE);						// Size = 2 PMsystems Options Selected
		private Offset<byte> Offset6000 = new Offset<byte>(0x6000);						// Size = 2 FS2004 GPS data area -- see SDK
		private Offset<uint> Offset6004 = new Offset<uint>(0x6004);						// Size = 4 FS2004 GPS flags
		private Offset<uint> Offset6008 = new Offset<uint>(0x6008);						// Size = 4 FS2004 GPS unknown progress flags?
		private Offset<uint> Offset600C = new Offset<uint>(0x600C);						// Size = 4 FS2004 GPS Zulu time in secs since midnight
		private Offset<double> Offset6010 = new Offset<double>(0x6010);						// Size = 8 FS2004 GPS Latitude in degrees
		private Offset<double> Offset6018 = new Offset<double>(0x6018);						// Size = 8 FS2004 GPS Longitude in degrees
		private Offset<double> Offset6020 = new Offset<double>(0x6020);						// Size = 8 FS2004 GPS Altitude
		private Offset<double> Offset6028 = new Offset<double>(0x6028);						// Size = 8 FS2004 GPS Mag Var
		private Offset<double> Offset6030 = new Offset<double>(0x6030);						// Size = 8 FS2004 GPS Ground Speed
		private Offset<double> Offset6038 = new Offset<double>(0x6038);						// Size = 8 FS2004 GPS True Heading
		private Offset<double> Offset6040 = new Offset<double>(0x6040);						// Size = 8 FS2004 GPS Mag Track
		private Offset<double> Offset6048 = new Offset<double>(0x6048);						// Size = 8 FS2004 GPS Distance to next WP
		private Offset<double> Offset6050 = new Offset<double>(0x6050);						// Size = 8 FS2004 GPS Mag bearing to next WP
		private Offset<double> Offset6058 = new Offset<double>(0x6058);						// Size = 8 FS2004 GPS Cross track error
		private Offset<double> Offset6060 = new Offset<double>(0x6060);						// Size = 8 FS2004 GPS Required true heading
		private Offset<double> Offset6068 = new Offset<double>(0x6068);						// Size = 8 FS2004 GPS Track error
		private Offset<double> Offset6078 = new Offset<double>(0x6078);						// Size = 8 FS2004 GPS Vertical speed
		private Offset<byte> Offset6080 = new Offset<byte>(0x6080);						// Size = 2 FS2004 GPS Prev WP valid flag
		private Offset<string> Offset6081 = new Offset<string>(0x6081, 6, true);						// Size = 6 FS2004 GPS Prev WP ID string
		private Offset<double> Offset608C = new Offset<double>(0x608C);						// Size = 8 FS2004 GPS Prev WP latitude
		private Offset<double> Offset6094 = new Offset<double>(0x6094);						// Size = 8 FS2004 GPS Prev WP longitude
		private Offset<double> Offset609C = new Offset<double>(0x609C);						// Size = 8 FS2004 GPS Prev WP aircraft altitude
		private Offset<string> Offset60A4 = new Offset<string>(0x60A4, 6, true);						// Size = 6 FS2004 GPS Next WP ID string
		private Offset<double> Offset60AC = new Offset<double>(0x60AC);						// Size = 8 FS2004 GPS Next WP latitude
		private Offset<double> Offset60B4 = new Offset<double>(0x60B4);						// Size = 8 FS2004 GPS Next WP longitude
		private Offset<double> Offset60BC = new Offset<double>(0x60BC);						// Size = 8 FS2004 GPS Next WP aircraft altitude
		private Offset<uint> Offset60E4 = new Offset<uint>(0x60E4);						// Size = 4 FS2004 GPS Next WP ETE in secs
		private Offset<uint> Offset60E8 = new Offset<uint>(0x60E8);						// Size = 4 FS2004 GPS Next WP ETA in secs
		private Offset<double> Offset60EC = new Offset<double>(0x60EC);						// Size = 8 FS2004 GPS Next WP distance
		private Offset<double> Offset60F4 = new Offset<double>(0x60F4);						// Size = 8 FS2004 GPS Distance prev to next WP
		private Offset<uint> Offset60FC = new Offset<uint>(0x60FC);						// Size = 4 FS2004 GPS Approach mode no. (?)
		private Offset<uint> Offset6100 = new Offset<uint>(0x6100);						// Size = 4 FS2004 GPS Approach WP type (?)
		private Offset<uint> Offset6104 = new Offset<uint>(0x6104);						// Size = 4 FS2004 GPS Approach Segment type (?)
		private Offset<byte> Offset6108 = new Offset<byte>(0x6108);						// Size = 2 FS2004 GPS Approach mode flag
		private Offset<double> Offset610C = new Offset<double>(0x610C);						// Size = 8 FS2004 GPS Course to set (CTS)
		private Offset<uint> Offset6120 = new Offset<uint>(0x6120);						// Size = 4 FS2004 GPS Total no. of WPs in plan
		private Offset<uint> Offset6128 = new Offset<uint>(0x6128);						// Size = 4 FS2004 GPS Approach WP count (?)
		private Offset<byte> Offset6137 = new Offset<byte>(0x6137);						// Size = 2 FS2004 GPS Destination airport ID
		private Offset<byte> Offset6140 = new Offset<byte>(0x6140);						// Size = 2 FS2004 GPS Approach name string
		private Offset<int> Offset6150 = new Offset<int>(0x6150);						// Size = 4 FS2004 GPS Approach transition index (?)
		private Offset<byte> Offset6154 = new Offset<byte>(0x6154);						// Size = 2 FS2004 GPS Approach transition name
		private Offset<uint> Offset6160 = new Offset<uint>(0x6160);						// Size = 4 FS2004 GPS Approach type (?)
		private Offset<int> Offset6168 = new Offset<int>(0x6168);						// Size = 4 FS2004 GPS Approach time zone deviation (?)
		private Offset<uint> Offset616C = new Offset<uint>(0x616C);						// Size = 4 FS2004 GPS Current WP index
		private Offset<uint> Offset6170 = new Offset<uint>(0x6170);						// Size = 4 FS2004 GPS Approach current WP index (?)
		private Offset<double> Offset6178 = new Offset<double>(0x6178);						// Size = 8 FS2004 GPS unknown
		private Offset<double> Offset6180 = new Offset<double>(0x6180);						// Size = 8 FS2004 GPS unknown
		private Offset<double> Offset6188 = new Offset<double>(0x6188);						// Size = 8 FS2004 GPS unknown
		private Offset<uint> Offset6190 = new Offset<uint>(0x6190);						// Size = 4 FS2004 GPS Time last WP crossed
		private Offset<uint> Offset6198 = new Offset<uint>(0x6198);						// Size = 4 FS2004 GPS Dest ETE in secs
		private Offset<uint> Offset619C = new Offset<uint>(0x619C);						// Size = 4 FS2004 GPS Dest ETA in secs
		private Offset<double> Offset61A0 = new Offset<double>(0x61A0);						// Size = 8 FS2004 GPS Route total distance
		private Offset<double> Offset61A8 = new Offset<double>(0x61A8);						// Size = 8 FS2004 GPS Est fuel burn
		private Offset<uint> Offset61B0 = new Offset<uint>(0x61B0);						// Size = 4 FS2004 GPS Time of last upd to 61B8
		private Offset<uint> Offset61B8 = new Offset<uint>(0x61B8);						// Size = 4 FS2004 GPS Count updated every 5 secs
		private Offset<string> Offset6D60 = new Offset<string>(0x6D60, 32, true);						// Size = 32 FSUIPC message window title
		private Offset<byte> Offset8320 = new Offset<byte>(0x8320);						// Size = 2 View: current view type
		private Offset<ushort> Offset832C = new Offset<ushort>(0x832C);						// Size = 2 View: Zoom settings
		private Offset<ushort> Offset833C = new Offset<ushort>(0x833C);						// Size = 2 Spot view direction from user plane
		private Offset<uint> Offset8340 = new Offset<uint>(0x8340);						// Size = 4 Spot plane distance
		private Offset<byte> Offset8345 = new Offset<byte>(0x8345);						// Size = 2 Spot plane transition
		private Offset<uint> Offset8348 = new Offset<uint>(0x8348);						// Size = 4 Spot plane altitude diff
		private Offset<long> Offset83BC = new Offset<long>(0x83BC);						// Size = 8 Viewpoint Latitude
		private Offset<long> Offset83C4 = new Offset<long>(0x83C4);						// Size = 8 Viewpoint Longitude
		private Offset<long> Offset83CC = new Offset<long>(0x83CC);						// Size = 8 Viewpoint Altitude
		private Offset<int> Offset83D4 = new Offset<int>(0x83D4);						// Size = 4 Viewpoint Pitch
		private Offset<int> Offset83D8 = new Offset<int>(0x83D8);						// Size = 4 Viewpoint Bank
		private Offset<uint> Offset83DC = new Offset<uint>(0x83DC);						// Size = 4 Viewpoint Heading
		private Offset<ushort> OffsetC00C = new Offset<ushort>(0xC00C);						// Size = 2 Current weather dynamics (FS2004)
		private Offset<uint> OffsetC024 = new Offset<uint>(0xC024);						// Size = 4 Current weather timestamp (FS2004)
		private Offset<ushort> OffsetC028 = new Offset<ushort>(0xC028);						// Size = 2 Current pressure QNH (FS2004)
		private Offset<ushort> OffsetC02A = new Offset<ushort>(0xC02A);						// Size = 2 Current pressure drift? (FS2004)
		private Offset<ushort> OffsetC02C = new Offset<ushort>(0xC02C);						// Size = 2 Current vis upper alt (FS2004)
		private Offset<sbyte> OffsetC02E = new Offset<sbyte>(0xC02E);						// Size = 2 Current vis lower alt (FS2004)
		private Offset<ushort> OffsetC030 = new Offset<ushort>(0xC030);						// Size = 2 Current vis range sm (FS2004)
		private Offset<int> OffsetC034 = new Offset<int>(0xC034);						// Size = 4 Current no. of temp layers (FS2004)
		private Offset<ushort> OffsetC038 = new Offset<ushort>(0xC038);						// Size = 2 Current Temp Altitude (m)
		private Offset<short> OffsetC03A = new Offset<short>(0xC03A);						// Size = 2 Current Temp daytime (C)
		private Offset<ushort> OffsetC03C = new Offset<ushort>(0xC03C);						// Size = 2 Current Temp day/night var (C)
		private Offset<short> OffsetC03E = new Offset<short>(0xC03E);						// Size = 2 Current Temp dewpoint (C)
		private Offset<int> OffsetC0F8 = new Offset<int>(0xC0F8);						// Size = 4 Current no. of wind layers
		private Offset<ushort> OffsetC0FC = new Offset<ushort>(0xC0FC);						// Size = 2 Current Wind upper Alt (m)
		private Offset<ushort> OffsetC0FE = new Offset<ushort>(0xC0FE);						// Size = 2 Current Wind speed (k)
		private Offset<ushort> OffsetC100 = new Offset<ushort>(0xC100);						// Size = 2 Current Wind Gust diff (k)
		private Offset<ushort> OffsetC102 = new Offset<ushort>(0xC102);						// Size = 2 Current Wind direction (True)
		private Offset<byte> OffsetC104 = new Offset<byte>(0xC104);						// Size = 2 Current Wind turbulence
		private Offset<byte> OffsetC105 = new Offset<byte>(0xC105);						// Size = 2 Current Wind Shear
		private Offset<ushort> OffsetC106 = new Offset<ushort>(0xC106);						// Size = 2 Current Wind variance in direction
		private Offset<ushort> OffsetC108 = new Offset<ushort>(0xC108);						// Size = 2 Current Wind fractional speed
		private Offset<int> OffsetC27C = new Offset<int>(0xC27C);						// Size = 4 Current no. of cloud layers
		private Offset<ushort> OffsetC280 = new Offset<ushort>(0xC280);						// Size = 2 Current Cloud upper alt (m)
		private Offset<ushort> OffsetC282 = new Offset<ushort>(0xC282);						// Size = 2 Current Cloud lower alt (m)
		private Offset<ushort> OffsetC284 = new Offset<ushort>(0xC284);						// Size = 2 Current Cloud alt deviation (m)
		private Offset<byte> OffsetC286 = new Offset<byte>(0xC286);						// Size = 2 Current Cloud coverage
		private Offset<byte> OffsetC287 = new Offset<byte>(0xC287);						// Size = 2 Current Cloud type
		private Offset<byte> OffsetC288 = new Offset<byte>(0xC288);						// Size = 2 Current Cloud turbulence
		private Offset<byte> OffsetC289 = new Offset<byte>(0xC289);						// Size = 2 Current Cloud icing
		private Offset<short> OffsetC28A = new Offset<short>(0xC28A);						// Size = 2 Current Cloud precipitation base (m)
		private Offset<byte> OffsetC28C = new Offset<byte>(0xC28C);						// Size = 2 Current Cloud precipitation type
		private Offset<byte> OffsetC28D = new Offset<byte>(0xC28D);						// Size = 2 Current Cloud precipitation rate
		private Offset<byte> OffsetC28E = new Offset<byte>(0xC28E);						// Size = 2 Current Cloud top shape
		private Offset<ushort> OffsetC428 = new Offset<ushort>(0xC428);						// Size = 2 Last Set Global pressure QNH (FS2004)
		private Offset<ushort> OffsetC42A = new Offset<ushort>(0xC42A);						// Size = 2 Last Set Global pressure drift? (FS2004)
		private Offset<ushort> OffsetC42C = new Offset<ushort>(0xC42C);						// Size = 2 Last Set Global vis upper alt (FS2004)
		private Offset<sbyte> OffsetC42E = new Offset<sbyte>(0xC42E);						// Size = 2 Last Set Global vis lower alt (FS2004)
		private Offset<ushort> OffsetC430 = new Offset<ushort>(0xC430);						// Size = 2 Last Set Global vis range sm (FS2004)
		private Offset<int> OffsetC434 = new Offset<int>(0xC434);						// Size = 4 Last Set Global no. of temp layers
		private Offset<ushort> OffsetC438 = new Offset<ushort>(0xC438);						// Size = 2 Last Set Global Temp Altitude (m)
		private Offset<short> OffsetC43A = new Offset<short>(0xC43A);						// Size = 2 Last Set Global Temp daytime (C)
		private Offset<ushort> OffsetC43C = new Offset<ushort>(0xC43C);						// Size = 2 Last Set Global Temp day/night var (C)
		private Offset<short> OffsetC43E = new Offset<short>(0xC43E);						// Size = 2 Last Set Global Temp dewpoint (C)
		private Offset<int> OffsetC4F8 = new Offset<int>(0xC4F8);						// Size = 4 Last Set Global no. of wind layers
		private Offset<ushort> OffsetC4FC = new Offset<ushort>(0xC4FC);						// Size = 2 Last Set Global Wind upper Alt (m)
		private Offset<ushort> OffsetC4FE = new Offset<ushort>(0xC4FE);						// Size = 2 Last Set Global Wind speed (k)
		private Offset<ushort> OffsetC500 = new Offset<ushort>(0xC500);						// Size = 2 Last Set Global Wind Gust diff (k)
		private Offset<ushort> OffsetC502 = new Offset<ushort>(0xC502);						// Size = 2 Last Set Global Wind direction (True)
		private Offset<byte> OffsetC504 = new Offset<byte>(0xC504);						// Size = 2 Last Set Global Wind turbulence
		private Offset<byte> OffsetC505 = new Offset<byte>(0xC505);						// Size = 2 Last Set Global Wind Shear
		private Offset<ushort> OffsetC506 = new Offset<ushort>(0xC506);						// Size = 2 Last Set Global Wind variance in dir
		private Offset<ushort> OffsetC508 = new Offset<ushort>(0xC508);						// Size = 2 Last Set Global Wind fractional speed
		private Offset<int> OffsetC67C = new Offset<int>(0xC67C);						// Size = 4 Last Set Global no. of cloud layers
		private Offset<ushort> OffsetC680 = new Offset<ushort>(0xC680);						// Size = 2 Last Set Global Cloud upper alt (m)
		private Offset<ushort> OffsetC682 = new Offset<ushort>(0xC682);						// Size = 2 Last Set Global Cloud lower alt (m)
		private Offset<ushort> OffsetC684 = new Offset<ushort>(0xC684);						// Size = 2 Last Set Global Cloud alt deviation (m)
		private Offset<byte> OffsetC686 = new Offset<byte>(0xC686);						// Size = 2 Last Set Global Cloud coverage
		private Offset<byte> OffsetC687 = new Offset<byte>(0xC687);						// Size = 2 Last Set Global Cloud type
		private Offset<byte> OffsetC688 = new Offset<byte>(0xC688);						// Size = 2 Last Set Global Cloud turbulence
		private Offset<byte> OffsetC689 = new Offset<byte>(0xC689);						// Size = 2 Last Set Global Cloud icing
		private Offset<short> OffsetC68A = new Offset<short>(0xC68A);						// Size = 2 Last Set Global Cloud precip base (m)
		private Offset<byte> OffsetC68C = new Offset<byte>(0xC68C);						// Size = 2 Last Set Global Cloud precipitation type
		private Offset<byte> OffsetC68D = new Offset<byte>(0xC68D);						// Size = 2 Last Set Global Cloud precipitation rate
		private Offset<byte> OffsetC68E = new Offset<byte>(0xC68E);						// Size = 2 Last Set Global Cloud top shape
		private Offset<ushort> OffsetC800 = new Offset<ushort>(0xC800);						// Size = 2 NW_ command to write weather
		private Offset<string> OffsetC808 = new Offset<string>(0xC808, 4, true);						// Size = 4 ICAO of station written (FS2004)
		private Offset<ushort> OffsetC80C = new Offset<ushort>(0xC80C);						// Size = 2 Weather dynamics being set (FS2004)
		private Offset<uint> OffsetC824 = new Offset<uint>(0xC824);						// Size = 4 Timestamp of write done (FS2004)
		private Offset<ushort> OffsetC828 = new Offset<ushort>(0xC828);						// Size = 2 Written pressure QNH (FS2004)
		private Offset<ushort> OffsetC82A = new Offset<ushort>(0xC82A);						// Size = 2 Written pressure drift? (FS2004)
		private Offset<ushort> OffsetC82C = new Offset<ushort>(0xC82C);						// Size = 2 Written vis upper alt (FS2004)
		private Offset<sbyte> OffsetC82E = new Offset<sbyte>(0xC82E);						// Size = 2 Written vis lower alt (FS2004)
		private Offset<ushort> OffsetC830 = new Offset<ushort>(0xC830);						// Size = 2 Written vis range sm (FS2004)
		private Offset<int> OffsetC834 = new Offset<int>(0xC834);						// Size = 4 Written no. of temp layers (FS2004)
		private Offset<ushort> OffsetC838 = new Offset<ushort>(0xC838);						// Size = 2 Written Temp Altitude (m)
		private Offset<short> OffsetC83A = new Offset<short>(0xC83A);						// Size = 2 Written Temp daytime (C)
		private Offset<ushort> OffsetC83C = new Offset<ushort>(0xC83C);						// Size = 2 Written Temp day/night var (C)
		private Offset<short> OffsetC83E = new Offset<short>(0xC83E);						// Size = 2 Written Temp dewpoint (C)
		private Offset<int> OffsetC8F8 = new Offset<int>(0xC8F8);						// Size = 4 Written no. of wind layers
		private Offset<ushort> OffsetC8FC = new Offset<ushort>(0xC8FC);						// Size = 2 Written Wind upper Alt (m)
		private Offset<ushort> OffsetC8FE = new Offset<ushort>(0xC8FE);						// Size = 2 Written Wind speed (k)
		private Offset<ushort> OffsetC900 = new Offset<ushort>(0xC900);						// Size = 2 Written Wind Gust diff (k)
		private Offset<ushort> OffsetC902 = new Offset<ushort>(0xC902);						// Size = 2 Written Wind direction (True)
		private Offset<byte> OffsetC904 = new Offset<byte>(0xC904);						// Size = 2 Written Wind turbulence
		private Offset<byte> OffsetC905 = new Offset<byte>(0xC905);						// Size = 2 Written Wind Shear
		private Offset<ushort> OffsetC906 = new Offset<ushort>(0xC906);						// Size = 2 Written Wind variance in direction
		private Offset<ushort> OffsetC908 = new Offset<ushort>(0xC908);						// Size = 2 Written Wind fractional speed
		private Offset<int> OffsetCA7C = new Offset<int>(0xCA7C);						// Size = 4 Written no. of cloud layers
		private Offset<ushort> OffsetCA80 = new Offset<ushort>(0xCA80);						// Size = 2 Written Cloud upper alt (m)
		private Offset<ushort> OffsetCA82 = new Offset<ushort>(0xCA82);						// Size = 2 Written Cloud lower alt (m)
		private Offset<ushort> OffsetCA84 = new Offset<ushort>(0xCA84);						// Size = 2 Written Cloud alt deviation (m)
		private Offset<byte> OffsetCA86 = new Offset<byte>(0xCA86);						// Size = 2 Written Cloud coverage
		private Offset<byte> OffsetCA87 = new Offset<byte>(0xCA87);						// Size = 2 Written Cloud type
		private Offset<byte> OffsetCA88 = new Offset<byte>(0xCA88);						// Size = 2 Written Cloud turbulence
		private Offset<byte> OffsetCA89 = new Offset<byte>(0xCA89);						// Size = 2 Written Cloud icing
		private Offset<short> OffsetCA8A = new Offset<short>(0xCA8A);						// Size = 2 Written Cloud precipitation base (m)
		private Offset<byte> OffsetCA8C = new Offset<byte>(0xCA8C);						// Size = 2 Written Cloud precipitation type
		private Offset<byte> OffsetCA8D = new Offset<byte>(0xCA8D);						// Size = 2 Written Cloud precipitation rate
		private Offset<byte> OffsetCA8E = new Offset<byte>(0xCA8E);						// Size = 2 Written Cloud top shape
		private Offset<uint> OffsetCC04 = new Offset<uint>(0xCC04);						// Size = 4 Signature for weather reading (FS2004)
		private Offset<uint> OffsetCC08 = new Offset<uint>(0xCC08);						// Size = 4 ICAO for weather reading (FS2004)
		private Offset<ushort> OffsetCC0C = new Offset<ushort>(0xCC0C);						// Size = 2 Weather dynamics
		private Offset<double> OffsetCC10 = new Offset<double>(0xCC10);						// Size = 8 Weather read Latitude
		private Offset<double> OffsetCC18 = new Offset<double>(0xCC18);						// Size = 8 Weather read Longitude
		private Offset<uint> OffsetCC24 = new Offset<uint>(0xCC24);						// Size = 4 Weather read timestamp
		private Offset<ushort> OffsetCC28 = new Offset<ushort>(0xCC28);						// Size = 2 Read pressure QNH (FS2004)
		private Offset<ushort> OffsetCC2A = new Offset<ushort>(0xCC2A);						// Size = 2 Read pressure drift? (FS2004)
		private Offset<ushort> OffsetCC2C = new Offset<ushort>(0xCC2C);						// Size = 2 Read vis upper alt (FS2004)
		private Offset<sbyte> OffsetCC2E = new Offset<sbyte>(0xCC2E);						// Size = 2 Read vis lower alt (FS2004)
		private Offset<ushort> OffsetCC30 = new Offset<ushort>(0xCC30);						// Size = 2 Read vis range sm (FS2004)
		private Offset<int> OffsetCC34 = new Offset<int>(0xCC34);						// Size = 4 Read no. of temp layers (FS2004)
		private Offset<ushort> OffsetCC38 = new Offset<ushort>(0xCC38);						// Size = 2 Read Temp Altitude (m)
		private Offset<short> OffsetCC3A = new Offset<short>(0xCC3A);						// Size = 2 Read Temp daytime (C)
		private Offset<ushort> OffsetCC3C = new Offset<ushort>(0xCC3C);						// Size = 2 Read Temp day/night var (C)
		private Offset<short> OffsetCC3E = new Offset<short>(0xCC3E);						// Size = 2 Read Temp dewpoint (C)
		private Offset<int> OffsetCCF8 = new Offset<int>(0xCCF8);						// Size = 4 Read no. of wind layers
		private Offset<ushort> OffsetCCFC = new Offset<ushort>(0xCCFC);						// Size = 2 Read Wind upper Alt (m)
		private Offset<ushort> OffsetCCFE = new Offset<ushort>(0xCCFE);						// Size = 2 Read Wind speed (k)
		private Offset<ushort> OffsetCD00 = new Offset<ushort>(0xCD00);						// Size = 2 Read Wind Gust diff (k)
		private Offset<ushort> OffsetCD02 = new Offset<ushort>(0xCD02);						// Size = 2 Read Wind direction (True)
		private Offset<byte> OffsetCD04 = new Offset<byte>(0xCD04);						// Size = 2 Read Wind turbulence
		private Offset<byte> OffsetCD05 = new Offset<byte>(0xCD05);						// Size = 2 Read Wind Shear
		private Offset<ushort> OffsetCD06 = new Offset<ushort>(0xCD06);						// Size = 2 Read Wind variance in direction
		private Offset<ushort> OffsetCD08 = new Offset<ushort>(0xCD08);						// Size = 2 Read Wind fractional speed
		private Offset<int> OffsetCE7C = new Offset<int>(0xCE7C);						// Size = 4 Read no. of cloud layers
		private Offset<ushort> OffsetCE80 = new Offset<ushort>(0xCE80);						// Size = 2 Read Cloud upper alt (m)
		private Offset<ushort> OffsetCE82 = new Offset<ushort>(0xCE82);						// Size = 2 Read Cloud lower alt (m)
		private Offset<ushort> OffsetCE84 = new Offset<ushort>(0xCE84);						// Size = 2 Read Cloud alt deviation (m)
		private Offset<byte> OffsetCE86 = new Offset<byte>(0xCE86);						// Size = 2 Read Cloud coverage
		private Offset<byte> OffsetCE87 = new Offset<byte>(0xCE87);						// Size = 2 Read Cloud type
		private Offset<byte> OffsetCE88 = new Offset<byte>(0xCE88);						// Size = 2 Read Cloud turbulence
		private Offset<byte> OffsetCE89 = new Offset<byte>(0xCE89);						// Size = 2 Read Cloud icing
		private Offset<short> OffsetCE8A = new Offset<short>(0xCE8A);						// Size = 2 Read Cloud precipitation base (m)
		private Offset<byte> OffsetCE8C = new Offset<byte>(0xCE8C);						// Size = 2 Read Cloud precipitation type
		private Offset<byte> OffsetCE8D = new Offset<byte>(0xCE8D);						// Size = 2 Read Cloud precipitation rate
		private Offset<byte> OffsetCE8E = new Offset<byte>(0xCE8E);						// Size = 2 Read Cloud top shape
		private Offset<uint> OffsetD000 = new Offset<uint>(0xD000);						// Size = 4 AI runways or string data request signature
		private Offset<uint> OffsetD004 = new Offset<uint>(0xD004);						// Size = 4 AI runways request ICAO or string data command
		private Offset<uint> OffsetD008 = new Offset<uint>(0xD008);						// Size = 4 AI runways request timestamp
		private Offset<byte> OffsetD00C = new Offset<byte>(0xD00C);						// Size = 2 AI runways request -- 1st Rwy Num
		private Offset<byte> OffsetD00D = new Offset<byte>(0xD00D);						// Size = 2 AI runways request -- 1st Rwy Desig
		private Offset<byte> OffsetD00E = new Offset<byte>(0xD00E);						// Size = 2 AI runways request -- 2nd Rwy Num
		private Offset<byte> OffsetD00F = new Offset<byte>(0xD00F);						// Size = 2 AI runways request -- 2nd Rwy Desig
		private Offset<string> OffsetD010 = new Offset<string>(0xD010, 48, true);						// Size = 48 AI string data read area
		private Offset<int> OffsetD040 = new Offset<int>(0xD040);						// Size = 4 AI ground traffic flight key (per file)
		private Offset<ushort> OffsetD044 = new Offset<ushort>(0xD044);						// Size = 2 AI ground traffic file ID
		private Offset<short> OffsetD046 = new Offset<short>(0xD046);						// Size = 2 AI ground traffic: aircraft pitch
		private Offset<string> OffsetD048 = new Offset<string>(0xD048, 4, true);						// Size = 4 AI ground traffic Dep ICAO
		private Offset<string> OffsetD04C = new Offset<string>(0xD04C, 4, true);						// Size = 4 AI ground traffic Arr ICAO
		private Offset<byte> OffsetD050 = new Offset<byte>(0xD050);						// Size = 2 AI ground traffic runway num
		private Offset<byte> OffsetD051 = new Offset<byte>(0xD051);						// Size = 2 AI ground traffic runway desig
		private Offset<short> OffsetD052 = new Offset<short>(0xD052);						// Size = 2 AI ground traffic: aircraft bank 
		private Offset<int> OffsetD840 = new Offset<int>(0xD840);						// Size = 4 AI airborne traffic flght key (per file)
		private Offset<ushort> OffsetD844 = new Offset<ushort>(0xD844);						// Size = 2 AI airborne traffic file ID
		private Offset<short> OffsetD846 = new Offset<short>(0xD846);						// Size = 2 AI airborne traffic: aircraft pitch
		private Offset<string> OffsetD848 = new Offset<string>(0xD848, 4, true);						// Size = 4 AI airborne traffic Dep ICAO
		private Offset<string> OffsetD84C = new Offset<string>(0xD84C, 4, true);						// Size = 4 AI airborne traffic Arr ICAO
		private Offset<byte> OffsetD850 = new Offset<byte>(0xD850);						// Size = 2 AI airborne traffic runway num
		private Offset<byte> OffsetD851 = new Offset<byte>(0xD851);						// Size = 2 AI airborne traffic runway desig
		private Offset<short> OffsetD852 = new Offset<short>(0xD852);						// Size = 2 AI airborne traffic: aircraft bank
		private Offset<ushort> OffsetE000 = new Offset<ushort>(0xE000);						// Size = 2 AI ground traffic slot size
		private Offset<ushort> OffsetE002 = new Offset<ushort>(0xE002);						// Size = 2 AI ground traffic slot count
		private Offset<ushort> OffsetE004 = new Offset<ushort>(0xE004);						// Size = 2 AI ground traffic slots used so far
		private Offset<ushort> OffsetE006 = new Offset<ushort>(0xE006);						// Size = 2 AI ground traffic changes counter
		private Offset<byte> OffsetE008 = new Offset<byte>(0xE008);						// Size = 2 AI ground traffic slot changed ctr
		private Offset<byte> OffsetE068 = new Offset<byte>(0xE068);						// Size = 2 TCAS ground range user in air
		private Offset<byte> OffsetE069 = new Offset<byte>(0xE069);						// Size = 2 TCAS ground range user on ground
		private Offset<byte> OffsetE06A = new Offset<byte>(0xE06A);						// Size = 2 TCAS ground id option
		private Offset<byte> OffsetE06B = new Offset<byte>(0xE06B);						// Size = 2 TCAS active traffic preference
		private Offset<ushort> OffsetE07E = new Offset<ushort>(0xE07E);						// Size = 2 Slot offset of nearest ground AI traffic
		private Offset<int> OffsetE080 = new Offset<int>(0xE080);						// Size = 4 AI ground traffic id (0=empty slot)
		private Offset<float> OffsetE084 = new Offset<float>(0xE084);						// Size = 4 AI ground traffic Latitude
		private Offset<float> OffsetE088 = new Offset<float>(0xE088);						// Size = 4 AI ground traffic Longitude
		private Offset<float> OffsetE08C = new Offset<float>(0xE08C);						// Size = 4 AI ground traffic Altitude
		private Offset<ushort> OffsetE090 = new Offset<ushort>(0xE090);						// Size = 2 AI ground traffic Heading (True)
		private Offset<ushort> OffsetE092 = new Offset<ushort>(0xE092);						// Size = 2 AI ground traffic GS (k)
		private Offset<short> OffsetE094 = new Offset<short>(0xE094);						// Size = 2 AI ground traffic VS (fpm)
		private Offset<string> OffsetE096 = new Offset<string>(0xE096, 15, true);						// Size = 15 AI ground traffic ATC id
		private Offset<byte> OffsetE0A5 = new Offset<byte>(0xE0A5);						// Size = 2 AI ground traffic state (FS2004)
		private Offset<ushort> OffsetE0A6 = new Offset<ushort>(0xE0A6);						// Size = 2 AI ground traffic COM1 freq
		private Offset<ushort> OffsetF000 = new Offset<ushort>(0xF000);						// Size = 2 TCAS traffic slot size
		private Offset<ushort> OffsetF002 = new Offset<ushort>(0xF002);						// Size = 2 TCAS traffic slot count
		private Offset<ushort> OffsetF004 = new Offset<ushort>(0xF004);						// Size = 2 TCAS traffic slots used so far
		private Offset<ushort> OffsetF006 = new Offset<ushort>(0xF006);						// Size = 2 TCAS traffic changes counter
		private Offset<byte> OffsetF008 = new Offset<byte>(0xF008);						// Size = 2 TCAS traffic slot changed ctr
		private Offset<byte> OffsetF068 = new Offset<byte>(0xF068);						// Size = 2 TCAS air range
		private Offset<byte> OffsetF06A = new Offset<byte>(0xF06A);						// Size = 2 TCAS air id option
		private Offset<ushort> OffsetF07E = new Offset<ushort>(0xF07E);						// Size = 2 Slot offset of nearest airborne AI aricraft
		private Offset<int> OffsetF080 = new Offset<int>(0xF080);						// Size = 4 TCAS traffic id (0=empty slot)
		private Offset<float> OffsetF084 = new Offset<float>(0xF084);						// Size = 4 TCAS traffic Latitude
		private Offset<float> OffsetF088 = new Offset<float>(0xF088);						// Size = 4 TCAS traffic Longitude
		private Offset<float> OffsetF08C = new Offset<float>(0xF08C);						// Size = 4 TCAS traffic Altitude
		private Offset<ushort> OffsetF090 = new Offset<ushort>(0xF090);						// Size = 2 TCAS traffic Heading (True)
		private Offset<ushort> OffsetF092 = new Offset<ushort>(0xF092);						// Size = 2 TCAS traffic GS (k)
		private Offset<short> OffsetF094 = new Offset<short>(0xF094);						// Size = 2 TCAS traffic VS (fpm)
		private Offset<string> OffsetF096 = new Offset<string>(0xF096, 15, true);						// Size = 15 TCAS traffic ATC id
		private Offset<byte> OffsetF0A5 = new Offset<byte>(0xF0A5);						// Size = 2 TCAS traffic state (FS2004)
		private Offset<ushort> OffsetF0A6 = new Offset<ushort>(0xF0A6);						// Size = 2 TCAS traffic COM1 freq

	public string processData(string mode, string offset, string data = "NOK")
	{
	string result = "NOK";
	switch (offset)
	{
			case "0020":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0020.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0020.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0024":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0024.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0024.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "012C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset012C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset012C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0238":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0238.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0238.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0238.Reconnect(true);
					Offset0238.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0239":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0239.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0239.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0239.Reconnect(true);
					Offset0239.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "023A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset023A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset023A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset023A.Reconnect(true);
					Offset023A.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "023B":
		{
			if (mode == "READ")
			{
				try
				{
					Offset023B.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset023B.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset023B.Reconnect(true);
					Offset023B.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "023C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset023C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset023C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset023C.Reconnect(true);
					Offset023C.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "023E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset023E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset023E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset023E.Reconnect(true);
					Offset023E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0240":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0240.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0240.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0240.Reconnect(true);
					Offset0240.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0246":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0246.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0246.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0246.Reconnect(true);
					Offset0246.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0248":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0248.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0248.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0248.Reconnect(true);
					Offset0248.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0262":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0262.Reconnect(true);
					Offset0262.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0264":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0264.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0264.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0274":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0274.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0274.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0278":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0278.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0278.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0278.Reconnect(true);
					Offset0278.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0280":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0280.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0280.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0280.Reconnect(true);
					Offset0280.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0281":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0281.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0281.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0281.Reconnect(true);
					Offset0281.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "028C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset028C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset028C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset028C.Reconnect(true);
					Offset028C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "029C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset029C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset029C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset029C.Reconnect(true);
					Offset029C.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "02A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset02A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02B2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02B2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset02B2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02B4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02B4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset02B4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset02B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset02BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02C4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02C4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset02C4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset02C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02CC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02CC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset02CC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02D4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02D4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset02D4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset02D4.Reconnect(true);
					Offset02D4.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "02D6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02D6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset02D6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset02D6.Reconnect(true);
					Offset02D6.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "02D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset02D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02DC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02DC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset02DC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02E2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02E2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset02E2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "02FB":
		{
			if (mode == "READ")
			{
				try
				{
					Offset02FB.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset02FB.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset02FB.Reconnect(true);
					Offset02FB.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0300":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0300.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0300.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0302":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0302.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0302.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0304":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0304.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0304.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0306":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0306.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0306.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0308":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0308.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0308.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "030A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset030A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset030A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "030C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset030C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset030C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0310":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0310.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0310.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "032C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset032C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset032C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0330":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0330.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0330.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0330.Reconnect(true);
					Offset0330.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "034C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset034C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset034C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset034C.Reconnect(true);
					Offset034C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "034E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset034E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset034E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset034E.Reconnect(true);
					Offset034E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0350":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0350.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0350.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0350.Reconnect(true);
					Offset0350.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0352":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0352.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0352.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0352.Reconnect(true);
					Offset0352.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0354":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0354.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0354.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0354.Reconnect(true);
					Offset0354.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0356":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0356.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0356.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0356.Reconnect(true);
					Offset0356.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0366":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0366.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0366.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0368":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0368.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset0368.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "036C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset036C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset036C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "036D":
		{
			if (mode == "READ")
			{
				try
				{
					Offset036D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset036D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "036E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset036E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset036E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0378":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0378.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0378.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0378.Reconnect(true);
					Offset0378.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "037C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset037C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset037C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0400":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0400.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0400.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0480":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0480.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0480.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0488":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0488.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0488.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0490":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0490.Reconnect(true);
					Offset0490.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0498":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0498.Reconnect(true);
					Offset0498.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "04A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset04A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset04A0.Reconnect(true);
					Offset04A0.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "04A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset04A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04B4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04B4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset04B4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset04BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset04C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04CB":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04CB.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset04CB.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04CC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04CC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset04CC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04D2":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset04D2.Reconnect(true);
					Offset04D2.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "04D4":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset04D4.Reconnect(true);
					Offset04D4.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "04D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset04D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04DA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04DA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset04DA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset04F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "04F4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset04F4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset04F4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset04F4.Reconnect(true);
					Offset04F4.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0538":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0538.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0538.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0540":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0540.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0540.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0548":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0548.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0548.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0550":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0550.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0550.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0560":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0560.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset0560.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0560.Reconnect(true);
					Offset0560.Value = Convert.ToInt64(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0568":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0568.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset0568.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0568.Reconnect(true);
					Offset0568.Value = Convert.ToInt64(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0570":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0570.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset0570.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0570.Reconnect(true);
					Offset0570.Value = Convert.ToInt64(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0578":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0578.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0578.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0578.Reconnect(true);
					Offset0578.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "057C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset057C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset057C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset057C.Reconnect(true);
					Offset057C.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0580":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0580.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0580.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0580.Reconnect(true);
					Offset0580.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset05B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "05B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset05B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "05C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset05C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "05D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset05D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "05D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset05D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05D8.Reconnect(true);
					Offset05D8.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05DC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05DC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset05DC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05DC.Reconnect(true);
					Offset05DC.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05DE":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05DE.Reconnect(true);
					Offset05DE.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05E4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05E4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset05E4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05E4.Reconnect(true);
					Offset05E4.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05E6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05E6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset05E6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05E6.Reconnect(true);
					Offset05E6.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset05E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05E8.Reconnect(true);
					Offset05E8.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05EB":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05EB.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset05EB.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05EB.Reconnect(true);
					Offset05EB.Value = Convert.ToSByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05ED":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05ED.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset05ED.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05ED.Reconnect(true);
					Offset05ED.Value = Convert.ToSByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05EE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05EE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset05EE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05EE.Reconnect(true);
					Offset05EE.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05F4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05F4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset05F4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05F4.Reconnect(true);
					Offset05F4.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "05FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset05FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset05FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset05FC.Reconnect(true);
					Offset05FC.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0609":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0609.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0609.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0628":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0628.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0628.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0628.Reconnect(true);
					Offset0628.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "062C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset062C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset062C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset062C.Reconnect(true);
					Offset062C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0700":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0700.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0700.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0700.Reconnect(true);
					Offset0700.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0708":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0708.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0708.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0708.Reconnect(true);
					Offset0708.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0718":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0718.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0718.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0718.Reconnect(true);
					Offset0718.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0720":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0720.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0720.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0720.Reconnect(true);
					Offset0720.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0730":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0730.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0730.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0730.Reconnect(true);
					Offset0730.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0738":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0738.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0738.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0738.Reconnect(true);
					Offset0738.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0748":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0748.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0748.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0748.Reconnect(true);
					Offset0748.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0750":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0750.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0750.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0750.Reconnect(true);
					Offset0750.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0760":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0760.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0760.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0764":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0764.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0764.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0778":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0778.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0778.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0780":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0780.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0780.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0784":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0784.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0784.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "078C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset078C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset078C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0790":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0790.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0790.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0794":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0794.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0794.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "079C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset079C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset079C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "07A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "07A4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07A4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07A4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "07BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07BC.Reconnect(true);
					Offset07BC.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07C0.Reconnect(true);
					Offset07C0.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07C4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07C4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07C4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07C4.Reconnect(true);
					Offset07C4.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07C8.Reconnect(true);
					Offset07C8.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07CC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07CC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset07CC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07CC.Reconnect(true);
					Offset07CC.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07D0.Reconnect(true);
					Offset07D0.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07D4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07D4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset07D4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07D4.Reconnect(true);
					Offset07D4.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07D8.Reconnect(true);
					Offset07D8.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07DC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07DC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07DC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07DC.Reconnect(true);
					Offset07DC.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07E2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07E2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset07E2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07E2.Reconnect(true);
					Offset07E2.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07E4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07E4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07E4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07E4.Reconnect(true);
					Offset07E4.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07E8.Reconnect(true);
					Offset07E8.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07F2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07F2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset07F2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07F2.Reconnect(true);
					Offset07F2.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "07FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset07FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset07FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset07FC.Reconnect(true);
					Offset07FC.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0800":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0800.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0800.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0800.Reconnect(true);
					Offset0800.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0804":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0804.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0804.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0804.Reconnect(true);
					Offset0804.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0808":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0808.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0808.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0808.Reconnect(true);
					Offset0808.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "080C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset080C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset080C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset080C.Reconnect(true);
					Offset080C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0830":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0830.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0830.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0830.Reconnect(true);
					Offset0830.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0834":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0834.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0834.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0838":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0838.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0838.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "083C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset083C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset083C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0840":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0840.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0840.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0842":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0842.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0842.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0844":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0844.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0844.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0846":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0846.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0846.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "084C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset084C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset084C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0850":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0850.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0850.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0854":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0854.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0854.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0858":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0858.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0858.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "085C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset085C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset085C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0860":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0860.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0860.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0864":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0864.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0864.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0868":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0868.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0868.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "086C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset086C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset086C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0870":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0870.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0870.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0872":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0872.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0872.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0878":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0878.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0878.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "087C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset087C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset087C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0880":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0880.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0880.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0884":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0884.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0884.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0888":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0888.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0888.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0888.Reconnect(true);
					Offset0888.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0889":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0889.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0889.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0889.Reconnect(true);
					Offset0889.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "088A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset088A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset088A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "088C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset088C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset088C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset088C.Reconnect(true);
					Offset088C.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "088E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset088E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset088E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset088E.Reconnect(true);
					Offset088E.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0890":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0890.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0890.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0890.Reconnect(true);
					Offset0890.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0892":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0892.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0892.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0892.Reconnect(true);
					Offset0892.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0894":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0894.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0894.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0896":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0896.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0896.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0898":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0898.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0898.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "089A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset089A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset089A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset089A.Reconnect(true);
					Offset089A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "08A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08B2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08B2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset08B2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset08B2.Reconnect(true);
					Offset08B2.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "08B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset08B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08BA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08BA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset08BA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset08BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08BE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08BE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset08BE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset08C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset08C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08D4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08D4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08D4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08DC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08DC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08DC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset08E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08F4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08F4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08F4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "08FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset08FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset08FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0900":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0900.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0900.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0904":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0904.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0904.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0908":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0908.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0908.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0918":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0918.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0918.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0920":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0920.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset0920.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0924":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0924.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0924.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0924.Reconnect(true);
					Offset0924.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0926":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0926.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0926.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0926.Reconnect(true);
					Offset0926.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0928":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0928.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0928.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0928.Reconnect(true);
					Offset0928.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "092A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset092A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset092A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset092A.Reconnect(true);
					Offset092A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "092C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset092C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset092C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "092E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset092E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset092E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0930":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0930.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0930.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0932":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0932.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0932.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0932.Reconnect(true);
					Offset0932.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0938":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0938.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0938.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "094A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset094A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset094A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset094A.Reconnect(true);
					Offset094A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0950":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0950.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0950.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0952":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0952.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0952.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0954":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0954.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0954.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0956":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0956.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0956.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0958":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0958.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0958.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0960":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0960.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0960.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0968":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0968.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0968.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "096C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset096C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset096C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0970":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0970.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0970.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0974":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0974.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0974.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0980":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0980.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0980.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0988":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0988.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0988.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "098C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset098C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset098C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0990":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0990.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0990.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset09B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset09B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset09BC.Reconnect(true);
					Offset09BC.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "09BE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09BE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09BE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset09BE.Reconnect(true);
					Offset09BE.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "09C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset09C0.Reconnect(true);
					Offset09C0.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "09C2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09C2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset09C2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset09C2.Reconnect(true);
					Offset09C2.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "09C4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09C4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset09C4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09C6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09C6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09C6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09CA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09CA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09CA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset09CA.Reconnect(true);
					Offset09CA.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "09D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset09D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09E2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09E2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09E2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset09E2.Reconnect(true);
					Offset09E2.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "09E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09EA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09EA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset09EA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09EC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09EC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09EC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09EE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09EE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset09EE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset09F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "09F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset09F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset09F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A04":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A04.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A04.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A08":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A08.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A08.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A0C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A0C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A0C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A18":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A18.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0A18.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A20":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A20.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A20.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A24":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A24.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A24.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A28":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A28.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A28.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A48":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A48.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0A48.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A50":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A50.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset0A50.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A54":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A54.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A54.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0A54.Reconnect(true);
					Offset0A54.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0A56":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A56.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A56.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0A56.Reconnect(true);
					Offset0A56.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0A58":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A58.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A58.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0A58.Reconnect(true);
					Offset0A58.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0A5A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A5A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0A5A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0A5A.Reconnect(true);
					Offset0A5A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0A5C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A5C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0A5C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A5E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A5E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A5E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A60":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A60.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A60.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A62":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A62.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A62.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0A62.Reconnect(true);
					Offset0A62.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0A68":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A68.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A68.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A7A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A7A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A7A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0A7A.Reconnect(true);
					Offset0A7A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0A80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A82":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A82.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0A82.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A84":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A84.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A84.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A86":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A86.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0A86.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0A88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A90":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A90.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0A90.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A98":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A98.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A98.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0A9C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0A9C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0A9C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0AA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AA4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AA4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0AA4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0AB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0AB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ABC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ABC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0ABC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AC0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AC0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0AC0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AE0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AE0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0AE0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AE8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AE8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset0AE8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AEC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AEC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0AEC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AF0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AF0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0AF0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0AF0.Reconnect(true);
					Offset0AF0.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0AF4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AF4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0AF4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0AF8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0AF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0AF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0AF8.Reconnect(true);
					Offset0AF8.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0B00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B18":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B18.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset0B18.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B20":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B20.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0B20.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B20.Reconnect(true);
					Offset0B20.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B24":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B24.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0B24.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B4C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B4C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0B4C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B60":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B60.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0B60.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B60.Reconnect(true);
					Offset0B60.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B64":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B64.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B64.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B64.Reconnect(true);
					Offset0B64.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B65":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B65.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B65.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B65.Reconnect(true);
					Offset0B65.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B66":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B66.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B66.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B66.Reconnect(true);
					Offset0B66.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B67":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B67.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B67.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B67.Reconnect(true);
					Offset0B67.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B68":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B68.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B68.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B68.Reconnect(true);
					Offset0B68.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B69":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B69.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B69.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B69.Reconnect(true);
					Offset0B69.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B6A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B6A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B6A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B6A.Reconnect(true);
					Offset0B6A.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B6B":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B6B.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B6B.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B6B.Reconnect(true);
					Offset0B6B.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B6C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B6C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B6C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B6C.Reconnect(true);
					Offset0B6C.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B6D":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B6D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B6D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B6D.Reconnect(true);
					Offset0B6D.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B6E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B6E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B6E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B6E.Reconnect(true);
					Offset0B6E.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B6F":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B6F.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B6F.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B6F.Reconnect(true);
					Offset0B6F.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B70":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B70.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B70.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B70.Reconnect(true);
					Offset0B70.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B71":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B71.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B71.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B71.Reconnect(true);
					Offset0B71.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B72":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B72.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B72.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B72.Reconnect(true);
					Offset0B72.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B73":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B73.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0B73.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B73.Reconnect(true);
					Offset0B73.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B74":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B74.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B74.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B74.Reconnect(true);
					Offset0B74.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B78":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B78.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B78.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B7C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B7C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B7C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B7C.Reconnect(true);
					Offset0B7C.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B84":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B84.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B84.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B84.Reconnect(true);
					Offset0B84.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B8C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B8C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B8C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B8C.Reconnect(true);
					Offset0B8C.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B90":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B90.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B90.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B94":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B94.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B94.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B94.Reconnect(true);
					Offset0B94.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0B98":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B98.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B98.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0B9C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0B9C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0B9C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0B9C.Reconnect(true);
					Offset0B9C.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BA4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BA4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BA4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BA4.Reconnect(true);
					Offset0BA4.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BA8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BA8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BA8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BAC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BAC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BAC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BAE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BAE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BAE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BB2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BB2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BB2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BB2.Reconnect(true);
					Offset0BB2.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BB4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BB4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BB4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BB6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BB6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BB6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BB6.Reconnect(true);
					Offset0BB6.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BBA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BBA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BBA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BBA.Reconnect(true);
					Offset0BBA.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BBC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BBC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BBC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BBE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BBE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BBE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BBE.Reconnect(true);
					Offset0BBE.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BC0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BC0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BC0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BC0.Reconnect(true);
					Offset0BC0.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BC2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BC2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BC2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BC4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BC4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BC4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BC4.Reconnect(true);
					Offset0BC4.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BC6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BC6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BC6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BC6.Reconnect(true);
					Offset0BC6.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BC8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BC8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BC8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BC8.Reconnect(true);
					Offset0BC8.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BCA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BCA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0BCA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BCC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BCC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BCC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BCC.Reconnect(true);
					Offset0BCC.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BD0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BD0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BD0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BD0.Reconnect(true);
					Offset0BD0.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BD4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BD4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BD4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BD8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BD8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BD8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BDC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BDC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BDC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BDC.Reconnect(true);
					Offset0BDC.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BE0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BE0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BE0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BE4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BE4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BE4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BE8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BE8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BE8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BE8.Reconnect(true);
					Offset0BE8.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0BEC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BEC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BEC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BF0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BF0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BF0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BF4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BF4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BF4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0BF8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0BF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0BF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0BF8.Reconnect(true);
					Offset0BF8.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C00.Reconnect(true);
					Offset0C00.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C01":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C01.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C01.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C01.Reconnect(true);
					Offset0C01.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C06":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C06.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C06.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C06.Reconnect(true);
					Offset0C06.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C18":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C18.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C18.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C18.Reconnect(true);
					Offset0C18.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C1A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C1A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C1A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C1A.Reconnect(true);
					Offset0C1A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C20":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C20.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0C20.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C29":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C29.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0C29.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C2E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C2E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0C2E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C33":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C33.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0C33.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C38":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C38.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset0C38.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C3E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C3E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C3E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C3E.Reconnect(true);
					Offset0C3E.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C48":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C48.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset0C48.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C49":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C49.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset0C49.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C4A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C4A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C4A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C4B":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C4B.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C4B.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C4C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C4C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C4C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C4D":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C4D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C4D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C4E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C4E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C4E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C4E.Reconnect(true);
					Offset0C4E.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C52":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C52.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0C52.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C56":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C56.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0C56.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C59":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C59.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset0C59.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C5A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C5A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C5A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C5B":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C5B.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C5B.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C5C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C5C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0C5C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C5E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C5E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C5E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C5E.Reconnect(true);
					Offset0C5E.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C60":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C60.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0C60.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C62":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C62.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0C62.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C6A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C6A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0C6A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C6C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C6C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0C6C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0C6C.Reconnect(true);
					Offset0C6C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0C6E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C6E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)Offset0C6E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C6F":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C6F.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C6F.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0C70":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0C70.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset0C70.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0D0C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0D0C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0D0C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0D0C.Reconnect(true);
					Offset0D0C.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0D50":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0D50.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset0D50.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0D50.Reconnect(true);
					Offset0D50.Value = Convert.ToInt64(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0D58":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0D58.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset0D58.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0D58.Reconnect(true);
					Offset0D58.Value = Convert.ToInt64(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0D60":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0D60.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset0D60.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0D60.Reconnect(true);
					Offset0D60.Value = Convert.ToInt64(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0D6C":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0D6C.Reconnect(true);
					Offset0D6C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0D70":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0D70.Reconnect(true);
					Offset0D70.Value = data;
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0DD6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0DD6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0DD6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0DD6.Reconnect(true);
					Offset0DD6.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0DD8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0DD8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0DD8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0DD8.Reconnect(true);
					Offset0DD8.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0DDA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0DDA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0DDA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0DDA.Reconnect(true);
					Offset0DDA.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0DDC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0DDC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0DDC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0DDC.Reconnect(true);
					Offset0DDC.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0DDE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0DDE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0DDE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0DDE.Reconnect(true);
					Offset0DDE.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0E8A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E8A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0E8A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0E8A.Reconnect(true);
					Offset0E8A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0E8C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E8C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0E8C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0E90":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E90.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0E90.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0E92":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E92.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0E92.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0E9A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E9A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0E9A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0E9C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E9C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0E9C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0E9E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0E9E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0E9E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EA2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EA2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EA2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EA4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EA4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EA4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EA6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EA6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EA6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EA8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EA8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EA8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EAA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EAA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EAA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EAC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EAC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EAC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EAE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EAE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EAE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EB2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EB2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EB2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EB4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EB4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EB4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EB6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EB6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EB6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EBA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EBA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EBA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EBC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EBC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EBC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EBE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EBE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EBE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EC0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EC0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EC0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EC2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EC2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EC2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EC4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EC4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EC4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EC6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EC6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EC6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EC8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EC8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EC8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ECA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ECA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ECA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ECC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ECC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ECC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ECE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ECE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ECE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ED0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ED0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ED0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ED2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ED2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ED2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ED4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ED4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ED4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ED6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ED6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ED6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0ED8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0ED8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0ED8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EDA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EDA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EDA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EDC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EDC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EDC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EDE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EDE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EDE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EE0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EE0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EE0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EE2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EE2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EE2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EE4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EE4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EE4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EE6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EE6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EE6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EE8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EE8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EE8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EEA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EEA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EEA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EEC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EEC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EEC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EEE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EEE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0EEE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EF0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EF0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EF0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EF2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EF2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EF2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EF4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EF4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EF4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EF6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EF6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EF6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EF8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EFA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EFA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EFA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EFC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EFC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EFC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0EFE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0EFE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0EFE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0F00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0F02":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F02.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F02.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0F04":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F04.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F04.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0F06":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F06.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F06.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0F08":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F08.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F08.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "0F1C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F1C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F1C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F1C.Reconnect(true);
					Offset0F1C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F1E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F1E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F1E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F1E.Reconnect(true);
					Offset0F1E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F20":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F20.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F20.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F20.Reconnect(true);
					Offset0F20.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F22":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F22.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F22.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F22.Reconnect(true);
					Offset0F22.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F24":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F24.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F24.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F24.Reconnect(true);
					Offset0F24.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F26":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F26.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F26.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F26.Reconnect(true);
					Offset0F26.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F28":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F28.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F28.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F28.Reconnect(true);
					Offset0F28.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F2A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F2A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F2A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F2A.Reconnect(true);
					Offset0F2A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F2C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F2C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F2C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F2C.Reconnect(true);
					Offset0F2C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F2E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F2E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F2E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F2E.Reconnect(true);
					Offset0F2E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F30":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F30.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F30.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F30.Reconnect(true);
					Offset0F30.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F32":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F32.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F32.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F32.Reconnect(true);
					Offset0F32.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F34":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F34.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F34.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F34.Reconnect(true);
					Offset0F34.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F36":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F36.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F36.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F36.Reconnect(true);
					Offset0F36.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F38":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F38.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F38.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F38.Reconnect(true);
					Offset0F38.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F3A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F3A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F3A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F3A.Reconnect(true);
					Offset0F3A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F3C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F3C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F3C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F3C.Reconnect(true);
					Offset0F3C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F3E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F3E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F3E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F3E.Reconnect(true);
					Offset0F3E.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F40":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F40.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F40.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F40.Reconnect(true);
					Offset0F40.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F42":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F42.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F42.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F42.Reconnect(true);
					Offset0F42.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F44":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F44.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F44.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F44.Reconnect(true);
					Offset0F44.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F46":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F46.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F46.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F46.Reconnect(true);
					Offset0F46.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F48":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F48.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F48.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F48.Reconnect(true);
					Offset0F48.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F4A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F4A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F4A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F4A.Reconnect(true);
					Offset0F4A.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F4C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F4C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F4C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F4C.Reconnect(true);
					Offset0F4C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F4E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F4E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F4E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F4E.Reconnect(true);
					Offset0F4E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F50":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F50.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F50.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F50.Reconnect(true);
					Offset0F50.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F52":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F52.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F52.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F52.Reconnect(true);
					Offset0F52.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F54":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F54.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F54.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F54.Reconnect(true);
					Offset0F54.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F56":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F56.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F56.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F56.Reconnect(true);
					Offset0F56.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F58":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F58.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F58.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F58.Reconnect(true);
					Offset0F58.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F5A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F5A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F5A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F5A.Reconnect(true);
					Offset0F5A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F5C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F5C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F5C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F5C.Reconnect(true);
					Offset0F5C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F5E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F5E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F5E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F5E.Reconnect(true);
					Offset0F5E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F60":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F60.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F60.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F60.Reconnect(true);
					Offset0F60.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F62":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F62.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F62.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F62.Reconnect(true);
					Offset0F62.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F64":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F64.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F64.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F64.Reconnect(true);
					Offset0F64.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F66":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F66.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F66.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F66.Reconnect(true);
					Offset0F66.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F68":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F68.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F68.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F68.Reconnect(true);
					Offset0F68.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F6A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F6A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F6A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F6A.Reconnect(true);
					Offset0F6A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F6C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F6C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F6C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F6C.Reconnect(true);
					Offset0F6C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F6E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F6E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F6E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F6E.Reconnect(true);
					Offset0F6E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F70":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F70.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset0F70.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F70.Reconnect(true);
					Offset0F70.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F72":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F72.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F72.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F72.Reconnect(true);
					Offset0F72.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F74":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F74.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F74.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F74.Reconnect(true);
					Offset0F74.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F76":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F76.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F76.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F76.Reconnect(true);
					Offset0F76.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F78":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F78.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F78.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F78.Reconnect(true);
					Offset0F78.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F7A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F7A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F7A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F7A.Reconnect(true);
					Offset0F7A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F7C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F7C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F7C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F7C.Reconnect(true);
					Offset0F7C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F7E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F7E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F7E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F7E.Reconnect(true);
					Offset0F7E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F80.Reconnect(true);
					Offset0F80.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F82":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F82.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F82.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F82.Reconnect(true);
					Offset0F82.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F84":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F84.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F84.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F84.Reconnect(true);
					Offset0F84.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F86":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F86.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F86.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F86.Reconnect(true);
					Offset0F86.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F88.Reconnect(true);
					Offset0F88.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F8A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F8A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F8A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F8A.Reconnect(true);
					Offset0F8A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0F8C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0F8C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0F8C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0F8C.Reconnect(true);
					Offset0F8C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0FF0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0FF0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0FF0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0FF0.Reconnect(true);
					Offset0FF0.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0FF4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0FF4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0FF4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0FF4.Reconnect(true);
					Offset0FF4.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0FF6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0FF6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset0FF6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0FF6.Reconnect(true);
					Offset0FF6.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0FF8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0FF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset0FF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset0FF8.Reconnect(true);
					Offset0FF8.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "0FFC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset0FFC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset0FFC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1000":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1000.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset1000.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "115E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset115E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset115E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "11A2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11A2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset11A2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset11A2.Reconnect(true);
					Offset11A2.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "11A4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11A4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset11A4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset11A4.Reconnect(true);
					Offset11A4.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "11B6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11B6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset11B6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset11B6.Reconnect(true);
					Offset11B6.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "11BA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11BA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset11BA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "11BE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11BE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset11BE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "11C6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11C6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset11C6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "11D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset11D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset11D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1244":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1244.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset1244.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1244.Reconnect(true);
					Offset1244.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1248":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1248.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset1248.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "124C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset124C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset124C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset124C.Reconnect(true);
					Offset124C.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1250":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1250.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset1250.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1254":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1254.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset1254.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1254.Reconnect(true);
					Offset1254.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1258":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1258.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset1258.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "125C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset125C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset125C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset125C.Reconnect(true);
					Offset125C.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1260":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1260.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset1260.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1274":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1274.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset1274.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1274.Reconnect(true);
					Offset1274.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "132C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset132C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset132C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset132C.Reconnect(true);
					Offset132C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1334":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1334.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset1334.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1334.Reconnect(true);
					Offset1334.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "13FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset13FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset13FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1400":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1400.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset1400.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1408":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1408.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset1408.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1410":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1410.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset1410.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1418":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1418.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset1418.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1420":
		{
			if (mode == "READ")
			{
				try
				{
					Offset1420.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset1420.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "1F80":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F80.Reconnect(true);
					Offset1F80.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F84":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F84.Reconnect(true);
					Offset1F84.Value = (float)Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F88":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F88.Reconnect(true);
					Offset1F88.Value = (float)Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F8C":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F8C.Reconnect(true);
					Offset1F8C.Value = (float)Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F90":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F90.Reconnect(true);
					Offset1F90.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F92":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F92.Reconnect(true);
					Offset1F92.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F94":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F94.Reconnect(true);
					Offset1F94.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1F96":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1F96.Reconnect(true);
					Offset1F96.Value = data;
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1FA5":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1FA5.Reconnect(true);
					Offset1FA5.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "1FA6":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset1FA6.Reconnect(true);
					Offset1FA6.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2000":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2000.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2000.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2008":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2008.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2008.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2010":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2010.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2010.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2018":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2018.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2018.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2020":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2020.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2020.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2028":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2028.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2028.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2030":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2030.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2030.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2038":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2038.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2038.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2048":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2048.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset2048.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "204C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset204C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset204C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "205C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset205C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset205C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2060":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2060.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2060.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "206C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset206C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset206C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "207C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset207C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset207C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2100":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2100.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2100.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2108":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2108.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2108.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2110":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2110.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2110.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2118":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2118.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2118.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2120":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2120.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2120.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2128":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2128.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2128.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2130":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2130.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2130.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2138":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2138.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2138.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2148":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2148.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2148.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "214C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset214C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset214C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "215C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset215C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset215C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2160":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2160.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2160.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "216C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset216C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset216C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "217C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset217C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset217C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2184":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2184.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2184.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2200":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2200.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2200.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2208":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2208.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2208.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2210":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2210.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2210.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2218":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2218.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2218.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2220":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2220.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2220.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2228":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2228.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2228.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2230":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2230.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2230.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2238":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2238.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2238.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2248":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2248.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset2248.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "224C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset224C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset224C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "225C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset225C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset225C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2260":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2260.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2260.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "226C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset226C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset226C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "227C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset227C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset227C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2300":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2300.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2300.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2308":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2308.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2308.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2310":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2310.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2310.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2318":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2318.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2318.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2320":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2320.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2320.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2328":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2328.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2328.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2330":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2330.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2330.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2338":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2338.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2338.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2348":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2348.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset2348.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "234C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset234C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset234C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "235C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset235C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset235C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2360":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2360.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2360.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "236C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset236C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset236C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "237C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset237C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset237C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2400":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2400.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2400.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2408":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2408.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2408.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2410":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2410.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2410.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2418":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2418.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2418.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2500":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2500.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2500.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2508":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2508.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2508.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2510":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2510.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2510.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2518":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2518.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2518.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2600":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2600.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2600.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2608":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2608.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2608.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2610":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2610.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2610.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2618":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2618.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2618.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2700":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2700.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2700.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2708":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2708.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2708.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2710":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2710.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2710.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2718":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2718.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2718.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "281C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset281C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset281C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2834":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2834.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2834.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "28F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset28F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset28F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2900":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2900.Reconnect(true);
					Offset2900.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2904":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2904.Reconnect(true);
					Offset2904.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2908":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2908.Reconnect(true);
					Offset2908.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "290C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset290C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset290C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2910":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2910.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2910.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2910.Reconnect(true);
					Offset2910.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2911":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2911.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2911.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2911.Reconnect(true);
					Offset2911.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2912":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2912.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2912.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2912.Reconnect(true);
					Offset2912.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2913":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2913.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2913.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2913.Reconnect(true);
					Offset2913.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2A48":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2A48.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2A48.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2A50":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2A50.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2A50.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2A70":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2A70.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2A70.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2A78":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2A78.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2A78.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2A80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2A80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2A80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2A88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2A88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset2A88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2A88.Reconnect(true);
					Offset2A88.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2AAC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2AAC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset2AAC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2AB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2AB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset2AB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2AB4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2AB4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset2AB4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2AB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2AB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)Offset2AB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2B00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2B00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2B00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2DC6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2DC6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset2DC6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DC6.Reconnect(true);
					Offset2DC6.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2DC8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2DC8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2DC8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DC8.Reconnect(true);
					Offset2DC8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2DD0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2DD0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2DD0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DD0.Reconnect(true);
					Offset2DD0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2DD8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2DD8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2DD8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DD8.Reconnect(true);
					Offset2DD8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2DE0":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DE0.Reconnect(true);
					Offset2DE0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2DE8":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DE8.Reconnect(true);
					Offset2DE8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2DF0":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2DF0.Reconnect(true);
					Offset2DF0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2E80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2E80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset2E80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2E80.Reconnect(true);
					Offset2E80.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2E88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2E88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset2E88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2E88.Reconnect(true);
					Offset2E88.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2E98":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2E98.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2E98.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EA8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EA8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EA8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EC0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EC0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EC0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EC8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EC8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset2EC8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2EC8.Reconnect(true);
					Offset2EC8.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2ED0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2ED0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2ED0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2ED8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2ED8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2ED8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EE0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EE0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset2EE0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2EE0.Reconnect(true);
					Offset2EE0.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2EE8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EE8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EE8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EF0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EF0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EF0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2EF8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2EF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2EF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2F70":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2F70.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2F70.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2F78":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2F78.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2F78.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2F80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2F80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2F80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2F80.Reconnect(true);
					Offset2F80.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "2F88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2F88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2F88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2F90":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2F90.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2F90.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2F98":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2F98.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2F98.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2FA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2FA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset2FA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2FAB":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2FAB.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2FAB.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2FAD":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2FAD.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2FAD.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2FAE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2FAE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset2FAE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2FB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset2FB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset2FB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "2FE0":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset2FE0.Reconnect(true);
					Offset2FE0.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3000":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3000.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3000.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3006":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3006.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3006.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "301F":
		{
			if (mode == "READ")
			{
				try
				{
					Offset301F.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset301F.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3025":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3025.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3025.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "303E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset303E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset303E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3044":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3044.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3044.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3060":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3060.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3060.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3060.Reconnect(true);
					Offset3060.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3068":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3068.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3068.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3068.Reconnect(true);
					Offset3068.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3070":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3070.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3070.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3070.Reconnect(true);
					Offset3070.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3078":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3078.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3078.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3078.Reconnect(true);
					Offset3078.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3080":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3080.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3080.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3080.Reconnect(true);
					Offset3080.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3088":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3088.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3088.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3088.Reconnect(true);
					Offset3088.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3090":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3090.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3090.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3090.Reconnect(true);
					Offset3090.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3098":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3098.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3098.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3098.Reconnect(true);
					Offset3098.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "30A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset30A0.Reconnect(true);
					Offset30A0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "30A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset30A8.Reconnect(true);
					Offset30A8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "30B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset30B0.Reconnect(true);
					Offset30B0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "30B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset30B8.Reconnect(true);
					Offset30B8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "30C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset30D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30E2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30E2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30E2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30E4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30E4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30E4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30E6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30E6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30E6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30EA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30EA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30EA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30EC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30EC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30EC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30EE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30EE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset30EE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30F2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30F2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30F2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30F4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30F4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30F4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30F6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30F6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30F6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30FA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30FA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30FA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "30FE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset30FE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset30FE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3100":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3100.Reconnect(true);
					Offset3100.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3101":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3101.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3101.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3101.Reconnect(true);
					Offset3101.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3102":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3102.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3102.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3102.Reconnect(true);
					Offset3102.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3103":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3103.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3103.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3103.Reconnect(true);
					Offset3103.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3104":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3104.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3104.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3104.Reconnect(true);
					Offset3104.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3105":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3105.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3105.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3105.Reconnect(true);
					Offset3105.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3106":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3106.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3106.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3106.Reconnect(true);
					Offset3106.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3107":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3107.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3107.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3107.Reconnect(true);
					Offset3107.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3108":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3108.Reconnect(true);
					Offset3108.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3109":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3109.Reconnect(true);
					Offset3109.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "310A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset310A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset310A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset310A.Reconnect(true);
					Offset310A.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "310B":
		{
			if (mode == "READ")
			{
				try
				{
					Offset310B.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset310B.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset310B.Reconnect(true);
					Offset310B.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "310C":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset310C.Reconnect(true);
					Offset310C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3110":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3110.Reconnect(true);
					Offset3110.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3114":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3114.Reconnect(true);
					Offset3114.Value = Convert.ToInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3118":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3118.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3118.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3118.Reconnect(true);
					Offset3118.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "311A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset311A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset311A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset311A.Reconnect(true);
					Offset311A.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "311C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset311C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset311C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset311C.Reconnect(true);
					Offset311C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "311E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset311E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset311E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset311E.Reconnect(true);
					Offset311E.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3120":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3120.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3120.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3120.Reconnect(true);
					Offset3120.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3122":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3122.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3122.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3122.Reconnect(true);
					Offset3122.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3123":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3123.Reconnect(true);
					Offset3123.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3125":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3125.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3125.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3125.Reconnect(true);
					Offset3125.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3127":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3127.Reconnect(true);
					Offset3127.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3128":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3128.Reconnect(true);
					Offset3128.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "312C":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset312C.Reconnect(true);
					Offset312C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3130":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3130.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3130.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "313C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset313C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset313C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3148":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3148.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3148.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3160":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3160.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3160.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3178":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3178.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3178.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3178.Reconnect(true);
					Offset3178.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3180":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3180.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3180.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3180.Reconnect(true);
					Offset3180.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3188":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3188.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3188.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3188.Reconnect(true);
					Offset3188.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3190":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3190.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3190.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3190.Reconnect(true);
					Offset3190.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3198":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3198.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3198.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3198.Reconnect(true);
					Offset3198.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31A0.Reconnect(true);
					Offset31A0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31A8.Reconnect(true);
					Offset31A8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31B0.Reconnect(true);
					Offset31B0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31B8.Reconnect(true);
					Offset31B8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31C0.Reconnect(true);
					Offset31C0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31C8.Reconnect(true);
					Offset31C8.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset31D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31D0.Reconnect(true);
					Offset31D0.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset31D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31DA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31DA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset31DA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31DC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31DC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset31DC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31DE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31DE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset31DE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset31E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31E2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31E2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset31E2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31E4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31E4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset31E4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset31E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31EC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31EC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset31EC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset31F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset31F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "31F4":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31F4.Reconnect(true);
					Offset31F4.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31F8":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31F8.Reconnect(true);
					Offset31F8.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "31FC":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset31FC.Reconnect(true);
					Offset31FC.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3200":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3200.Reconnect(true);
					Offset3200.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "320C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset320C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset320C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3210":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3210.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3210.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3210.Reconnect(true);
					Offset3210.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3211":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3211.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3211.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3211.Reconnect(true);
					Offset3211.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3212":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3212.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3212.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3212.Reconnect(true);
					Offset3212.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3213":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3213.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3213.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3213.Reconnect(true);
					Offset3213.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "32F0":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset32F0.Reconnect(true);
					Offset32F0.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "32F6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32F6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset32F6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset32F6.Reconnect(true);
					Offset32F6.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "32F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset32F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset32F8.Reconnect(true);
					Offset32F8.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "32F9":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32F9.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset32F9.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "32FA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32FA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset32FA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset32FA.Reconnect(true);
					Offset32FA.Value = Convert.ToInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "32FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset32FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset32FC.Reconnect(true);
					Offset32FC.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "32FE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32FE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset32FE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "32FF":
		{
			if (mode == "READ")
			{
				try
				{
					Offset32FF.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset32FF.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3300":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3300.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3300.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3302":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3302.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3302.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3304":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3304.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3304.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3306":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3306.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3306.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3308":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3308.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3308.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "330A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset330A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset330A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "330E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset330E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset330E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3320":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3320.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3320.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3320.Reconnect(true);
					Offset3320.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3322":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3322.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3322.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3324":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3324.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset3324.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3328":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3328.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3328.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "332A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset332A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset332A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "332C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset332C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset332C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "332E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset332E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset332E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3330":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3330.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3330.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3332":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3332.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3332.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3334":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3334.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3334.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3336":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3336.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3336.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3338":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3338.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3338.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "333A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset333A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset333A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "333C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset333C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset333C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "333E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset333E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset333E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3340":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3340.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3340.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3340.Reconnect(true);
					Offset3340.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3344":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3344.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3344.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3344.Reconnect(true);
					Offset3344.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3348":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3348.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3348.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3348.Reconnect(true);
					Offset3348.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "334C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset334C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset334C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset334C.Reconnect(true);
					Offset334C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3350":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3350.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3350.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3350.Reconnect(true);
					Offset3350.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3354":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3354.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3354.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3354.Reconnect(true);
					Offset3354.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3358":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3358.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3358.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3358.Reconnect(true);
					Offset3358.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "335C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset335C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset335C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset335C.Reconnect(true);
					Offset335C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3360":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3360.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3360.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3360.Reconnect(true);
					Offset3360.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3364":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3364.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3364.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3365":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3365.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3365.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3366":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3366.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3366.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3366.Reconnect(true);
					Offset3366.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3367":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3367.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3367.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3368":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3368.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3368.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "336C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset336C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset336C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "336E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset336E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset336E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3370":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3370.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3370.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3374":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3374.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3374.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3378":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3378.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3378.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "337C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset337C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset337C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset337C.Reconnect(true);
					Offset337C.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "337D":
		{
			if (mode == "READ")
			{
				try
				{
					Offset337D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset337D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset337D.Reconnect(true);
					Offset337D.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "337E":
		{
			if (mode == "READ")
			{
				try
				{
					Offset337E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset337E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3380":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3380.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3380.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3380.Reconnect(true);
					Offset3380.Value = data;
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3412":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3412.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3412.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3414":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3414.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3414.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3416":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3416.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3416.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3418":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3418.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3418.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "341A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset341A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset341A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset341A.Reconnect(true);
					Offset341A.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3470":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3470.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3470.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3478":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3478.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3478.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3478.Reconnect(true);
					Offset3478.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3480":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3480.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3480.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3488":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3488.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3488.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3490":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3490.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3490.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3498":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3498.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3498.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "34A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset34A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset34A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "34A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset34A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset34A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "34B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset34B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset34B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "34B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset34B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset34B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "34C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset34C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset34C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3500":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3500.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3500.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3518":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3518.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3518.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3520":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3520.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3520.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3541":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3541.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3541.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3541.Reconnect(true);
					Offset3541.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3542":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3542.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3542.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3542.Reconnect(true);
					Offset3542.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3544":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3544.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset3544.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3548":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3548.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3548.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3550":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3550.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)Offset3550.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3552":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3552.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3552.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3554":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3554.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3554.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3556":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3556.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3556.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3558":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3558.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3558.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "355A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset355A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset355A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3560":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3560.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3560.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3562":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3562.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3562.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3564":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3564.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3564.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3566":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3566.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3566.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3568":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3568.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3568.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "356A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset356A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset356A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3570":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3570.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3570.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3572":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3572.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3572.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3574":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3574.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3574.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3576":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3576.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3576.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3578":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3578.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3578.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "357A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset357A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset357A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3580":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3580.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3580.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3582":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3582.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3582.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3584":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3584.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3584.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3586":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3586.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3586.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3588":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3588.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3588.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "358A":
		{
			if (mode == "READ")
			{
				try
				{
					Offset358A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset358A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3590":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3590.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3590.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3590.Reconnect(true);
					Offset3590.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3594":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3594.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3594.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3594.Reconnect(true);
					Offset3594.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3598":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3598.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3598.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3598.Reconnect(true);
					Offset3598.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "359C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset359C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset359C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset359C.Reconnect(true);
					Offset359C.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "35A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset35A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "35A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset35A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "35E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset35E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "35E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset35E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "35F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset35F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "35F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset35F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "35FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset35FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset35FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3600":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3600.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3600.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3608":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3608.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3608.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3610":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3610.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3610.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3618":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3618.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3618.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3620":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3620.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3620.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3628":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3628.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3628.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3640":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3640.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3640.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3644":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3644.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3644.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3648":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3648.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3648.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "364C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset364C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset364C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3654":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3654.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3654.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3660":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3660.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3660.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3668":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3668.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3668.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3670":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3670.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3670.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3678":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3678.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3678.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3680":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3680.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3680.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3688":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3688.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3688.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3690":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3690.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3690.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3694":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3694.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3694.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3698":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3698.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3698.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset36B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset36BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36D0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36D0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36D0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "36E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset36E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset36E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3700":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3700.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3700.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3704":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3704.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3704.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3708":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3708.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3708.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "370C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset370C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset370C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3714":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3714.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3714.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3720":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3720.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3720.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3728":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3728.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3728.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3730":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3730.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3730.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3738":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3738.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3738.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3740":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3740.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3740.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3748":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3748.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3748.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3750":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3750.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3750.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3754":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3754.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3754.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3758":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3758.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3758.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3760":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3760.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3760.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3768":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3768.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3768.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3770":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3770.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3770.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3778":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3778.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3778.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "377C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset377C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset377C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3780":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3780.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3780.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3788":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3788.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3788.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3790":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3790.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3790.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3798":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3798.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3798.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset37C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37C4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37C4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset37C4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37C8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37C8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset37C8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37CC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37CC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37CC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37D4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37D4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset37D4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "37F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset37F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset37F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3800":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3800.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3800.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3808":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3808.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3808.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3810":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3810.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3810.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3814":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3814.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3814.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3818":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3818.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3818.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3820":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3820.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3820.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3828":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3828.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3828.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3830":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3830.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3830.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3838":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3838.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3838.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "383C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset383C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset383C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3840":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3840.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3840.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3848":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3848.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3848.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3850":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3850.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3850.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3858":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3858.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3858.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3860":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3860.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3860.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3868":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3868.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3868.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3870":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3870.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3870.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3880":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3880.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3880.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3884":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3884.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3884.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3888":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3888.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3888.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "388C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset388C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset388C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3894":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3894.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3894.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "38A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset38A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset38A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "38A4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset38A4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset38A4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "38A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset38A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset38A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "38B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset38B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset38B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "38B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset38B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset38B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "38C0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset38C0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset38C0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3918":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3918.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3918.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3920":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3920.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3920.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3928":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3928.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3928.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3930":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3930.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3930.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3938":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3938.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3938.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "393C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset393C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset393C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3940":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3940.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3940.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3948":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3948.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3948.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3958":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3958.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3958.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3960":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3960.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3960.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3964":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3964.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3964.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3968":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3968.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3968.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3970":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3970.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3970.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3978":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3978.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3978.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3980":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3980.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3980.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "39D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset39D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset39D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "39E0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset39E0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset39E0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "39E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset39E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset39E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "39F0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset39F0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset39F0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "39F8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset39F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset39F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "39FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset39FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset39FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3A00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A08":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A08.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3A08.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A18":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A18.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3A18.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A20":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A20.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3A20.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A24":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A24.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3A24.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A28":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A28.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3A28.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A30":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A30.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3A30.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A38":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A38.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3A38.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A40":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A40.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3A40.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3A98":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3A98.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3A98.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AA8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AA8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AA8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3AB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3ABC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3ABC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3ABC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AC0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AC0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AC0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AC8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AC8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AC8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AD8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AD8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3AD8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AE0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AE0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3AE0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AE4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AE4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3AE4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AE8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AE8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AE8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AF0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AF0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AF0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3AF8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3AF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3AF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3B00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B58":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B58.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3B58.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B60":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B60.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3B60.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B68":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B68.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3B68.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B70":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B70.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3B70.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B78":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B78.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3B78.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B7C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B7C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3B7C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B80":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3B80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B88":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3B88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3B98":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3B98.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3B98.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BA0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BA0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset3BA0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BA8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BA8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BA8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BAA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BAA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BAA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BAC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BAC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BAC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BB0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BB0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BB0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BB2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BB2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BB2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BB4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BB4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BB4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BB6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BB6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BB6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BB8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BB8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BB8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BBA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BBA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BBA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BBC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BBC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BBC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BBE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BBE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BBE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BC0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BC0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BC0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BC2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BC2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BC2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BC4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BC4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BC4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BC6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BC6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BC6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BC8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BC8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BC8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BC8.Reconnect(true);
					Offset3BC8.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BD2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BD2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BD2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BD6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BD6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BD6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BD6.Reconnect(true);
					Offset3BD6.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BD7":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BD7.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BD7.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BD7.Reconnect(true);
					Offset3BD7.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BD8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BD8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BD8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BD8.Reconnect(true);
					Offset3BD8.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BD9":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BD9.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BD9.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BD9.Reconnect(true);
					Offset3BD9.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BDA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BDA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BDA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BDA.Reconnect(true);
					Offset3BDA.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BDB":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BDB.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BDB.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BDB.Reconnect(true);
					Offset3BDB.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BDC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BDC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BDC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BDD":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BDD.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BDD.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BDD.Reconnect(true);
					Offset3BDD.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BDE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BDE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BDE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BDE.Reconnect(true);
					Offset3BDE.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BDF":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BDF.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BDF.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BDF.Reconnect(true);
					Offset3BDF.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BE0.Reconnect(true);
					Offset3BE0.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE1":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE1.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE1.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BE1.Reconnect(true);
					Offset3BE1.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE2":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE2.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE2.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BE2.Reconnect(true);
					Offset3BE2.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE3":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE3.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE3.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BE3.Reconnect(true);
					Offset3BE3.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BE4.Reconnect(true);
					Offset3BE4.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE5":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE5.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE5.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BE6":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BE6.Reconnect(true);
					Offset3BE6.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BE7":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BE7.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset3BE7.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3BFA":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BFA.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3BFA.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BFA.Reconnect(true);
					Offset3BFA.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3BFC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3BFC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset3BFC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3BFC.Reconnect(true);
					Offset3BFC.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3C00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3C00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3C00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3D00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3D00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3D00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3E00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3E00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3E00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3F00":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3F00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3F00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3F00.Reconnect(true);
					Offset3F00.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "3F02":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3F02.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset3F02.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "3F04":
		{
			if (mode == "READ")
			{
				try
				{
					Offset3F04.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset3F04.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset3F04.Reconnect(true);
					Offset3F04.Value = data;
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "5280":
		{
			if (mode == "READ")
			{
				try
				{
					Offset5280.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset5280.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "5281":
		{
			if (mode == "READ")
			{
				try
				{
					Offset5281.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset5281.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "5530":
		{
			if (mode == "READ")
			{
				try
				{
					Offset5530.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset5530.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset5530.Reconnect(true);
					Offset5530.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "57FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset57FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset57FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset57FC.Reconnect(true);
					Offset57FC.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "57FE":
		{
			if (mode == "READ")
			{
				try
				{
					Offset57FE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset57FE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset57FE.Reconnect(true);
					Offset57FE.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "6000":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6000.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset6000.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6004":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6004.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6004.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6008":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6008.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6008.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "600C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset600C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset600C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6010":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6010.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6010.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6018":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6018.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6018.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6020":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6020.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6020.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6028":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6028.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6028.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6030":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6030.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6030.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6038":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6038.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6038.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6040":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6040.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6040.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6048":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6048.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6048.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6050":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6050.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6050.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6058":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6058.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6058.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6060":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6060.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6060.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6068":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6068.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6068.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6078":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6078.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6078.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6080":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6080.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset6080.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6081":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6081.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset6081.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "608C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset608C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset608C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6094":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6094.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6094.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "609C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset609C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset609C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60A4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60A4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)Offset60A4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60AC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60AC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset60AC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60B4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60B4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset60B4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset60BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60E4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60E4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset60E4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60E8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60E8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset60E8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60EC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60EC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset60EC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60F4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60F4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset60F4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "60FC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset60FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset60FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6100":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6100.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6100.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6104":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6104.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6104.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6108":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6108.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset6108.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "610C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset610C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset610C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6120":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6120.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6120.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6128":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6128.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6128.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6137":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6137.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset6137.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6140":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6140.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset6140.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6150":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6150.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset6150.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6154":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6154.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset6154.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6160":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6160.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6160.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6168":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6168.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset6168.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "616C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset616C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset616C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6170":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6170.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6170.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6178":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6178.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6178.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6180":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6180.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6180.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6188":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6188.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset6188.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6190":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6190.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6190.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6198":
		{
			if (mode == "READ")
			{
				try
				{
					Offset6198.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset6198.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "619C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset619C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset619C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "61A0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset61A0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset61A0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "61A8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset61A8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)Offset61A8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "61B0":
		{
			if (mode == "READ")
			{
				try
				{
					Offset61B0.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset61B0.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "61B8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset61B8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset61B8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "6D60":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset6D60.Reconnect(true);
					Offset6D60.Value = data;
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "8320":
		{
			if (mode == "READ")
			{
				try
				{
					Offset8320.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset8320.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset8320.Reconnect(true);
					Offset8320.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "832C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset832C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset832C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset832C.Reconnect(true);
					Offset832C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "833C":
		{
			if (mode == "READ")
			{
				try
				{
					Offset833C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)Offset833C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset833C.Reconnect(true);
					Offset833C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "8340":
		{
			if (mode == "READ")
			{
				try
				{
					Offset8340.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset8340.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset8340.Reconnect(true);
					Offset8340.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "8345":
		{
			if (mode == "READ")
			{
				try
				{
					Offset8345.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)Offset8345.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset8345.Reconnect(true);
					Offset8345.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "8348":
		{
			if (mode == "READ")
			{
				try
				{
					Offset8348.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset8348.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					Offset8348.Reconnect(true);
					Offset8348.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "83BC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset83BC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset83BC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "83C4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset83C4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset83C4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "83CC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset83CC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((long)Offset83CC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "83D4":
		{
			if (mode == "READ")
			{
				try
				{
					Offset83D4.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset83D4.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "83D8":
		{
			if (mode == "READ")
			{
				try
				{
					Offset83D8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)Offset83D8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "83DC":
		{
			if (mode == "READ")
			{
				try
				{
					Offset83DC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)Offset83DC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C00C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC00C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC00C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C024":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC024.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)OffsetC024.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C028":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC028.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC028.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C02A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC02A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC02A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C02C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC02C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC02C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C02E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC02E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)OffsetC02E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C030":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC030.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC030.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C034":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC034.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC034.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C038":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC038.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC038.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C03A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC03A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC03A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C03C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC03C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC03C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C03E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC03E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC03E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C0F8":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC0F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC0F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C0FC":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC0FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC0FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C0FE":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC0FE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC0FE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C100":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC100.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC100.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C102":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC102.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC102.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C104":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC104.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC104.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C105":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC105.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC105.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C106":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC106.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC106.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C108":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC108.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC108.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C27C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC27C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC27C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C280":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC280.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC280.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C282":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC282.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC282.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C284":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC284.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC284.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C286":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC286.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC286.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C287":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC287.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC287.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C288":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC288.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC288.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C289":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC289.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC289.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C28A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC28A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC28A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C28C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC28C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC28C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C28D":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC28D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC28D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C28E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC28E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC28E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C428":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC428.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC428.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C42A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC42A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC42A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C42C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC42C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC42C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C42E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC42E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)OffsetC42E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C430":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC430.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC430.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C434":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC434.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC434.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C438":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC438.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC438.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C43A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC43A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC43A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C43C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC43C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC43C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C43E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC43E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC43E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C4F8":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC4F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC4F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C4FC":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC4FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC4FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C4FE":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC4FE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC4FE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C500":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC500.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC500.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C502":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC502.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC502.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C504":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC504.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC504.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C505":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC505.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC505.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C506":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC506.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC506.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C508":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC508.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC508.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C67C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC67C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC67C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C680":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC680.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC680.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C682":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC682.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC682.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C684":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC684.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC684.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C686":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC686.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC686.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C687":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC687.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC687.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C688":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC688.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC688.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C689":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC689.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC689.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C68A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC68A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC68A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C68C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC68C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC68C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C68D":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC68D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC68D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C68E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC68E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC68E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C800":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC800.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC800.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetC800.Reconnect(true);
					OffsetC800.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "C808":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC808.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetC808.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetC808.Reconnect(true);
					OffsetC808.Value = data;
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "C80C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC80C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC80C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetC80C.Reconnect(true);
					OffsetC80C.Value = Convert.ToUInt16(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "C824":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC824.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)OffsetC824.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetC824.Reconnect(true);
					OffsetC824.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "C828":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC828.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC828.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C82A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC82A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC82A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C82C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC82C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC82C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C82E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC82E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)OffsetC82E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C830":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC830.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC830.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C834":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC834.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC834.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C838":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC838.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC838.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C83A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC83A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC83A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C83C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC83C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC83C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C83E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC83E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetC83E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C8F8":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC8F8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetC8F8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C8FC":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC8FC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC8FC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C8FE":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC8FE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC8FE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C900":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC900.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC900.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C902":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC902.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC902.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C904":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC904.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC904.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C905":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC905.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetC905.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C906":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC906.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC906.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "C908":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetC908.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetC908.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA7C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA7C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetCA7C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA80":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCA80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA82":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA82.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCA82.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA84":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA84.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCA84.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA86":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA86.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA86.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA87":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA87.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA87.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA88":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA89":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA89.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA89.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA8A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA8A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetCA8A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA8C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA8C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA8C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA8D":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA8D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA8D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CA8E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCA8E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCA8E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC04":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetCC04.Reconnect(true);
					OffsetCC04.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "CC08":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC08.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)OffsetCC08.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetCC08.Reconnect(true);
					OffsetCC08.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "CC0C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC0C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC0C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC10":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC10.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)OffsetCC10.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetCC10.Reconnect(true);
					OffsetCC10.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "CC18":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC18.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((double)OffsetCC18.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetCC18.Reconnect(true);
					OffsetCC18.Value = Convert.ToDouble(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "CC24":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC24.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)OffsetCC24.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC28":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC28.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC28.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC2A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC2A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC2A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC2C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC2C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC2C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC2E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC2E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((sbyte)OffsetCC2E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC30":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC30.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC30.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC34":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC34.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetCC34.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC38":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC38.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC38.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC3A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC3A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetCC3A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC3C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC3C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCC3C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CC3E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCC3E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetCC3E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CCF8":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCCF8.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetCCF8.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CCFC":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCCFC.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCCFC.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CCFE":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCCFE.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCCFE.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CD00":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCD00.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCD00.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CD02":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCD02.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCD02.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CD04":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCD04.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCD04.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CD05":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCD05.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCD05.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CD06":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCD06.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCD06.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CD08":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCD08.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCD08.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE7C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE7C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetCE7C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE80":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE80.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCE80.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE82":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE82.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCE82.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE84":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE84.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetCE84.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE86":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE86.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE86.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE87":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE87.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE87.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE88":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE88.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE88.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE89":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE89.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE89.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE8A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE8A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetCE8A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE8C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE8C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE8C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE8D":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE8D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE8D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "CE8E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetCE8E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetCE8E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D000":
		{
			if (mode == "READ")
			{
				result = "NOK";
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetD000.Reconnect(true);
					OffsetD000.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "D004":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD004.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)OffsetD004.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetD004.Reconnect(true);
					OffsetD004.Value = Convert.ToUInt32(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "D008":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD008.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((uint)OffsetD008.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D00C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD00C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD00C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D00D":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD00D.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD00D.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D00E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD00E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD00E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D00F":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD00F.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD00F.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D010":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD010.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetD010.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D040":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD040.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetD040.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D044":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD044.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetD044.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D046":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD046.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetD046.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D048":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD048.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetD048.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D04C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD04C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetD04C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D050":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD050.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD050.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D051":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD051.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD051.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D052":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD052.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetD052.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D840":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD840.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetD840.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D844":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD844.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetD844.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D846":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD846.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetD846.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D848":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD848.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetD848.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D84C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD84C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetD84C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D850":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD850.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD850.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D851":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD851.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetD851.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "D852":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetD852.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetD852.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E000":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE000.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE000.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E002":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE002.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE002.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E004":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE004.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE004.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E006":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE006.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE006.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E008":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE008.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetE008.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E068":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE068.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetE068.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetE068.Reconnect(true);
					OffsetE068.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "E069":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE069.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetE069.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetE069.Reconnect(true);
					OffsetE069.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "E06A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE06A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetE06A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetE06A.Reconnect(true);
					OffsetE06A.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "E06B":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE06B.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetE06B.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetE06B.Reconnect(true);
					OffsetE06B.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "E07E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE07E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE07E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E080":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE080.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetE080.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E084":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE084.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)OffsetE084.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E088":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE088.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)OffsetE088.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E08C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE08C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)OffsetE08C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E090":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE090.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE090.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E092":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE092.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE092.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E094":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE094.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetE094.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E096":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE096.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetE096.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E0A5":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE0A5.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetE0A5.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "E0A6":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetE0A6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetE0A6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F000":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF000.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF000.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F002":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF002.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF002.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F004":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF004.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF004.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F006":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF006.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF006.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F008":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF008.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetF008.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F068":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF068.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetF068.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetF068.Reconnect(true);
					OffsetF068.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "F06A":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF06A.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetF06A.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				try
				{
					OffsetF06A.Reconnect(true);
					OffsetF06A.Value = Convert.ToByte(data);
					FSUIPCConnection.Process();
					result = "OK";
				}
				catch
				{
					result = "NOK";
				}
			}
			break;
		}
		case "F07E":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF07E.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF07E.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F080":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF080.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((int)OffsetF080.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F084":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF084.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)OffsetF084.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F088":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF088.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)OffsetF088.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F08C":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF08C.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((float)OffsetF08C.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F090":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF090.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF090.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F092":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF092.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF092.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F094":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF094.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((short)OffsetF094.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F096":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF096.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((string)OffsetF096.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F0A5":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF0A5.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((byte)OffsetF0A5.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
			{
				result = "NOK";
			}
			break;
		}
		case "F0A6":
		{
			if (mode == "READ")
			{
				try
				{
					OffsetF0A6.Reconnect(true);
					FSUIPCConnection.Process();
					result = Convert.ToString((ushort)OffsetF0A6.Value);
				}
				catch
				{
					result = "NOK";
				}
			}
			else if (mode == "WRITE")
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