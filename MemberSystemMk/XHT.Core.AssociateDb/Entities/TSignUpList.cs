using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TSignUpList
    {
        public int signupID { get; set; }
        public int assid { get; set; }
        public Nullable<System.DateTime> signuptime { get; set; }
        public Nullable<int> signupstate { get; set; }
        public string assdeptid { get; set; }
    }
}
