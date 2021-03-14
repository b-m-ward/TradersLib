using Autofac;
using System;
using TradersLib.Configuration;
using TradersLib.Services;

namespace TradersLib
{
    public class RegistrationModule
    {
        public IContainer container;
        public RegistrationModule()
        {
        }

        public void RegisterModules()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<LibraryConfig>().As<IApplicationConfiguration>();

            builder.RegisterType<GameService>().AsSelf();
            builder.RegisterType<HttpService>().AsSelf();
            builder.RegisterType<UserService>().AsSelf();
            builder.RegisterType<LoanService>().AsSelf();

            container = builder.Build();
        }
        
    }
}
