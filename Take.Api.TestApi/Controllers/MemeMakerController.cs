using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Take.Api.TestApi.Facades;

namespace Take.Api.TestApi.Controllers
{
    public class MemeMakerController : Controller
    {
        private readonly IGetMemeFacade _getMemeFacade;

        public MemeMakerController(IGetMemeFacade getMemeFacade)
        {
            _getMemeFacade = getMemeFacade;
        }

        [HttpGet("c")]

        public async Task<IActionResult> GetMemeAsync([FromQuery]string c)
        {
            var response = await _getMemeFacade.GetMemeAsync(c);

            return Ok(response);
        }

        

    }
}
