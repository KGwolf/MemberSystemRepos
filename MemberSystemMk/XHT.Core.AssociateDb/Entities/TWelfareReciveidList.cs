using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TWelfareReciveidList
    {
        public string wid { get; set; }
        public string associatorid { get; set; }
        public string receiveid { get; set; }
        public Nullable<System.DateTime> receivetime { get; set; }
        public string receiveplact { get; set; }
    }
}
