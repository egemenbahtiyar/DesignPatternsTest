using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyTest.Interfaces;

namespace DependencyTest.Decorators
{
    public class LoudGigantosarusDecorator : IGiganotosaurus
    {
        protected readonly IGiganotosaurus _gigantosaurus;

        public LoudGigantosarusDecorator(IGiganotosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{_gigantosaurus.Roar()} loudly";
        }
    }
}
