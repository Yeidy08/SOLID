using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskovs
{
    public class BetterSilverCustomer : CustomerLiskovs
    {
        public override void Add(Database db)
        {
            db.Add();
        }

        public override int Discount(int sales)
        {
            Debug.WriteLine("sales - 50");
            return sales - 50;
        }
    }
}
