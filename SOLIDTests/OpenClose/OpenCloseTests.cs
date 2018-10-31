using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Tests
{
    [TestClass()]
    public class OpenCloseTests
    {
        [TestMethod()]
        public void AddTest()
        {
            CustomerBetter anotherCustomer = new AnotherCustomer();
            CustomerBetter existingCustomer = new ExistingCustomer();

            Assert.ReferenceEquals(anotherCustomer, existingCustomer);
            Assert.IsInstanceOfType(anotherCustomer, typeof(CustomerBetter));
            Assert.IsInstanceOfType(existingCustomer, typeof(CustomerBetter));
        }
    }
}