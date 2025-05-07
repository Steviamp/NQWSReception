using Microsoft.AspNetCore.Mvc;
using NQWSReception.Services;

[ApiController]
[Route("api/[controller]")]
public class QueueInfoController : ControllerBase
{
    private readonly ISoapService _soapService;

    public QueueInfoController(ISoapService soapService)
    {
        _soapService = soapService;
    }

    [HttpGet("{cashier}")]
    public async Task<IActionResult> GetQueueInfo(int cashier, [FromQuery] string host, [FromQuery] int port)
    {
        var result = await _soapService.GetCashierQueueInfoAsync(cashier, host, port);
        return Ok(result);
    }
}
