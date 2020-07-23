using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TWelfareListMap : EntityTypeConfiguration<TWelfareList>
    {
        public TWelfareListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wid, t.cateid });

            // Properties
            this.Property(t => t.wid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cateid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.remark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_welfare_list");
            this.Property(t => t.wid).HasColumnName("wid");
            this.Property(t => t.cateid).HasColumnName("cateid");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.catesum).HasColumnName("catesum");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
