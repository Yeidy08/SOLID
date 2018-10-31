using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Open for Extension Closed for Modification
    public abstract class CustomerBetter
    {
        public abstract void Add(Database db);
    }
}
