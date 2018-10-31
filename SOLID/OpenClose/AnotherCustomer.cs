using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Open for Extension Closed for Modification
    public class AnotherCustomer : CustomerBetter
    {
        public override void Add(Database db)
        {
            db.AnotherExtension();
        }
    }
}
