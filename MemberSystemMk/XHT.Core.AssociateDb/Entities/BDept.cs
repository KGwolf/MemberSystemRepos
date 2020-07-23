using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class BDept
    {
        public string deptid { get; set; }
        public string deptname { get; set; }
        public string deptmanagerid { get; set; }
        public string deptdescription { get; set; }
        public string createrid { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public Nullable<System.DateTime> lastmodify { get; set; }
        public string compaid { get; set; }
        public string depttype { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> parentid { get; set; }
    }
}
