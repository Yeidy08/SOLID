using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Tests
{
    [TestClass()]
    public class UseDependencyInjectionForLoggerTests
    {
        [TestMethod()]
        public void TestDependencyTest()
        {
            var emailLogger = new EmailLogger();
            BetterCustomer customer = new BetterCustomer(emailLogger);

            var otherLogger = new OtherLogger();
            BetterCustomer otherCustomer = new BetterCustomer(otherLogger);

            Assert.IsInstanceOfType(emailLogger, typeof(EmailLogger));
            Assert.IsInstanceOfType(emailLogger, typeof(ILogger));
            Assert.IsNotInstanceOfType(emailLogger, typeof(OtherLogger));

            Assert.IsInstanceOfType(otherLogger, typeof(OtherLogger));
            Assert.IsInstanceOfType(otherLogger, typeof(ILogger));
            Assert.IsNotInstanceOfType(otherLogger, typeof(EmailLogger));
        }
    }
}