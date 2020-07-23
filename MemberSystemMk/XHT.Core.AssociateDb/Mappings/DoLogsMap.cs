using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class DoLogsMap : EntityTypeConfiguration<DoLogs>
    {
        public DoLogsMap()
        {
            // Primary Key
            this.HasKey(t => t.logid);

            // Properties
            //this.Property(t => t.logid)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.doid)
                .HasMaxLength(50);

            this.Property(t => t.menuname)
                .HasMaxLength(50);

            this.Property(t => t.newvalue)
                .HasMaxLength(50);

            this.Property(t => t.oldvalue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("do_logs");
            this.Property(t => t.logid).HasColumnName("logid");
            this.Property(t => t.doid).HasColumnName("doid");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.dotime).HasColumnName("dotime");
            this.Property(t => t.menuname).HasColumnName("menuname");
            this.Property(t => t.newvalue).HasColumnName("newvalue");
            this.Property(t => t.oldvalue).HasColumnName("oldvalue");
        }
    }
}
