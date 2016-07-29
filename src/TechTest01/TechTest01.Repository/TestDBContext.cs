using System.Data.Entity;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class TestDBContext: DbContext
    {
        static TestDBContext instance;
        static object lockobject = new object();

        public static TestDBContext GetInstance()
        {
            lock (lockobject)
            {
                if (instance == null)
                {
                    instance = new TestDBContext();
                }
            }
            return instance;
        }

        public DbSet<Product> Products { get; set; }

        //one off to set up the DB, in real word, create fluent mapping to existing db
        //private TestDBContext()
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestDBContext, Migrations.Configuration>());
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
