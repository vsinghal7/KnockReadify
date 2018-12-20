using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnockReadify.Controllers
{
    [Produces("application/json")]
    [Route("api/Fibonacci")]
    public class FibonacciController : Controller
    {
        // GET: api/Fibonacci/5
        [HttpGet("{n}", Name = "Get")]
        public IActionResult Get(Int64 n)
        {
            try
            {
                if (n == 0 || n == 1) return Ok(1);
                else
                {
                    Int64 a = 0;
                    Int64 b = 1;
                    Int64 c = 0;

                    for (Int64 i = 0; i < n; i++)
                    {
                        c = b + a;
                        a = b;
                        b = c;
                    }
                    return Ok(c);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Data);
            }
        }
    }
}
