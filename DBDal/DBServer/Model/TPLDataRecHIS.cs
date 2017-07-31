using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class TPLDataRecHIS
    {
        public TPLDataRecHIS()
        {
            this.ObjID = Guid.NewGuid();
            this.TheDate = DateTime.Now;
            this.GetDataTime = DateTime.Now;
            this.UpdateTime = DateTime.Now;
            this.Status = 1;
        }

        public Guid ObjID { get; set; } // uniqueidentifier, not null

        public DateTime TheDate { get; set; } // datetime, not null

        public Guid DevID { get; set; } // uniqueidentifier, not null

        public decimal LampVoltageA { get; set; } // decimal(7,2), not null

        public decimal LampCurrentA { get; set; } // decimal(7,2), not null

        public decimal LampActivePowerA { get; set; } // decimal(7,2), not null

        public decimal LampPowerFactA { get; set; } // decimal(7,2), not null

        public decimal LampVoltageB { get; set; } // decimal(7,2), not null

        public decimal LampCurrentB { get; set; } // decimal(7,2), not null

        public decimal LampActivePowerB { get; set; } // decimal(7,2), not null

        public decimal LampPowerFactB { get; set; } // decimal(7,2), not null

        public decimal LampVoltageC { get; set; } // decimal(7,2), not null

        public decimal LampCurrentC { get; set; } // decimal(7,2), not null

        public decimal LampActivePowerC { get; set; } // decimal(7,2), not null

        public decimal LampPowerFactC { get; set; } // decimal(7,2), not null

        public DateTime GetDataTime { get; set; } // datetime, not null

        public DateTime UpdateTime { get; set; } // datetime, not null

        public byte Status { get; set; } // tinyint, not null

        public string Memo { get; set; } // varchar(50), null
    }
}
