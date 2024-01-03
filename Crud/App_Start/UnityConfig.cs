using System;
using Application.Interfaces;
using Application.Querys;
using Domain.Models;
using Infrastructure;
using Unity;

namespace Crud
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer Container => container.Value;

        public static void RegisterTypes(IUnityContainer container)
        {
            // Descomenta la siguiente línea si tienes configuraciones en web.config
            // container.LoadConfiguration();

        }

        public static void RegisterDependencies()
        {
            //UnityContainer container = new UnityContainer();
            UnityConfig.Container.RegisterType<IRepository<CreditCard>, Repository<CreditCard>>();
            UnityConfig.Container.RegisterType<ICreditCardServices, CreditCardServices>();

        }
    }
}
