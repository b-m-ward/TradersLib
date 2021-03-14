using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradersLib.Models;
using TradersLib.Services;

namespace TradersLib.Tests
{
    [TestClass, TestCategory("Users")]
    public class UserTests : TestBase
    {
        UserService _user;
        [TestInitialize]
        public override void TestInit()
        {
            base.TestInit();

            using(var scope = base.module.container.BeginLifetimeScope())
            {
                _user = scope.Resolve<UserService>();
            }
        }


        [TestMethod]
        [Ignore]
        public async Task RegisterUserAccount()
        {
            string userName = _config.Username;


            var userReg = await _user.RegisterUsername(userName);

            Assert.IsFalse(string.IsNullOrEmpty(userReg.Token));
        }

        [TestMethod]
        public async Task GetUserInfo()
        {
            User u = await _user.GetUserInfo();

            Assert.IsTrue(u.Username != null);
        }

    }
}
