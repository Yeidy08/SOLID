using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Customer
    {
        private FileLogger logger = new FileLogger();

        public void Add(Database db)
        {
            try
            {
                db.Add();
            }
            catch (Exception ex)
            {
                // Single Responsability
                logger.Handle(ex.ToString());
            }
        }
    }
}
