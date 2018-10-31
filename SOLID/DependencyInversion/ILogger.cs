﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public interface ILogger
    {
        void Handle(string error);
    }
}
