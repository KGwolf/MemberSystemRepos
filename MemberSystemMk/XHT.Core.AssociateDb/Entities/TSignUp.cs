using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TSignUp
    {
        public int signupID { get; set; }
        public Nullable<int> createid { get; set; }
        public string signupname { get; set; }
        public string assdeptid { get; set; }
        public Nullable<System.DateTime> starttime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public Nullable<int> confirmid { get; set; }
        public string note { get; set; }
        public Nullable<int> pcount { get; set; }
        public Nullable<int> signupdeptid { get; set; }
    }
}
