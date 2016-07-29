namespace TechTest01.Repository.Migrations
{
    using Domain.Catalog;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTest01.Repository.TestDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TechTest01.Repository.TestDBContext context)
        {
            var p1 = new Product() { Id = 1, Slug = "Mason" };
            var p2 = new Product() { Id = 2, Slug = "Coco" };
            var p3 = new Product() { Id = 3, Slug = "Mark" };
            var dummyProducts = new List<Product>() { p1, p2, p3 };
            context.Products.AddOrUpdate(dummyProducts.ToArray());

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
