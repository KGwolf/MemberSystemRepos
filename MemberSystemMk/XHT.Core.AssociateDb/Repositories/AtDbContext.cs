using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using XHT.Core.AssociateDb.Entities;
using XHT.Core.AssociateDb.Mappings;

namespace XHT.Core.AssociateDb.Repositories
{
    public partial class AtDbContext : DbContext
    {
        static AtDbContext()
        {
            Database.SetInitializer<AtDbContext>(null);
        }

        public AtDbContext()
            : base("Name=AtDbContext")
        {
        }

        public DbSet<Associator> Associator { get; set; }
        public DbSet<AssociatorRelation> AssociatorRelation { get; set; }
        public DbSet<Associator2> Associator2 { get; set; }
        public DbSet<BCat> BCat { get; set; }
        public DbSet<BDept> BDept { get; set; }
        public DbSet<DoLogs> DoLogs { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<SysRedSet> SysRedSet { get; set; }
        public DbSet<SysRight> SysRight { get; set; }
        public DbSet<SysValues> SysValues { get; set; }
        public DbSet<TAsspay> TAsspay { get; set; }
        public DbSet<TDocumentTemplate> TDocumentTemplate { get; set; }
        public DbSet<TMessasge> TMessasge { get; set; }
        public DbSet<TMessageReciver> TMessageReciver { get; set; }
        public DbSet<TSignUp> TSignUp { get; set; }
        public DbSet<TSignUpDept> TSignUpDept { get; set; }
        public DbSet<TSignUpList> TSignUpList { get; set; }
        public DbSet<TWelfare> TWelfare { get; set; }
        public DbSet<TWelfareConfirm> TWelfareConfirm { get; set; }
        public DbSet<TWelfareList> TWelfareList { get; set; }
        public DbSet<TWelfareReciveidList> TWelfareReciveidList { get; set; }
        public DbSet<User1> User1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AssociatorMap());
            modelBuilder.Configurations.Add(new AssociatorRelationMap());
            modelBuilder.Configurations.Add(new Associator2Map());
            modelBuilder.Configurations.Add(new BCatMap());
            modelBuilder.Configurations.Add(new BDeptMap());
            modelBuilder.Configurations.Add(new DoLogsMap());
            modelBuilder.Configurations.Add(new PictureMap());
            modelBuilder.Configurations.Add(new SysRedSetMap());
            modelBuilder.Configurations.Add(new SysRightMap());
            modelBuilder.Configurations.Add(new SysValuesMap());
            modelBuilder.Configurations.Add(new TAsspayMap());
            modelBuilder.Configurations.Add(new TDocumentTemplateMap());
            modelBuilder.Configurations.Add(new TMessasgeMap());
            modelBuilder.Configurations.Add(new TMessageReciverMap());
            modelBuilder.Configurations.Add(new TSignUpMap());
            modelBuilder.Configurations.Add(new TSignUpDeptMap());
            modelBuilder.Configurations.Add(new TSignUpListMap());
            modelBuilder.Configurations.Add(new TWelfareMap());
            modelBuilder.Configurations.Add(new TWelfareConfirmMap());
            modelBuilder.Configurations.Add(new TWelfareListMap());
            modelBuilder.Configurations.Add(new TWelfareReciveidListMap());
            modelBuilder.Configurations.Add(new User1Map());
        }
    }
}
