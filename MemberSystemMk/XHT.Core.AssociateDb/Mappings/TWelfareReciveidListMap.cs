using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TWelfareReciveidListMap : EntityTypeConfiguration<TWelfareReciveidList>
    {
        public TWelfareReciveidListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wid, t.associatorid });

            // Properties
            this.Property(t => t.wid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.associatorid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.receiveid)
                .HasMaxLength(50);

            this.Property(t => t.receiveplact)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_welfare_receiveidlist");
            this.Property(t => t.wid).HasColumnName("wid");
            this.Property(t => t.associatorid).HasColumnName("associatorid");
            this.Property(t => t.receiveid).HasColumnName("receiveid");
            this.Property(t => t.receivetime).HasColumnName("receivetime");
            this.Property(t => t.receiveplact).HasColumnName("receiveplact");
        }
    }
}
