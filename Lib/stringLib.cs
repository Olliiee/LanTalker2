using System;
using System.Text;
using System.IO;

namespace LanTalker2.Lib
{
    class stringLib
    {
        public byte[] StringToByteArray(string str)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetBytes(str);
        }

        public string ByteArrayToString(byte[] arr)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetString(arr);
        }

        public string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('|');
            }
            return builder.ToString();
        }

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
