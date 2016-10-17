using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeServer
{
    public class PipeServerHandler
    {
        private static PipeServerHandler _PipeServer;
        public static PipeServerHandler GetHandler
        {
            get
            {
                if(_PipeServer==null)
                {
                    _PipeServer = new PipeServerHandler();
                }
                return _PipeServer;
            }
        }

        int bufferLen = 1024;
        byte[] receviceBuffer = null;
        NamedPipeServerStream pipeToClient = null;

        public void InitPipe()
        {
            try
            {
                pipeToClient = new NamedPipeServerStream("testPipe", PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous, bufferLen, bufferLen);

                pipeToClient.WaitForConnection();//wait for a client to connect
                receviceBuffer = new byte[bufferLen];
                Console.WriteLine("Pipe connected");
                pipeToClient.BeginRead(receviceBuffer, 0, receviceBuffer.Length, PipeRecevice, receviceBuffer);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void PipeRecevice(IAsyncResult ar)
        {
            int len = 0;
            try
            {
                len = pipeToClient.EndRead(ar);
            }
            catch
            {
                len = 0;
            }
            if (len == 0) return;
            byte[] data = (byte[])ar.AsyncState;
            byte[] realData = new byte[len];
            Buffer.BlockCopy(data, 0, realData, 0, len);
            for (int i=0;i< realData.Length;i++)
            {
                Console.Write((char)realData[i]);
            }
            byte[] sendData = new byte[0];
            string str = "OK,We can  trap data by pipe Now";
            sendData = GetBytesFromString(str);
            pipeToClient.BeginWrite(sendData, 0, sendData.Length, PipeSend, sendData);
            pipeToClient.BeginRead(receviceBuffer, 0, receviceBuffer.Length, PipeRecevice, receviceBuffer);
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
            for (int i = 0; i < len; i++)
            {
                result[i] = (byte)arr[i];
            }

            return result;
        }
    }
}
