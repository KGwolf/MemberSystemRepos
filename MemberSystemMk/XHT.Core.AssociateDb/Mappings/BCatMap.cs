using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class BCatMap : EntityTypeConfiguration<BCat>
    {
        public BCatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cateid, t.catetype });

            // Properties
            this.Property(t => t.catename)
                .HasMaxLength(50);

            this.Property(t => t.cateid)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.catelevel)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.pym)
                .HasMaxLength(50);

            this.Property(t => t.catetype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.parentlevle)
                .HasMaxLength(50);

            this.Property(t => t.del)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.unit)
                .HasMaxLength(50);

            this.Property(t => t.modifytype)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("b_cate");
            this.Property(t => t.catename).HasColumnName("catename");
            this.Property(t => t.cateid).HasColumnName("cateid");
            this.Property(t => t.catelevel).HasColumnName("catelevel");
            this.Property(t => t.pym).HasColumnName("pym");
            this.Property(t => t.catetype).HasColumnName("catetype");
            this.Property(t => t.parentlevle).HasColumnName("parentlevle");
            this.Property(t => t.del).HasColumnName("del");
            this.Property(t => t.catesum).HasColumnName("catesum");
            this.Property(t => t.unit).HasColumnName("unit");
            this.Property(t => t.modifytype).HasColumnName("modifytype");
        }
    }
}
