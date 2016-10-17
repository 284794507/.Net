using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常捕获
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            PipeServerHandler.GetHandler.InitPipe();

            Console.ReadLine();
        }

        /// <summary>
        /// 顶级异常的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception error = (Exception)e.ExceptionObject;

            Console.WriteLine(DateTime.Now + " : " + error.Message);
        }
    }
}
