using DependencyTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyTest.Classes
{
    public class SingletonClass : IDeneme1
    {
        public string Deneme1Function()
        {
            return "Singleton Class 1 was worked.";
        }

        public string Deneme2Function()
        {
            return "Singleton Class 2 was worked.";
        }
    }
}
