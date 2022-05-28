using DependencyTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyTest.Classes
{
    public class ScopedClass : IDeneme1
    {
        public string Deneme1Function()
        {
            return "Scoped Class 1 was worked.";
        }
        public string Deneme2Function()
        {
            return "Scoped Class 2 was worked.";
        }
        

        
    }
}
