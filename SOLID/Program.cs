using SOLID.DependencyInversion;
using SOLID.InterfaceSegregation;
using SOLID.Liskovs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // S
            Debug.WriteLine("START: Single Responsability.");
            Customer cus = new Customer();
            cus.Add(new Database());
            Debug.WriteLine("END: Single Responsability.");

            // O
            Debug.WriteLine("START: Open/Close.");
            CustomerBetter anotherCustomer = new AnotherCustomer();
            anotherCustomer.Add(new Database());
            

            CustomerBetter existingCustomer = new ExistingCustomer();
            existingCustomer.Add(new Database());
            Debug.WriteLine("END: Open/Close.");

            // L
            Debug.WriteLine("START: Liskov.");
            AdheringToLiskovs atl = new AdheringToLiskovs();
            atl.ParseCustomers();
            Debug.WriteLine("END: Liskov.");

            // I
            Debug.WriteLine("START: Interface Segregation.");
            ManipulateCustomers mc = new ManipulateCustomers();
            mc.TestCustomers();
            Debug.WriteLine("END: Interface Segregation.");

            // D
            Debug.WriteLine("START: Dependences Inversion.");
            UseDependencyInjectionForLogger uifl = new UseDependencyInjectionForLogger();
            uifl.TestDependency();
            Debug.WriteLine("END: Dependences Inversion.");
        }
    }
}
