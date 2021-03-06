using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tCTUPowerSaveCfg
    {
        public int CfgNo { get; set; } // int, not null

        public byte OptValue { get; set; } // tinyint, not null

        public byte OptType { get; set; } // tinyint, not null

        public string OptTime { get; set; } // char(8), null

        public string Memo { get; set; } // char(200), null
    }
}
