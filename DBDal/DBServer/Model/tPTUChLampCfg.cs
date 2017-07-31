using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tPTUChLampCfg
    {
        public int PTUNo { get; set; } // int, not null

        public byte PTUChNo { get; set; } // tinyint, not null

        public int LampNo { get; set; } // int, not null

        public DateTime? RecDateTime { get; set; } // datetime, null
    }
}
