using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : Controller
    {
        IProductService productServie;

        public ProductsController(IProductService service)
        {
            productServie = service;
        }

        public ActionResult Index()
        {
            return View(productServie.GetProducts());
        }

        public ActionResult Detail(string slug)
        {
            return View(productServie.GetProducts().FirstOrDefault(p => p.Slug == slug));
        }
    }
}