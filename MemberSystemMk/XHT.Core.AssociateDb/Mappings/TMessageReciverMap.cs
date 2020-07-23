using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TMessageReciverMap : EntityTypeConfiguration<TMessageReciver>
    {
        public TMessageReciverMap()
        {
            // Primary Key
            this.HasKey(t => new { t.messageid, t.receiveid });

            // Properties
            //this.Property(t => t.messageid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //this.Property(t => t.receiveid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("t_messagerecever");
            this.Property(t => t.messageid).HasColumnName("messageid");
            this.Property(t => t.receiveid).HasColumnName("receiveid");
            this.Property(t => t.readdatetime).HasColumnName("readdatetime");
        }
    }
}
