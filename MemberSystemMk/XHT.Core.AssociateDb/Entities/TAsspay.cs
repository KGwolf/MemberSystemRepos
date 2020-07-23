using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TAsspay
    {
        public int associatorid { get; set; }
        public string paytype { get; set; }
        public decimal paymoney { get; set; }
        public string paydate { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string createid { get; set; }
    }
}
