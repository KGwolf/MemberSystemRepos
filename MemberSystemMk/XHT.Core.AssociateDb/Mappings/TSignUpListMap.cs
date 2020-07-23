using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TSignUpListMap : EntityTypeConfiguration<TSignUpList>
    {
        public TSignUpListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.signupID, t.assid });

            // Properties
            //this.Property(t => t.signupID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //this.Property(t => t.assid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.assdeptid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_signuplist");
            this.Property(t => t.signupID).HasColumnName("signupID");
            this.Property(t => t.assid).HasColumnName("assid");
            this.Property(t => t.signuptime).HasColumnName("signuptime");
            this.Property(t => t.signupstate).HasColumnName("signupstate");
            this.Property(t => t.assdeptid).HasColumnName("assdeptid");
        }
    }
}
