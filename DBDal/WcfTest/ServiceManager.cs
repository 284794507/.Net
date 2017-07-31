using DBServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest
{
    public class ServiceManager:ServiceBase
    {
        private static object syncRoot = new object();//同步锁
        private static ServiceHost host = null;//寄宿服务对象

        public ServiceManager()
        {
            this.ServiceName = "WCFWindowsServiceSample";
        }

        protected override void OnStart(string[] args)
        {
            //base.OnStart(args);
            try
            {
                if (host != null)
                {
                    host.Close();
                }

                host = new ServiceHost(typeof(DBSvr));
                if(host.State!=CommunicationState.Opened)
                {
                    host.Open();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("启动成功！");
        }

        protected override void OnStop()
        {
            //base.OnStop();
            if(host !=null)
            {
                host.Close();
                host = null;
            }

            Console.WriteLine("停止成功！");
        }
    }
}
