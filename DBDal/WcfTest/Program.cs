using DBServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Install;

namespace WcfTest
{
    public class Program
    {
        private static string ServiceName = "WCFWindowsServiceSample";
        static void Main(string[] args)
        {
            ServiceController service = new ServiceController(ServiceName);

            if(args.Length==0)
            {
                //运行服务
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] { new ServiceManager() };
                ServiceBase.Run(ServicesToRun);
            }
            else if(args[0].ToLower()=="/i" || args[0].ToLower() == "-i")
            {
                //安装服务
                try
                {
                    string[] cmdLine = { };
                    string serviceFileName = System.Reflection.Assembly.GetExecutingAssembly().Location;

                    TransactedInstaller transactedInstaller = new TransactedInstaller();
                    AssemblyInstaller assemblyInstaller = new AssemblyInstaller(serviceFileName, cmdLine);
                    transactedInstaller.Installers.Add(assemblyInstaller);
                    transactedInstaller.Install(new System.Collections.Hashtable());

                    TimeSpan ts = TimeSpan.FromMilliseconds(1000 * 10);
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, ts);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if(args[0].ToLower()=="/u" || args[0].ToLower() == "-u")
            {
                try
                {
                    string[] cmdline = { };
                    string serviceFileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    TransactedInstaller transactedInstaller = new TransactedInstaller();
                    AssemblyInstaller assemblyInstaller = new AssemblyInstaller(serviceFileName, cmdline);
                    transactedInstaller.Installers.Add(assemblyInstaller);
                    transactedInstaller.Uninstall(null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //using (ServiceHost host = new ServiceHost(typeof(DBSvr)))
            //{
            //    host.Open();

                //    Console.WriteLine("WCF启动成功！");
                //    Console.ReadLine();
                //}
        }
    }
}
