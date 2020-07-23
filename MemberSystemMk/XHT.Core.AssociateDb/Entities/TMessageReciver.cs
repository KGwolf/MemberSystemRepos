using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TMessageReciver
    {
        public int messageid { get; set; }
        public int receiveid { get; set; }
        public Nullable<System.DateTime> readdatetime { get; set; }
    }
}
