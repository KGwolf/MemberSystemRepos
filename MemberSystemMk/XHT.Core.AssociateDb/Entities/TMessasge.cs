using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TMessasge
    {
        public int messageid { get; set; }
        public string messagetext { get; set; }
        public Nullable<System.DateTime> senddatetime { get; set; }
        public string createid { get; set; }
    }
}
