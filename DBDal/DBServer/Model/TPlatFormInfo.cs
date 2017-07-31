using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class TPlatFormInfo
    {
        public TPlatFormInfo()
        {
            this.ObjID = Guid.NewGuid();
            this.TheDate = DateTime.Now;
            this.UpdateTime = DateTime.Now;
            this.Status = 1;
        }

        public Guid ObjID { get; set; } // uniqueidentifier, not null

        public DateTime TheDate { get; set; } // datetime, not null

        public string CountryCode { get; set; } // varchar(10), not null

        public string CityCode { get; set; } // varchar(10), not null

        public string PlatFormCode { get; set; } // varchar(30), not null

        public string PlatFormName { get; set; } // varchar(30), not null

        public DateTime? UpdateTime { get; set; } // datetime, null

        public byte Status { get; set; } // tinyint, not null

        public string Memo { get; set; } // varchar(50), null
    }
}
