using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class SysRightMap : EntityTypeConfiguration<SysRight>
    {
        public SysRightMap()
        {
            // Primary Key
            this.HasKey(t => new { t.right_group, t.menu_parenttext, t.menu_classname, t.menu_currenttext });

            // Properties
            this.Property(t => t.right_group)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.menu_id)
                .HasMaxLength(50);

            this.Property(t => t.menu_tag)
                .HasMaxLength(50);

            this.Property(t => t.menu_parenttext)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.menu_classname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.menu_currenttext)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.menu_num)
                .HasMaxLength(50);

            this.Property(t => t.parentid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.controllername)
                .HasMaxLength(50);

            this.Property(t => t.actionname)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sys_right");
            this.Property(t => t.right_group).HasColumnName("right_group");
            this.Property(t => t.menu_id).HasColumnName("menu_id");
            this.Property(t => t.menu_tag).HasColumnName("menu_tag");
            this.Property(t => t.menu_parenttext).HasColumnName("menu_parenttext");
            this.Property(t => t.menu_classname).HasColumnName("menu_classname");
            this.Property(t => t.menu_currenttext).HasColumnName("menu_currenttext");
            this.Property(t => t.menu_num).HasColumnName("menu_num");
            this.Property(t => t.menu_handle).HasColumnName("menu_handle");
            this.Property(t => t.parentid).HasColumnName("parentid");
            this.Property(t => t.controllername).HasColumnName("controllername");
            this.Property(t => t.actionname).HasColumnName("actionname");
        }
    }
}
