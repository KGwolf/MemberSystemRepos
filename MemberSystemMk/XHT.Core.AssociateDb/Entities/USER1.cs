using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class User1
    {
        public string userid { get; set; }
        public string pwd { get; set; }
        public string name { get; set; }
        public string deptid { get; set; }
        public Nullable<int> fnid { get; set; }
        public Nullable<int> picid { get; set; }
        public string ipcode { get; set; }
        public Nullable<System.DateTime> logintime { get; set; }
        public string rightgroupid { get; set; }
        public string rightcode { get; set; }
        public string machinename { get; set; }
        public string postname { get; set; }
        public Nullable<decimal> vion { get; set; }
        public Nullable<int> STATE { get; set; }
        public string distributioncenter { get; set; }
        public string newpwd { get; set; }
        public string svrip { get; set; }
        public string orgid { get; set; }
    }
}
