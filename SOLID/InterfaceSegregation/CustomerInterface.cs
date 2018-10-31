using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class CustomerInterface : ICustomer
    {
        public void Add(Database db)
        {
            Debug.WriteLine("Agregado Customer Interface.");
            db.Add();
        }
    }
}
