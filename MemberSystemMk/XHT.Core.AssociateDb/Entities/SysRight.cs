using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class SysRight
    {
        public string right_group { get; set; }
        public string menu_id { get; set; }
        public string menu_tag { get; set; }
        public string menu_parenttext { get; set; }
        public string menu_classname { get; set; }
        public string menu_currenttext { get; set; }
        public string menu_num { get; set; }
        public Nullable<int> menu_handle { get; set; }
        public string parentid { get; set; }
        public string controllername { get; set; }
        public string actionname { get; set; }
    }
}
