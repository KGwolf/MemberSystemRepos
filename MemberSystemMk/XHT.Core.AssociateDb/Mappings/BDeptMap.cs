using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class BDeptMap : EntityTypeConfiguration<BDept>
    {
        public BDeptMap()
        {
            // Primary Key
            this.HasKey(t => t.deptid);

            // Properties
            this.Property(t => t.deptid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.deptname)
                .HasMaxLength(50);

            this.Property(t => t.deptmanagerid)
                .HasMaxLength(50);

            this.Property(t => t.deptdescription)
                .HasMaxLength(50);

            this.Property(t => t.createrid)
                .HasMaxLength(50);

            this.Property(t => t.compaid)
                .HasMaxLength(50);

            this.Property(t => t.depttype)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("b_dept");
            this.Property(t => t.deptid).HasColumnName("deptid");
            this.Property(t => t.deptname).HasColumnName("deptname");
            this.Property(t => t.deptmanagerid).HasColumnName("deptmanagerid");
            this.Property(t => t.deptdescription).HasColumnName("deptdescription");
            this.Property(t => t.createrid).HasColumnName("createrid");
            this.Property(t => t.createtime).HasColumnName("createtime");
            this.Property(t => t.lastmodify).HasColumnName("lastmodify");
            this.Property(t => t.compaid).HasColumnName("compaid");
            this.Property(t => t.depttype).HasColumnName("depttype");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.parentid).HasColumnName("parentid");
        }
    }
}
