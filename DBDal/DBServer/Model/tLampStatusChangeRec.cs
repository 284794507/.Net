using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampStatusChangeRec
    {
        public int LampNo { get; set; } // int, not null

        public int LampNewStatus { get; set; } // int, not null

        public DateTime CDateTime { get; set; } // datetime, not null

        public int LampOldStatus { get; set; } // int, not null

        public int LampOptStatus { get; set; } // int, not null

        public DateTime OptDTime { get; set; } // datetime, not null

        public byte OptBy { get; set; } // tinyint, not null

        public byte LockStatus { get; set; } // tinyint, not null

        public byte isUpLoaded { get; set; } // tinyint, not null

        public DateTime? UpLoadDTime { get; set; } // datetime, null
    }
}
