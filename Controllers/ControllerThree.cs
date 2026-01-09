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
    public class ControllerThree : ControllerBase
    {
        private readonly RevsersIt _revesersIt;
        
        public ControllerThree(RevsersIt revesersIt)
        {
            _revesersIt = revesersIt;
        }
        [HttpGet("reverse-string")]
        public IActionResult ReverseString([FromQuery] string input)
        {
            var result = _revesersIt.ReverseTheString(input);
            return Ok(new { ReversedString = result });
        }
    }
}