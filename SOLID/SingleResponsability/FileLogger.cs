using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class FileLogger
    {
        public void Handle(string error)
        {
            File.WriteAllText(@"Error.txt", error);
        }
    }
}
