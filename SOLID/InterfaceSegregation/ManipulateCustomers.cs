using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class ManipulateCustomers
    {
        Database database = new Database();
        ICustomer customer = new CustomerInterface();        
        ICustomerV1 readCustomer = new CustomerWithRead();        

        public void TestCustomers()
        {
            customer.Add(database); // Old functionality, works fine
            readCustomer.Add(database);
            readCustomer.Read(); // Good! New functionalty is separate from existing customers
        }
    }
}
