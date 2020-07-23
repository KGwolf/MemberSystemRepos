using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TWelfareList
    {
        public string wid { get; set; }
        public string cateid { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> catesum { get; set; }
        public string remark { get; set; }
    }
}
