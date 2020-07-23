using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class DoLogs
    {
        public int logid { get; set; }
        public string doid { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> dotime { get; set; }
        public string menuname { get; set; }
        public string newvalue { get; set; }
        public string oldvalue { get; set; }
    }
}
