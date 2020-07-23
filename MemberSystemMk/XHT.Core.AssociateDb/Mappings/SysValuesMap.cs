using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class SysValuesMap : EntityTypeConfiguration<SysValues>
    {
        public SysValuesMap()
        {
            // Primary Key
            this.HasKey(t => t.ids);

            // Properties
            //this.Property(t => t.ids)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.names)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.flag1)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.flag2)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.flag3)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.flag4)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.flag5)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.flag6)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("sys_values");
            this.Property(t => t.ids).HasColumnName("ids");
            this.Property(t => t.names).HasColumnName("names");
            this.Property(t => t.valuess).HasColumnName("valuess");
            this.Property(t => t.flag1).HasColumnName("flag1");
            this.Property(t => t.flag2).HasColumnName("flag2");
            this.Property(t => t.flag3).HasColumnName("flag3");
            this.Property(t => t.flag4).HasColumnName("flag4");
            this.Property(t => t.flag5).HasColumnName("flag5");
            this.Property(t => t.flag6).HasColumnName("flag6");
        }
    }
}
