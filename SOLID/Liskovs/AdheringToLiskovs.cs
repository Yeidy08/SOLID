using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskovs
{
    public class AdheringToLiskovs
    {
        public void ParseCustomers()
        {
            var database = new Database();
            var customers = new List<CustomerLiskovs>
            {
                new BetterGoldCustomer(),
                new BetterSilverCustomer(),
                new Enquiry() // This will give a compiler error, rather than runtime error
            };

            foreach (CustomerLiskovs c in customers)
            {
                // Enquiry.Add() will throw an exception here!
                // But, we won't get to here as compiler will complain
                c.Add(database);
                Debug.WriteLine("Discount(100): " + c.Discount(100));
            }
        }
    }
}
