using System.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Application.Interfaces;
using Application.Querys;
using Domain.Models;
using Infrastructure;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Crud
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public static class UnityConfig
        {
            public static void Register(HttpConfiguration config)
            {
                var container = new UnityContainer();

                var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                // Registra el contexto de la base de datos y pasa la cadena de conexión
                container.RegisterType<CreditCardDbContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(connectionString));
                container.RegisterType<IRepository<CreditCard>, Repository<CreditCard>>(new HierarchicalLifetimeManager());
                container.RegisterType<ICreditCardServices, CreditCardServices>(new HierarchicalLifetimeManager());

                // Configuración de IoC
                //container.RegisterType<IRepository<>, Repository<>>();

                config.DependencyResolver = new UnityResolver(container);
            }
        }
    }
}
