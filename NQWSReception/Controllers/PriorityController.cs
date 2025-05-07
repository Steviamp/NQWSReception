using Microsoft.AspNetCore.Mvc;
using NQWSReception.Services;
using ServiceReference;

namespace NQWSReception.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriorityController : ControllerBase
    {
        private readonly ISoapService _soapService;

        public PriorityController(ISoapService soapService)
        {
            _soapService = soapService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Priority>>> Get([FromQuery] string host, [FromQuery] int port)
        {
            var list = await _soapService.GetPriorityListAsync(host, port);
            return Ok(list);
        }
    }
}
