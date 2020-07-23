using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TSignUpDeptMap : EntityTypeConfiguration<TSignUpDept>
    {
        public TSignUpDeptMap()
        {
            // Primary Key
            this.HasKey(t => new { t.signupID, t.assdeptid });

            // Properties
            //this.Property(t => t.signupID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.assdeptid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_signupdept");
            this.Property(t => t.signupID).HasColumnName("signupID");
            this.Property(t => t.assdeptid).HasColumnName("assdeptid");
        }
    }
}
