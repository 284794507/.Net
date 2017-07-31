using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class TPLCollectorInfo
    {
        public TPLCollectorInfo()
        {
            this.ObjID = Guid.NewGuid();
            this.TheDate = DateTime.Now;
            this.DevStatus = 0;
            this.ValidStatus = 0;
            this.UpdateTime = DateTime.Now;
            this.Status = 1;
        }

        public Guid ObjID { get; set; } // uniqueidentifier, not null

        public DateTime TheDate { get; set; } // datetime, not null

        public string MacAddr { get; set; } // varchar(30), not null

        public string HVer { get; set; } // varchar(10), not null

        public string SVer { get; set; } // varchar(10), not null

        public Guid TPlatFormID { get; set; } // uniqueidentifier, not null

        public string TPlatFormCode { get; set; } // varchar(30), not null

        public byte DevType { get; set; } // tinyint, not null

        public byte DevStatus { get; set; } // tinyint, not null

        public byte ValidStatus { get; set; } // tinyint, not null

        public string APhase { get; set; } // varchar(5), not null

        public string BPhase { get; set; } // varchar(5), not null

        public string CPhase { get; set; } // varchar(5), not null

        public DateTime? UpdateTime { get; set; } // datetime, null

        public byte Status { get; set; } // tinyint, not null

        public string Memo { get; set; } // varchar(50), null
    }
}
