using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class TPLMacWithNum
    {
        public TPLMacWithNum()
        {
            this.ObjID = Guid.NewGuid();
            this.TheDate = DateTime.Now;
            this.Status = 1;
        }

        public Guid ObjID { get; set; } // uniqueidentifier, not null

        public DateTime TheDate { get; set; } // datetime, not null

        public string MacAddr { get; set; } // varchar(30), not null

        public int Num { get; set; } // int, not null

        public Guid TPlatFormID { get; set; } // uniqueidentifier, not null

        public byte Status { get; set; } // tinyint, not null

        public string Memo { get; set; } // varchar(50), null
    }
}
