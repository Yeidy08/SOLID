using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.Liskovs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskovs.Tests
{
    [TestClass()]
    public class AdheringToLiskovsTests
    {
        [TestMethod()]
        public void ParseCustomersTest()
        {
            var database = new Database();
            List<CustomerLiskovs> customers = new List<CustomerLiskovs>
            {
                new BetterGoldCustomer(),
                new BetterSilverCustomer(),
                new Enquiry()
            };

            Assert.AreEqual(customers[0].Discount(100), (100 - 100));
            Assert.AreEqual(customers[1].Discount(100), (100 - 50));
            Assert.AreEqual(customers[2].Discount(100), (100 * 5));

        }
    }
}