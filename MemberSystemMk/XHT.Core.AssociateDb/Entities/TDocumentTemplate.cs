using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class TDocumentTemplate
    {
        public string ID { get; set; }
        public string TemplateChName { get; set; }
        public string TemplateEnName { get; set; }
        public string TemplateHtml { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    }
}
