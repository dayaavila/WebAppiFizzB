using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        public static string GetOutPut(int number)
        {
            string numberOutPut;

            if ((number % 3 == 0) && (number % 5 == 0)) 
            {//2145
                numberOutPut = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {//36
                numberOutPut = "Fizz";
            }
            else if (number % 5 == 0)
            {//40
                numberOutPut = "buzz";
            }
            else
            {
                numberOutPut = number.ToString();
            }
            return numberOutPut;

        }

        [HttpGet]
        public async Task<ActionResult<string>> GetFizzBuzz(int number)
        {
            var result = GetOutPut(number);
            return result;
        }
    }
}
