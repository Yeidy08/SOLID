using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskovs
{
    public class Enquiry : CustomerLiskovs
    {
        public override int Discount(int sales)
        {
            Debug.WriteLine("sales * 5");
            return sales * 5;
        }

        public override void Add(Database db)
        {
            Debug.WriteLine("Not allowed.");
        }
    }
}
