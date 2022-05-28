using DependencyTest.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DependencyTest.Classes;
using DependencyTest.Decorators;

namespace DependencyTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdNinja : ControllerBase
    {
        public DependencyFactory _DependencyFactory;
        public ThirdNinja(DependencyFactory dependencyFactory)
        {
            _DependencyFactory = dependencyFactory;

        }
        [HttpGet]
        public IActionResult GetString()
        {

            var obj1 =_DependencyFactory.GetDependencyModel("Scoped").Deneme1Function();
            var obj2 =_DependencyFactory.GetDependencyModel("Singleton").Deneme1Function();
            var obj3 =_DependencyFactory.GetDependencyModel("Transient").Deneme1Function();
            var result = new
            {
                Output1 = obj1,
                Output2 = obj2,
                Output3 = obj3

            };

            return Ok(result);



            //var dinozor = new Gigantosaurus();
            //var azSesliDinozor = new LoudGigantosarusDecorator(dinozor);
            //var cokSesliDonozor = new ExtraLoudGigantosaurusDecorator(azSesliDinozor);

            //var testString = dinozor.Roar();
            //var testString2 = azSesliDinozor.Roar();
            //var testString3 = cokSesliDonozor.Roar();

            //var result = new
            //{
            //    testString = testString,
            //    testString2 = testString2,
            //    testString3 = testString3
            //};
            //return Ok(result);

        }     
    }
}