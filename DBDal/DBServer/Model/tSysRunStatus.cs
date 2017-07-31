using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tSysRunStatus
    {
        public DateTime? StartTime { get; set; } // datetime, null

        public byte? PLCSatus { get; set; } // tinyint, null

        public byte? SvrStatus { get; set; } // tinyint, null

        public int? GPRSCSQ { get; set; } // int, null

        public int? GPRSTryConnTimes { get; set; } // int, null

        public int? MainVer { get; set; } // int, null

        public int? SubVer { get; set; } // int, null

        public DateTime? UpdateTime { get; set; } // datetime, null

        public DateTime? EmgyCtrlEndTime { get; set; } // datetime, null

        public int? EmgyCtrlMask { get; set; } // int, null

        public int? EmgyCtrlVal { get; set; } // int, null
    }
}
