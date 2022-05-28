using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyTest.Interfaces;

namespace DependencyTest.Classes
{
    public class Gigantosaurus : IGiganotosaurus
    {
        public string Roar()
        {
            return "Roarr test";
        }
    }
}
