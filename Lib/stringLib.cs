using System;
using System.Text;
using System.IO;

namespace LanTalker2.Lib
{
    class stringLib
    {
        /// <summary>
        /// Converts a string to a byte array
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>The byte array</returns>
        public byte[] StringToByteArray(string str)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetBytes(str);
        }

        /// <summary>
        /// Converts a byte array to a string
        /// </summary>
        /// <param name="arr">The byte array</param>
        /// <returns>The string</returns>
        public string ByteArrayToString(byte[] arr)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetString(arr);
        }

        /// <summary>
        /// This creates a debug file
        /// </summary>
        /// <param name="msg">The output message</param>
        /// <param name="consoleoutput">true: write to the console</param>
        /// <param name="debugmode">true: output the debug message</param>
        public void screamer(string msg, bool consoleoutput, bool debugmode)
        {
            if (debugmode == true)
            {
                Console.WriteLine(msg);
                string path = System.Threading.Thread.GetDomain().BaseDirectory;

                if (!File.Exists(@path + @"\debug.txt"))
                {
                    using (StreamWriter sr = new StreamWriter(@path + @"\debug.txt", true))
                    {
                        sr.Write("{0} {1}: {2}\r\n", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), msg);
                        sr.Flush();
                    }
                }
                else
                {
                    using (StreamWriter sr = new StreamWriter(@path + @"\debug.txt", true))
                    {
                        sr.Write("{0} {1}: {2}\r\n", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), msg);
                        sr.Flush();
                    }
                }
            }
            if (consoleoutput == true && debugmode == false)
                Console.WriteLine(msg);
        }
    }
}
