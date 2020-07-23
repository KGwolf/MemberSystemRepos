using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TWelfareConfirmMap : EntityTypeConfiguration<TWelfareConfirm>
    {
        public TWelfareConfirmMap()
        {
            // Primary Key
            this.HasKey(t => new { t.wid, t.deptid });

            // Properties
            this.Property(t => t.wid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.deptid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.confirmid)
                .HasMaxLength(16);

            this.Property(t => t.confirmremark)
                .HasMaxLength(255);

            this.Property(t => t.remark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_welfare_confirm");
            this.Property(t => t.wid).HasColumnName("wid");
            this.Property(t => t.deptid).HasColumnName("deptid");
            this.Property(t => t.confirmid).HasColumnName("confirmid");
            this.Property(t => t.results).HasColumnName("results");
            this.Property(t => t.confirmremark).HasColumnName("confirmremark");
            this.Property(t => t.confirmtime).HasColumnName("confirmtime");
            this.Property(t => t.orderby).HasColumnName("orderby");
            this.Property(t => t.remark).HasColumnName("remark");
        }
    }
}
