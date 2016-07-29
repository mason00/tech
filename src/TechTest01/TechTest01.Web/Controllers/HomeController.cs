using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TechTest01.Domain.Catalog;
using TechTest01.Repository;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductService productService;

        public HomeController(IProductService service)
        {
            productService = service;
        }
        
        // GET: Home
        public ActionResult Index()
        {
            return View(productService.GetProducts().Take(2));
        }
    }
}