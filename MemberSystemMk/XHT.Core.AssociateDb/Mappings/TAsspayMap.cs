using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TAsspayMap : EntityTypeConfiguration<TAsspay>
    {
        public TAsspayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.associatorid, t.paytype, t.paymoney });

            // Properties
            //this.Property(t => t.associatorid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.paytype)
                .IsRequired()
                .HasMaxLength(50);

            //this.Property(t => t.paymoney)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.paydate)
                .HasMaxLength(6);

            this.Property(t => t.createid)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("t_asspay");
            this.Property(t => t.associatorid).HasColumnName("associatorid");
            this.Property(t => t.paytype).HasColumnName("paytype");
            this.Property(t => t.paymoney).HasColumnName("paymoney");
            this.Property(t => t.paydate).HasColumnName("paydate");
            this.Property(t => t.createtime).HasColumnName("createtime");
            this.Property(t => t.createid).HasColumnName("createid");
        }
    }
}
