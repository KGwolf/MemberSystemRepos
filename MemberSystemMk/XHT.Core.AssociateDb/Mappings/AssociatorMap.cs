using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;

namespace XHT.Core.AssociateDb.Mappings
{
    public class AssociatorMap : EntityTypeConfiguration<Associator>
    {
        public AssociatorMap()
        {
            // Primary Key
            this.HasKey(t => t.associatorid);

            // Properties
            //this.Property(t => t.associatorid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(20);

            this.Property(t => t.address)
                .HasMaxLength(50);

            this.Property(t => t.company)
                .HasMaxLength(50);

            this.Property(t => t.telphone)
                .HasMaxLength(50);

            this.Property(t => t.type)
                .HasMaxLength(50);

            this.Property(t => t.remark)
                .HasMaxLength(50);

            this.Property(t => t.sex)
                .HasMaxLength(2);

            this.Property(t => t.cate)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EMAIL)
                .HasMaxLength(80);

            this.Property(t => t.identitycode)
                .HasMaxLength(50);

            this.Property(t => t.PYM)
                .HasMaxLength(50);

            this.Property(t => t.tradeunionid)
                .HasMaxLength(50);

            this.Property(t => t.cateid)
                .HasMaxLength(8);

            this.Property(t => t.auditid)
                .HasMaxLength(16);

            this.Property(t => t.educationid)
                .HasMaxLength(8);

            this.Property(t => t.faith)
                .HasMaxLength(50);

            this.Property(t => t.nativeplace)
                .HasMaxLength(50);

            this.Property(t => t.nationality)
                .HasMaxLength(8);

            this.Property(t => t.positions)
                .HasMaxLength(50);

            this.Property(t => t.professional)
                .HasMaxLength(50);

            this.Property(t => t.deptid)
                .HasMaxLength(50);

            this.Property(t => t.password)
                .HasMaxLength(50);

            this.Property(t => t.confirmid)
                .HasMaxLength(8);

            this.Property(t => t.assdeptid)
                .HasMaxLength(50);

            this.Property(t => t.assarea)
                .HasMaxLength(50);

            this.Property(t => t.relationtype)
                .HasMaxLength(50);

            this.Property(t => t.marriagestate)
                .HasMaxLength(50);

            this.Property(t => t.skilllevel)
                .HasMaxLength(255);

            this.Property(t => t.certtype)
                .HasMaxLength(50);

            this.Property(t => t.workstate)
                .HasMaxLength(50);

            this.Property(t => t.isbz)
                .HasMaxLength(50);

            this.Property(t => t.isnm)
                .HasMaxLength(50);

            this.Property(t => t.isknzg)
                .HasMaxLength(50);

            this.Property(t => t.registertype)
                .HasMaxLength(50);

            this.Property(t => t.changetype)
                .HasMaxLength(50);

            this.Property(t => t.changethings)
                .HasMaxLength(50);

            this.Property(t => t.degree)
                .HasMaxLength(50);

            this.Property(t => t.nameed)
                .HasMaxLength(100);

            this.Property(t => t.othercert)
                .HasMaxLength(50);

            this.Property(t => t.othercertcode)
                .HasMaxLength(255);

            this.Property(t => t.nationality_country)
                .HasMaxLength(255);

            this.Property(t => t.relationtelphone)
                .HasMaxLength(50);

            this.Property(t => t.healthstate)
                .HasMaxLength(50);

            this.Property(t => t.deformity)
                .HasMaxLength(50);

            this.Property(t => t.diseaseremrak)
                .HasMaxLength(500);

            this.Property(t => t.isnmg)
                .HasMaxLength(50);

            this.Property(t => t.speciality)
                .HasMaxLength(255);

            this.Property(t => t.skillbook)
                .HasMaxLength(255);

            this.Property(t => t.account)
                .HasMaxLength(50);

            this.Property(t => t.bank)
                .HasMaxLength(50);

            this.Property(t => t.bankcard)
                .HasMaxLength(50);

            this.Property(t => t.vipcard)
                .HasMaxLength(50);

            this.Property(t => t.sicode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ASSOCIATOR");
            this.Property(t => t.associatorid).HasColumnName("associatorid");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.company).HasColumnName("company");
            this.Property(t => t.telphone).HasColumnName("telphone");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.jointime).HasColumnName("jointime");
            this.Property(t => t.birdthday).HasColumnName("birdthday");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.modifytime).HasColumnName("modifytime");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.cate).HasColumnName("cate");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.identitycode).HasColumnName("identitycode");
            this.Property(t => t.PYM).HasColumnName("PYM");
            this.Property(t => t.tradeunionid).HasColumnName("tradeunionid");
            this.Property(t => t.relationid).HasColumnName("relationid");
            this.Property(t => t.cateid).HasColumnName("cateid");
            this.Property(t => t.auditid).HasColumnName("auditid");
            this.Property(t => t.audittime).HasColumnName("audittime");
            this.Property(t => t.educationid).HasColumnName("educationid");
            this.Property(t => t.faith).HasColumnName("faith");
            this.Property(t => t.nativeplace).HasColumnName("nativeplace");
            this.Property(t => t.nationality).HasColumnName("nationality");
            this.Property(t => t.positions).HasColumnName("positions");
            this.Property(t => t.professional).HasColumnName("professional");
            this.Property(t => t.CV).HasColumnName("CV");
            this.Property(t => t.deptid).HasColumnName("deptid");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.confirmid).HasColumnName("confirmid");
            this.Property(t => t.changedpwd).HasColumnName("changedpwd");
            this.Property(t => t.assdeptid).HasColumnName("assdeptid");
            this.Property(t => t.assarea).HasColumnName("assarea");
            this.Property(t => t.relationtype).HasColumnName("relationtype");
            this.Property(t => t.marriagestate).HasColumnName("marriagestate");
            this.Property(t => t.skilllevel).HasColumnName("skilllevel");
            this.Property(t => t.certtype).HasColumnName("certtype");
            this.Property(t => t.workstate).HasColumnName("workstate");
            this.Property(t => t.isbz).HasColumnName("isbz");
            this.Property(t => t.isnm).HasColumnName("isnm");
            this.Property(t => t.isknzg).HasColumnName("isknzg");
            this.Property(t => t.registertype).HasColumnName("registertype");
            this.Property(t => t.changetype).HasColumnName("changetype");
            this.Property(t => t.changedate).HasColumnName("changedate");
            this.Property(t => t.changethings).HasColumnName("changethings");
            this.Property(t => t.degree).HasColumnName("degree");
            this.Property(t => t.nameed).HasColumnName("nameed");
            this.Property(t => t.certenddate).HasColumnName("certenddate");
            this.Property(t => t.othercert).HasColumnName("othercert");
            this.Property(t => t.othercertcode).HasColumnName("othercertcode");
            this.Property(t => t.nationality_country).HasColumnName("nationality_country");
            this.Property(t => t.relationtelphone).HasColumnName("relationtelphone");
            this.Property(t => t.healthstate).HasColumnName("healthstate");
            this.Property(t => t.deformity).HasColumnName("deformity");
            this.Property(t => t.diseaseremrak).HasColumnName("diseaseremrak");
            this.Property(t => t.isnmg).HasColumnName("isnmg");
            this.Property(t => t.speciality).HasColumnName("speciality");
            this.Property(t => t.skillbook).HasColumnName("skillbook");
            this.Property(t => t.account).HasColumnName("account");
            this.Property(t => t.bank).HasColumnName("bank");
            this.Property(t => t.bankcard).HasColumnName("bankcard");
            this.Property(t => t.jobpay).HasColumnName("jobpay");
            this.Property(t => t.vipcard).HasColumnName("vipcard");
            this.Property(t => t.sendvipcardtime).HasColumnName("sendvipcardtime");
            this.Property(t => t.sendvipcardcount).HasColumnName("sendvipcardcount");
            this.Property(t => t.sicode).HasColumnName("sicode");
        }
    }
}
