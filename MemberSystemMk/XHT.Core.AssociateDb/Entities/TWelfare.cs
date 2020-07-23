using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TWelfare
    {
        public string wid { get; set; }
        public string cateID { get; set; }
        public string createid { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string reason { get; set; }
        public string state { get; set; }
        public string handedoutID { get; set; }
        public Nullable<System.DateTime> handedouttime { get; set; }
        public Nullable<int> createassid { get; set; }
    }
}
