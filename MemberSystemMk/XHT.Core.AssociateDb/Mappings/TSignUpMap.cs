using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class TSignUpMap : EntityTypeConfiguration<TSignUp>
    {
        public TSignUpMap()
        {
            // Primary Key
            this.HasKey(t => t.signupID);

            // Properties
            //this.Property(t => t.signupID)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.signupname)
                .HasMaxLength(50);

            this.Property(t => t.assdeptid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("t_signup");
            this.Property(t => t.signupID).HasColumnName("signupID");
            this.Property(t => t.createid).HasColumnName("createid");
            this.Property(t => t.signupname).HasColumnName("signupname");
            this.Property(t => t.assdeptid).HasColumnName("assdeptid");
            this.Property(t => t.starttime).HasColumnName("starttime");
            this.Property(t => t.endtime).HasColumnName("endtime");
            this.Property(t => t.confirmid).HasColumnName("confirmid");
            this.Property(t => t.note).HasColumnName("note");
            this.Property(t => t.pcount).HasColumnName("pcount");
            this.Property(t => t.signupdeptid).HasColumnName("signupdeptid");
        }
    }
}
