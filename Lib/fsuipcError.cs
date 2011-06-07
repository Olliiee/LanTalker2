using FSUIPC;

namespace LanTalker2.Lib
{
    class fsuipcError
    {
        static string[] errorArray = { "Already connected to the Flight Simulator!", 
                                         "No Flight Simulator is running!", 
                                         "Failed to Register common message with Windows!",
                                     "Failed to create Atom for mapping filename!",
                                     "Failed to create a file mapping object!",
                                     "Failed to open a view to the file map",
                                     "Incorrect version of FSUIPC, or not FSUIPC",
                                     "Sim is not version requested",
                                     "Call cannot execute, link not Open",
                                     "Call cannot execute: no requests accumulated",
                                     "IPC timed out all retries",
                                     "IPC sendmessage failed all retries",
                                     "IPC request contains bad data",
                                     "Maybe running on WideClient, but FS not running on Server, or wrong FSUIPC"};

        public string errorMsg(FSUIPCException ex)
        {
            string result = "Unknown error";

            if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_OPEN)
            {
                result = errorArray[0];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_NOFS)
            {
                result = errorArray[1];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_REGMSG)
            {
                result = errorArray[2];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_ATOM)
            {
                result = errorArray[3];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_MAP)
            {
                result = errorArray[4];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_VIEW)
            {
                result = errorArray[5];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_VERSION)
            {
                result = errorArray[6];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_WRONGFS)
            {
                result = errorArray[7];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_NOTOPEN)
            {
                result = errorArray[8];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_NODATA)
            {
                result = errorArray[9];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_TIMEOUT)
            {
                result = errorArray[10];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_SENDMSG)
            {
                result = errorArray[11];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_DATA)
            {
                result = errorArray[12];
            }
            else if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_RUNNING)
            {
                result = errorArray[13];
            }
            

            return result;
        }
    }
}
