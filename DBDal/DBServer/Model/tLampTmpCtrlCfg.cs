using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampTmpCtrlCfg
    {
        public int CfgNo { get; set; } // int, not null

        public DateTime PlanOptDateTime { get; set; } // datetime, not null

        public byte OptType { get; set; } // tinyint, not null

        public int LampObjNo { get; set; } // int, not null

        public byte OptValue { get; set; } // tinyint, not null

        public byte? CtrlStatus { get; set; } // tinyint, null

        public DateTime? OptDateTime { get; set; } // datetime, null

        public string Memo { get; set; } // nvarchar(200), null
    }
}
