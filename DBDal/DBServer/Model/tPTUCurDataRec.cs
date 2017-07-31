using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tPTUCurDataRec
    {
        public int PTUNo { get; set; } // int, not null

        public byte PTUChNo { get; set; } // tinyint, not null

        public int? LampNo { get; set; } // int, null

        public double LampU { get; set; } // float, not null

        public double LampI { get; set; } // float, not null

        public double LampAP { get; set; } // float, not null

        public double LampVP { get; set; } // float, not null

        public double LampPF { get; set; } // float, not null

        public byte? OptStatus { get; set; } // tinyint, null

        public byte? LampStatus { get; set; } // tinyint, null

        public byte? LampStatus2 { get; set; } // tinyint, null

        public byte? OptBy { get; set; } // tinyint, null

        public byte? CommValue { get; set; } // tinyint, null

        public DateTime GetDateTime { get; set; } // datetime, not null

        public string Memo { get; set; } // nvarchar(200), null
    }
}
