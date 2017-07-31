using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tDICfg
    {
        public int DINo { get; set; } // int, not null

        public byte? DIType { get; set; } // tinyint, null

        public byte? DIChNumFlag { get; set; } // tinyint, null

        public byte? DIPhase { get; set; } // tinyint, null
    }
}
