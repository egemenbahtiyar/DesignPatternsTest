using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyTest.Interfaces;

namespace DependencyTest.Classes
{
    public class DependencyChooser:DependencyFactory
    {
        public override IDeneme1 GetDependencyModel(string DependencyModel)
        {
            if (DependencyModel.Equals("Scoped"))
            {
                return new ScopedClass();
            }
            else if (DependencyModel.Equals("Transient"))
            {
                return new TransientClass();
            }
            else if (DependencyModel.Equals("Singleton"))
            {
                return new SingletonClass();
            }
            else
                return null;
        }
    }
}
