using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampWeekCtrlCfg
    {
        public byte CmdType { get; set; } // tinyint, not null

        public int GrpNo { get; set; } // int, not null

        public byte? TimeType { get; set; } // tinyint, null

        public string OptTime { get; set; } // varchar(8), null

        public byte? OptType { get; set; } // tinyint, null

        public int? LampOrGrpNo { get; set; } // int, null

        public int? OptValue { get; set; } // int, null

        public byte? CtrlStatus { get; set; } // tinyint, null

        public DateTime? OptDateTime { get; set; } // datetime, null
    }
}
