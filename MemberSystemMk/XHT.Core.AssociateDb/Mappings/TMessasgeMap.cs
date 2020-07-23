using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TMessasgeMap : EntityTypeConfiguration<TMessasge>
    {
        public TMessasgeMap()
        {
            // Primary Key
            this.HasKey(t => t.messageid);

            // Properties
            //this.Property(t => t.messageid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.createid)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("t_message");
            this.Property(t => t.messageid).HasColumnName("messageid");
            this.Property(t => t.messagetext).HasColumnName("messagetext");
            this.Property(t => t.senddatetime).HasColumnName("senddatetime");
            this.Property(t => t.createid).HasColumnName("createid");
        }
    }
}
