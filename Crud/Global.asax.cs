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
            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            UnityConfig.RegisterDependencies();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);  
        }        
    }
}
