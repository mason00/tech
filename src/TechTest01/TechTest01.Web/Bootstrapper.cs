using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using TechTest01.Repository;
using TechTest01.Services;
using TechTest01.Services.Catalog;

namespace TechTest01.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterInstance(typeof(TestDBContext), TestDBContext.GetInstance());

            return container;
        }
    }
}