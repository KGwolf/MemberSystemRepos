using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TWelfareConfirm
    {
        public string wid { get; set; }
        public string deptid { get; set; }
        public string confirmid { get; set; }
        public Nullable<int> results { get; set; }
        public string confirmremark { get; set; }
        public Nullable<System.DateTime> confirmtime { get; set; }
        public int orderby { get; set; }
        public string remark { get; set; }
    }
}
