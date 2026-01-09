using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services;

namespace MiniChallengeFiveToSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerTwo : ControllerBase
    {
        private readonly OddOrEven _oddOrEven;

        public ControllerTwo(OddOrEven oddOrEven)
        {
            _oddOrEven = oddOrEven;
        }
        [HttpGet("check-number")]
        public IActionResult CheckNumber([FromQuery] int number)
        {
            var result = _oddOrEven.IsOdd(number);
            return Ok(new { IsOdd = result });
        }
    }
}