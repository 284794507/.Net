using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampStatus
    {
        public int LampNo { get; set; } // int, not null

        public byte? LampStatus { get; set; } // tinyint, null

        public byte? LampRunStatus { get; set; } // tinyint, null

        public long? LampVolt { get; set; } // bigint, null
    }
}
