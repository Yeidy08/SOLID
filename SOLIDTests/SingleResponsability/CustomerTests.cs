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
    public class CustomerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Customer customer = new Customer();
            try
            {
                customer.Add(new Database());
                Assert.ReferenceEquals(new Customer(), customer);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}