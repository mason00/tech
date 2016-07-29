using System.Collections.Generic;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        ICollection<Product> GetProducts();
    }
}
