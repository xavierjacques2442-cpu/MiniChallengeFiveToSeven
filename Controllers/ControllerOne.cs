using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniChallengeFiveToSeven.Services;

namespace MiniChallengeFiveToSeven.Controllers
{
    [Route("[controller]")]
    public class ControllerOne : ControllerBase
    {
        private readonly MadLab _madLab;

        public ControllerOne(MadLab madLab)
        {
            _madLab = madLab;
        }
        [HttpGet("generate-madlib")]
        public IActionResult GenerateMadLib(
        
            [FromQuery] string name,
            [FromQuery] string adjective1,
            [FromQuery] string adjective2,
            [FromQuery] string noun1,
            [FromQuery] string noun2,
            [FromQuery] string verb1,
            [FromQuery] string verb2,
            [FromQuery] string adverb,
            [FromQuery] string place,
            [FromQuery] string emotion
        )
    
        {
            var madLib = _madLab.GenerateMadLib(
                name,
                adjective1,
                adjective2,
                noun1,
                noun2,
                verb1,
                verb2,
                adverb,
                place,
                emotion
            );

            return Ok(madLib);
        }
    }
}