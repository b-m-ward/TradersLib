using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Configuration;

namespace TradersLib.Tests
{
    [TestClass]
    public class TestBase
    {
        public IApplicationConfiguration _config;

        public RegistrationModule module;
        [TestInitialize]
        public virtual void TestInit()
        {
            module = new RegistrationModule();
            module.RegisterModules();

            using(var scope = module.container.BeginLifetimeScope())
            {
                _config = scope.Resolve<IApplicationConfiguration>();
            }
        }
    }
}
