using System;
using System.Collections.Generic;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Services.Catalog;

namespace TechTest01.Services
{
    public class ProductService : IProductService
    {
        IProductRepository repo;

        public ProductService(IProductRepository repository)
        {
            repo = repository;
        }

        public Product GetById(int id)
        {
            return repo.GetById(id);
        }

        public ICollection<Product> GetProducts()
        {
            return repo.GetProducts();
        }
    }
}
