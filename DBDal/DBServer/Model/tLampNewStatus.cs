using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampNewStatus
    {
        public int LampNo { get; set; } // int, not null

        public byte LampStatus { get; set; } // tinyint, not null

        public DateTime CDateTime { get; set; } // datetime, not null

        public byte? OptStatus { get; set; } // tinyint, null

        public DateTime? OptDTime { get; set; } // datetime, null

        public byte? OptBy { get; set; } // tinyint, null

        public byte? LockStatus { get; set; } // tinyint, null

        public byte? LampInsAlarm { get; set; } // tinyint, null
    }
}
