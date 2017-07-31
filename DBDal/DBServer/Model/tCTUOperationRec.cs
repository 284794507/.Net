using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tCTUOperationRec
    {
        public int? RecNo { get; set; } // int, null

        public byte? OperType { get; set; } // tinyint, null

        public string OperVal { get; set; } // char(12), null

        public DateTime? OperTime { get; set; } // datetime, null
    }
}
