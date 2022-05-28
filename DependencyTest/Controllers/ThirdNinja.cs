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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ThirdNinja : ControllerBase
    {
        public IDeneme1 _IDeneme1 { get; set; }
        public ThirdNinja(IDeneme1 IDeneme1)
        {
            _IDeneme1 = IDeneme1;
            
        }
        [HttpGet]
        public IActionResult GetString()
        {
            var String = _IDeneme1.Deneme2Function();
            Console.WriteLine(String);
            return Ok(String);

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