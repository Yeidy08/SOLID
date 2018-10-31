using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            Debug.WriteLine("Escribiendo Email Logger." + error);
            File.WriteAllText(@"Error.txt", error);
        }
    }
}
