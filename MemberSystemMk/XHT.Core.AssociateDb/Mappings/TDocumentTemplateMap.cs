using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TDocumentTemplateMap : EntityTypeConfiguration<TDocumentTemplate>
    {
        public TDocumentTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TemplateChName)
                .HasMaxLength(100);

            this.Property(t => t.TemplateEnName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("T_DocumentTemplate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TemplateChName).HasColumnName("TemplateChName");
            this.Property(t => t.TemplateEnName).HasColumnName("TemplateEnName");
            this.Property(t => t.TemplateHtml).HasColumnName("TemplateHtml");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
