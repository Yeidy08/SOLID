using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class BetterCustomer
    {
        ILogger logger;
        public BetterCustomer(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add(Database db)
        {
            try
            {
                throw new Exception("Test Exception");// Raise exception
            }
            catch (Exception error)
            {
                Debug.WriteLine("Exception." + error.Message);
                logger.Handle(error.ToString());
            }
        }
    }
}
