using System;
using System.Collections.Generic;

namespace DBServer.Model
{
    public class tPTUChangeHis
    {
        public string OldPTUID { get; set; } // char(40), not null

        public string NewPTUID { get; set; } // char(40), not null

        public DateTime? ChangeDateTime { get; set; } // datetime, null

        public byte? ChangeStatus { get; set; } // tinyint, null
    }
}
