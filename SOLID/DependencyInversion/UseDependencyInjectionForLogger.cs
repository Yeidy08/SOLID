using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class UseDependencyInjectionForLogger
    {
        BetterCustomer customer = new BetterCustomer(new EmailLogger());

        public void TestDependency()
        {
            customer.Add(new Database());
        }
        
    }
}
