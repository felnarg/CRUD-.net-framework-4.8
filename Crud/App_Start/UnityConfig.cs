using System;
using System.Configuration;
using System.Web.Mvc;
using Application.Interfaces;
using Application.Querys;
using Domain.Models;
using Infrastructure;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Crud
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
        }

        public static void Register()
        {
            UnityContainer container = new UnityContainer();

            //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Registra el contexto de la base de datos y pasa la cadena de conexión
            //container.RegisterType<CreditCardDbContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(connectionString));
            container.RegisterType<IRepository<CreditCard>, Repository<CreditCard>>();
            container.RegisterType<ICreditCardServices, CreditCardServices>();

            // Configuración de IoC
            //container.RegisterType<IRepository<>, Repository<>>();

            DependencyResolver.SetResolver(new UnityResolver(container));
        }
        
    }
}