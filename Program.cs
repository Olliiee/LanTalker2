using System;

namespace LanTalker2
{
    class Program
    {
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
