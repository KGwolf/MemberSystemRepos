using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class User1Map : EntityTypeConfiguration<User1>
    {
        public User1Map()
        {
            // Primary Key
            this.HasKey(t => t.userid);

            // Properties
            this.Property(t => t.userid)
                .IsRequired()
                .HasMaxLength(16);

            this.Property(t => t.pwd)
                .HasMaxLength(50);

            this.Property(t => t.name)
                .HasMaxLength(16);

            this.Property(t => t.deptid)
                .HasMaxLength(50);

            this.Property(t => t.ipcode)
                .HasMaxLength(50);

            this.Property(t => t.rightgroupid)
                .HasMaxLength(50);

            this.Property(t => t.rightcode)
                .HasMaxLength(50);

            this.Property(t => t.machinename)
                .HasMaxLength(50);

            this.Property(t => t.postname)
                .HasMaxLength(50);

            this.Property(t => t.distributioncenter)
                .HasMaxLength(50);

            this.Property(t => t.newpwd)
                .HasMaxLength(100);

            this.Property(t => t.svrip)
                .HasMaxLength(100);

            this.Property(t => t.orgid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("USER1");
            this.Property(t => t.userid).HasColumnName("userid");
            this.Property(t => t.pwd).HasColumnName("pwd");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.deptid).HasColumnName("deptid");
            this.Property(t => t.fnid).HasColumnName("fnid");
            this.Property(t => t.picid).HasColumnName("picid");
            this.Property(t => t.ipcode).HasColumnName("ipcode");
            this.Property(t => t.logintime).HasColumnName("logintime");
            this.Property(t => t.rightgroupid).HasColumnName("rightgroupid");
            this.Property(t => t.rightcode).HasColumnName("rightcode");
            this.Property(t => t.machinename).HasColumnName("machinename");
            this.Property(t => t.postname).HasColumnName("postname");
            this.Property(t => t.vion).HasColumnName("vion");
            this.Property(t => t.STATE).HasColumnName("STATE");
            this.Property(t => t.distributioncenter).HasColumnName("distributioncenter");
            this.Property(t => t.newpwd).HasColumnName("newpwd");
            this.Property(t => t.svrip).HasColumnName("svrip");
            this.Property(t => t.orgid).HasColumnName("orgid");
        }
    }
}
