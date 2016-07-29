using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class ProductRepository : IProductRepository
    {
        TestDBContext dbContext;
        List<Product> dummyProducts;

        public ProductRepository()
        {
            dbContext = TestDBContext.GetInstance();
            //CreateDummyData();
        }

        private void CreateDummyData()
        {
            var p1 = new Product() { Id = 1, Slug = "Mason" };
            var p2 = new Product() { Id = 2, Slug = "Coco" };
            var p3 = new Product() { Id = 3, Slug = "Mark" };
            dummyProducts = new List<Product>() { p1, p2, p3 };
        }

        public Product GetById(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
            //return dummyProducts.FirstOrDefault(p => p.Id == id);
        }

        public ICollection<Product> GetProducts()
        {
            
            return dbContext.Products.ToList();
            //return dummyProducts;
        }

        //CURD functions here
        //public void Save(Product p)
        //{
        //    dbContext.Products.Add(p);
        //    dbContext.SaveChanges();
        //}
    }
}
