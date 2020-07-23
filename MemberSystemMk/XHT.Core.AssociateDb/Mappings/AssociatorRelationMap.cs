using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using XHT.Core.AssociateDb.Entities;
namespace XHT.Core.AssociateDb.Mappings
{
    public class AssociatorRelationMap : EntityTypeConfiguration<AssociatorRelation>
    {
        public AssociatorRelationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.会员卡号, t.亲属姓名 });

            // Properties
            //this.Property(t => t.会员卡号)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.亲属关系)
                .HasMaxLength(50);

            this.Property(t => t.亲属姓名)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.亲属性别)
                .HasMaxLength(50);

            this.Property(t => t.亲属单位)
                .HasMaxLength(50);

            this.Property(t => t.亲属身份证号)
                .HasMaxLength(50);

            this.Property(t => t.亲属学历)
                .HasMaxLength(50);

            this.Property(t => t.亲属住址)
                .HasMaxLength(50);

            this.Property(t => t.亲属收入)
                .HasMaxLength(50);

            this.Property(t => t.亲属社保)
                .HasMaxLength(50);

            this.Property(t => t.亲属住房)
                .HasMaxLength(50);

            this.Property(t => t.亲属电话)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ASSOCIATOR_relation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.会员卡号).HasColumnName("会员卡号");
            this.Property(t => t.亲属关系).HasColumnName("亲属关系");
            this.Property(t => t.亲属姓名).HasColumnName("亲属姓名");
            this.Property(t => t.亲属性别).HasColumnName("亲属性别");
            this.Property(t => t.亲属生日).HasColumnName("亲属生日");
            this.Property(t => t.亲属单位).HasColumnName("亲属单位");
            this.Property(t => t.亲属身份证号).HasColumnName("亲属身份证号");
            this.Property(t => t.亲属学历).HasColumnName("亲属学历");
            this.Property(t => t.亲属住址).HasColumnName("亲属住址");
            this.Property(t => t.亲属收入).HasColumnName("亲属收入");
            this.Property(t => t.亲属社保).HasColumnName("亲属社保");
            this.Property(t => t.亲属住房).HasColumnName("亲属住房");
            this.Property(t => t.亲属电话).HasColumnName("亲属电话");
        }
    }
}
