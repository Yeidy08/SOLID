using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Database
    {
        internal void Add()
        {
            Debug.WriteLine("Agregado.");
        }

        internal void AnotherExtension()
        {
            Debug.WriteLine("Another Agregado");
        }

        internal void AddExistingCustomer()
        {
            Debug.WriteLine("ExistingCustomer Agregado");
        }
    }
}
