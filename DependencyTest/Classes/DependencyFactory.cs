using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyTest.Interfaces;

namespace DependencyTest.Classes
{
    public abstract class DependencyFactory
    {
        public abstract IDeneme1 GetDependencyModel(string DependencyModel);
    }
}
