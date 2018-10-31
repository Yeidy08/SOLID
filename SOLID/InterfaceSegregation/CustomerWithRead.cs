using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class CustomerWithRead : ICustomer, ICustomerV1
    {
        public void Add(Database db)
        {
            Debug.WriteLine("Agregado CustomerWithRead.");
            db.Add();
        }

        public void Read()
        {
            // GOOD: New functionality here!
            Debug.WriteLine("Read CustomerWithRead.");
        }
    }
}
