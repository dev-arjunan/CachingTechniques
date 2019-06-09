using System;
using Microsoft.Practices.Unity;
using WeeklyDeveloperChallenge.Repositories.Interfaces;
using WeeklyDeveloperChallenge.Repositories;
using WeeklyDeveloperChallenge.Caching;
using WeeklyDeveloperChallenge.Caching.Interfaces;

namespace WeeklyDeveloperChallenge.App_Start
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<ICacheStorage, MemCache>();
        }
    }
}
