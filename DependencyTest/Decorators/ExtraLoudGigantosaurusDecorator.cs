using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyTest.Interfaces;

namespace DependencyTest.Decorators
{
    public class ExtraLoudGigantosaurusDecorator : IGiganotosaurus
    {
        protected readonly IGiganotosaurus _gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGiganotosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{_gigantosaurus.Roar()}!";
        }
    }
}
