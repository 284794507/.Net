using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AspectFDemo
{
    public class Person
    {
        public string Name { get; set; }

        public string Age { get; set; }
        
        public Action<string> WriterLog { get; set; }

        public void Walk()
        {
            Console.WriteLine(this.Name + "Can walk!");
        }

        public void Run()
        {
            int i = 0;
            Dictionary<string, string> dictTmp = null;
            AspectF.Define.Log(this.WriterLog, "开始跑步......", "跑步结束。")
                .Retry((Exception ex)=>
                {
                    Console.WriteLine(ex.Message);
                    i = 2;
                })
                .MustBeNonNull(dictTmp)
                .Do(() =>
                {
                    Console.WriteLine(this.Name + "is running!");
                    Thread.Sleep(1000);
                    int[] arr = new int[0];
                    //arr[0]= 1;
                    //arr[1]= 2;
                });

            Console.WriteLine(i);
        }
    }
}
