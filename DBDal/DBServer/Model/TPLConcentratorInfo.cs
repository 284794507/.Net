using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class TPLConcentratorInfo
    {
        public TPLConcentratorInfo()
        {
            this.ObjID = Guid.NewGuid();
            this.TheDate = DateTime.Now;
            this.UpdateTime = DateTime.Now;
            this.Status = 1;
        }

        public Guid ObjID { get; set; } // uniqueidentifier, not null

        public DateTime TheDate { get; set; } // datetime, not null

        public Guid PLCollectorInfoID { get; set; } // uniqueidentifier, not null

        public string MacAddr { get; set; } // varchar(30), not null

        public string CommAddr { get; set; } // varchar(30), not null

        public string Name { get; set; } // varchar(30), not null

        public decimal Lon { get; set; } // decimal(9,6), not null

        public decimal LAT { get; set; } // decimal(8,6), not null

        public DateTime? UpdateTime { get; set; } // datetime, null

        public byte Status { get; set; } // tinyint, not null

        public string Memo { get; set; } // varchar(50), null
    }
}
