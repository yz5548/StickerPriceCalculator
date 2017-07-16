using Microsoft.Practices.Unity;
using StickerPriceCalculator.Interfaces;
using System.Web.Http;
using Unity.WebApi;

namespace StickerPriceCalculator.WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStickerPriceCalculator, StickPriceCalculator.BLL.StickPriceCalculator>(new HierarchicalLifetimeManager());

            //config.DependencyResolver = new UnityResolver(container);
 
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}