using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class SysRedSet
    {
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public string IS_NULLABLE { get; set; }
        public string is_input { get; set; }
        public string flag { get; set; }
        public string column_comment { get; set; }
    }
}
