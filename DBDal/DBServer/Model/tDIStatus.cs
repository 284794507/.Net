using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tDIStatus
    {
        public int DINo { get; set; } // int, not null

        public byte? DIValue { get; set; } // tinyint, null
    }
}
