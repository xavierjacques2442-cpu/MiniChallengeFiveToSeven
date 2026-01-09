using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerFour : ControllerBase
    {
        private readonly Services.NumberRevsers _numberReverser;

        public ControllerFour(Services.NumberRevsers numberReverser)
        {
            _numberReverser = numberReverser;
        }

        [HttpGet("reverse-number/{input}")]
        public IActionResult ReverseNumber(string input)
        {
            var result = _numberReverser.ReverseNumber(input);
            return Ok(result);
        }
    }
}