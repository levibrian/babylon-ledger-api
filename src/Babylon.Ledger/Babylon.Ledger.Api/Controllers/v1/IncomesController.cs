using Microsoft.AspNetCore.Mvc;

namespace Babylon.Ledger.Api.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class IncomesController : ControllerBase
{
    private readonly ILogger<IncomesController> logger;

    public IncomesController(ILogger<IncomesController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        logger.LogInformation($"{nameof(IncomesController)} - Called GET method.");
        
        return Ok();
    } 
}