using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeClient
{
    public class PipeClientHandler
    {
        private static PipeClientHandler _PipeClientHandler;
        public static PipeClientHandler GetHandler
        {
            get
            {
                if(_PipeClientHandler==null)
                {
                    _PipeClientHandler = new PipeClientHandler();
                }
                return _PipeClientHandler;
            }
        }

        int bufferLen = 1024;
        byte[] receviceBuffer = null;
        NamedPipeClientStream pipeToServer = null;

        public void ConnectPipe()
        {
            pipeToServer = new NamedPipeClientStream("127.0.0.1", "testPipe", PipeDirection.InOut, PipeOptions.Asynchronous, System.Security.Principal.TokenImpersonationLevel.Impersonation);
            pipeToServer.Connect();
            receviceBuffer = new byte[bufferLen];
            pipeToServer.BeginRead(receviceBuffer, 0, receviceBuffer.Length, PipeRecevice, receviceBuffer);
            byte[] sendData = new byte[0];
            string str = "I want to trap data with you by pipe";
            sendData = GetBytesFromString(str);
            pipeToServer.BeginWrite(sendData, 0, sendData.Length, PipeSend, sendData);
        }

        private void PipeRecevice(IAsyncResult ar)
        {
            int len = 0;
            try
            {
                len = pipeToServer.EndRead(ar);
            }
            catch
            {
                len = 0;
            }
            if (len == 0) return;
            byte[] data = (byte[])ar.AsyncState;
            byte[] realData = new byte[len];
            Buffer.BlockCopy(data, 0, realData, 0, len);
            for (int i = 0; i < realData.Length; i++)
            {
                Console.Write((char)realData[i]);
            }

            pipeToServer.BeginRead(receviceBuffer, 0, receviceBuffer.Length, PipeRecevice, receviceBuffer);
        }

        private void PipeSend(IAsyncResult ar)
        {

        }

        private byte[] GetBytesFromString(string data)
        {
            if (data.Length == 0) return new byte[0];

            char[] arr = data.ToCharArray();
            int len = arr.Length;
            byte[] result = new byte[len];
            //List<byte> listByte = new List<byte>();
            for(int i=0;i< len;i++)
            {
                result[i] = (byte)arr[i];
            }

            return result;
        }
    }
}
