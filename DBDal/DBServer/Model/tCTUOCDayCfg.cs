using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tCTUOCDayCfg
    {
        public byte TMonth { get; set; } // tinyint, not null

        public byte Tday { get; set; } // tinyint, not null

        public string OpenTime { get; set; } // char(10), not null

        public string CloseTime { get; set; } // char(10), not null
    }
}
