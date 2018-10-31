using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class CustomerLiskovs : IDiscount, IDatabase
    {
        public abstract void Add(Database db);

        public abstract int Discount(int sales);
    }
}
