using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TWelfareMap : EntityTypeConfiguration<TWelfare>
    {
        public TWelfareMap()
        {
            // Primary Key
            this.HasKey(t => t.wid);

            // Properties
            this.Property(t => t.wid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.cateID)
                .HasMaxLength(8);

            this.Property(t => t.createid)
                .HasMaxLength(16);

            this.Property(t => t.state)
                .HasMaxLength(50);

            this.Property(t => t.handedoutID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_welfare");
            this.Property(t => t.wid).HasColumnName("wid");
            this.Property(t => t.cateID).HasColumnName("cateID");
            this.Property(t => t.createid).HasColumnName("createid");
            this.Property(t => t.createtime).HasColumnName("createtime");
            this.Property(t => t.reason).HasColumnName("reason");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.handedoutID).HasColumnName("handedoutID");
            this.Property(t => t.handedouttime).HasColumnName("handedouttime");
            this.Property(t => t.createassid).HasColumnName("createassid");
        }
    }
}
