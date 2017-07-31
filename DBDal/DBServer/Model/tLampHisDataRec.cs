using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tLampHisDataRec
    {
        public int LampDataRecNo { get; set; } // int, not null

        public int LampNo { get; set; } // int, not null

        public double LampU { get; set; } // float, not null

        public double LampI { get; set; } // float, not null

        public double LampAP { get; set; } // float, not null

        public double LampVP { get; set; } // float, not null

        public double LampPF { get; set; } // float, not null

        public byte? LampStatus { get; set; } // tinyint, null

        public DateTime GetDateTime { get; set; } // datetime, not null

        public byte CommValue { get; set; } // tinyint, not null

        public byte? isUpLoaded { get; set; } // tinyint, null

        public DateTime? UpLoadDTime { get; set; } // datetime, null

        public string Memo { get; set; } // nvarchar(200), null
    }
}
