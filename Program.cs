using System;

namespace LanTalker2
{
    class Program
    {
        /// <summary>
        /// Starting the main application
        /// </summary>
        /// <param name="args">To debug or not to debug
        /// Create a link an add a "-debug" parameter to start the debug mode</param>
        static void Main(string[] args)
        {
            Server server = new Server();
            if (args.Length > 0)
            {
                if (args[0].Contains("debug") == true)
                    server.startServer(true);
                else
                    server.startServer(false);
            }
            else
                server.startServer(false);
        }
    }
}
