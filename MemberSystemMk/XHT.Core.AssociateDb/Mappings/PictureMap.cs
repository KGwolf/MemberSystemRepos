using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class PictureMap : EntityTypeConfiguration<Picture>
    {
        public PictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.pictype, t.filename });

            // Properties
            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.pictype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.filename)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.filepath)
                .HasMaxLength(500);

            this.Property(t => t.createid)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("PICTURE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.pictype).HasColumnName("pictype");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.filepath).HasColumnName("filepath");
            this.Property(t => t.createtime).HasColumnName("createtime");
            this.Property(t => t.createid).HasColumnName("createid");
        }
    }
}
