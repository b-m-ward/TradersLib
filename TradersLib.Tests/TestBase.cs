using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradersLib.Tests
{
    [TestClass]
    public class TestBase
    {
        public RegistrationModule module;
        [TestInitialize]
        public virtual void TestInit()
        {
            module = new RegistrationModule();
            module.RegisterModules();
        }
    }
}
