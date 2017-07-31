using DBServer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“DBSvr”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class DBSvr : IDBSvr
    {
        public void GetAllCtuInfo()
        {
            var info=SqlServerHandler.GetHandler.GetALLCtuInfo();
        }
    }
}
