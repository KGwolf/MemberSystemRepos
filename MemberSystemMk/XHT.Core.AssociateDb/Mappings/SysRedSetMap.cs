using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class SysRedSetMap : EntityTypeConfiguration<SysRedSet>
    {
        public SysRedSetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TABLE_NAME, t.COLUMN_NAME });

            // Properties
            this.Property(t => t.TABLE_NAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.COLUMN_NAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.IS_NULLABLE)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.is_input)
                .HasMaxLength(15);

            this.Property(t => t.flag)
                .HasMaxLength(15);

            this.Property(t => t.column_comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("sys_red_set");
            this.Property(t => t.TABLE_NAME).HasColumnName("TABLE_NAME");
            this.Property(t => t.COLUMN_NAME).HasColumnName("COLUMN_NAME");
            this.Property(t => t.IS_NULLABLE).HasColumnName("IS_NULLABLE");
            this.Property(t => t.is_input).HasColumnName("is_input");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.column_comment).HasColumnName("column_comment");
        }
    }
}
