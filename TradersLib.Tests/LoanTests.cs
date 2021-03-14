using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Services;

namespace TradersLib.Tests
{
    [TestClass]
    public class LoanTests : TestBase
    {
        LoanService _loans;

        [TestInitialize]
        public override void TestInit()
        {
            base.TestInit();

            using(var scope = base.module.container.BeginLifetimeScope())
            {
                _loans = scope.Resolve<LoanService>();
            }

        }

        [TestMethod]
        public async Task GetAvailableLoans()
        {
            var loans = await _loans.GetAvailableLoans();

            Assert.IsTrue(loans.Loans.Length > 0);
        }


    }
}
