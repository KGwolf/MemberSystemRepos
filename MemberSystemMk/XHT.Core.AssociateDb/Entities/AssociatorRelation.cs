using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class AssociatorRelation
    {
        public Nullable<int> ID { get; set; }
        public int 会员卡号 { get; set; }
        public byte[] 亲属关系 { get; set; }
        public byte[] 亲属姓名 { get; set; }
        public byte[] 亲属性别 { get; set; }
        public Nullable<System.DateTime> 亲属生日 { get; set; }
        public byte[] 亲属单位 { get; set; }
        public byte[] 亲属身份证号 { get; set; }
        public byte[] 亲属学历 { get; set; }
        public byte[] 亲属住址 { get; set; }
        public byte[] 亲属收入 { get; set; }
        public byte[] 亲属社保 { get; set; }
        public byte[] 亲属住房 { get; set; }
        public byte[] 亲属电话 { get; set; }
    }
}
