using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class Picture
    {
        public string ID { get; set; }
        public string pictype { get; set; }
        public string filename { get; set; }
        public string filepath { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string createid { get; set; }
    }
}
