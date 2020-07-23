using System;
using System.Collections.Generic;

namespace XHT.Core.AssociateDb.Entities
{
    public partial class Associator
    {
        public int associatorid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string company { get; set; }
        public string telphone { get; set; }
        public string type { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<System.DateTime> jointime { get; set; }
        public Nullable<System.DateTime> birdthday { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> modifytime { get; set; }
        public string sex { get; set; }
        public string cate { get; set; }
        public string EMAIL { get; set; }
        public string identitycode { get; set; }
        public string PYM { get; set; }
        public string tradeunionid { get; set; }
        public Nullable<int> relationid { get; set; }
        public string cateid { get; set; }
        public string auditid { get; set; }
        public Nullable<System.DateTime> audittime { get; set; }
        public string educationid { get; set; }
        public string faith { get; set; }
        public string nativeplace { get; set; }
        public string nationality { get; set; }
        public string positions { get; set; }
        public string professional { get; set; }
        public string CV { get; set; }
        public string deptid { get; set; }
        public string password { get; set; }
        public string confirmid { get; set; }
        public Nullable<int> changedpwd { get; set; }
        public string assdeptid { get; set; }
        public string assarea { get; set; }
        public string relationtype { get; set; }
        public string marriagestate { get; set; }
        public string skilllevel { get; set; }
        public string certtype { get; set; }
        public string workstate { get; set; }
        public string isbz { get; set; }
        public string isnm { get; set; }
        public string isknzg { get; set; }
        public string registertype { get; set; }
        public string changetype { get; set; }
        public Nullable<System.DateTime> changedate { get; set; }
        public string changethings { get; set; }
        public string degree { get; set; }
        public string nameed { get; set; }
        public Nullable<System.DateTime> certenddate { get; set; }
        public string othercert { get; set; }
        public string othercertcode { get; set; }
        public string nationality_country { get; set; }
        public string relationtelphone { get; set; }
        public string healthstate { get; set; }
        public string deformity { get; set; }
        public string diseaseremrak { get; set; }
        public string isnmg { get; set; }
        public string speciality { get; set; }
        public string skillbook { get; set; }
        public string account { get; set; }
        public string bank { get; set; }
        public string bankcard { get; set; }
        public Nullable<decimal> jobpay { get; set; }
        public string vipcard { get; set; }
        public Nullable<System.DateTime> sendvipcardtime { get; set; }
        public Nullable<int> sendvipcardcount { get; set; }
        public string sicode { get; set; }
    }
}
