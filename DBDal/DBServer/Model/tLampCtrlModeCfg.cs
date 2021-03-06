using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampCtrlModeCfg
    {
        public int LampNo { get; set; } // int, not null

        public byte? LampCfgNo { get; set; } // tinyint, null

        public byte? LampOptMode { get; set; } // tinyint, null

        public byte? LampOptCtrlType { get; set; } // tinyint, null

        public byte? LampSwitchPos { get; set; } // tinyint, null

        public byte? LampOptRelTime { get; set; } // tinyint, null

        public string LampOptAbsTime { get; set; } // char(24), null
    }
}
