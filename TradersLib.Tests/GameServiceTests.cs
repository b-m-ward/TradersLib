using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TradersLib.Services;

namespace TradersLib.Tests
{
    [TestClass]
    public class GameServiceTests : TestBase
    {
        GameService _game;
        [TestInitialize]
        public override void TestInit()
        {
            base.TestInit();

            //Per autofac docs, resolve from scope to avoid memory leaks
            using(var scope = base.module.container.BeginLifetimeScope())
            {
                _game = scope.Resolve<GameService>();
            }
        }

        [TestMethod]
        public async Task GameHealthCheck()
        {
            bool active = await _game.IsActive();
            Assert.IsTrue(active);
        }
    }
}
