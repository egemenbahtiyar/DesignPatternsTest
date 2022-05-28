using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyTest.Interfaces
{
    public interface IDeneme1 : IChildInterface
    {
        string Deneme2Function();
        string Deneme1Function();


    }
}
