using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.InterfaceSegregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Tests
{
    [TestClass()]
    public class InterfaceSegregationTests
    {
        [TestMethod()]
        public void TestCustomersTest()
        {
            ICustomer customer = new CustomerInterface();
            ICustomerV1 readCustomer = new CustomerWithRead();

            Assert.IsInstanceOfType(customer, typeof(ICustomer));
            Assert.IsNotInstanceOfType(customer, typeof(ICustomerV1));
            Assert.IsInstanceOfType(readCustomer, typeof(ICustomer));
            Assert.IsInstanceOfType(readCustomer, typeof(ICustomerV1));
        }
    }
}