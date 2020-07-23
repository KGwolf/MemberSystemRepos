using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class BCat
    {
        public string catename { get; set; }
        public string cateid { get; set; }
        public string catelevel { get; set; }
        public string pym { get; set; }
        public string catetype { get; set; }
        public string parentlevle { get; set; }
        public string del { get; set; }
        public Nullable<decimal> catesum { get; set; }
        public string unit { get; set; }
        public string modifytype { get; set; }
    }
}
