using System;
using System.Collections.Generic;
using System.Linq;
using System.Logger;
using System.Text;
using System.Threading.Tasks;

namespace AspectFDemo
{
    class Program
    {
        static SimpleLogger LFI_Log = SimpleLogger.GetInstance();

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            SimpleLogger log= SimpleLogger.GetInstance();
            log.Info("1231");
            p.WriterLog = WriterLog;
            p.Walk();
            p.Run();

            Console.ReadLine();
        }

        public static void WriterLog(string msg)
        {
            LFI_Log.Info(msg);
            Console.WriteLine(msg);
        }
    }
}
