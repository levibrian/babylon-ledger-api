using Babylon.Ledger.Domain.Features.Incomes.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Babylon.Ledger.Api.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class IncomesController : ControllerBase
{
    private readonly IIncomeService incomeService;
    
    private readonly ILogger<IncomesController> logger;

    public IncomesController(IIncomeService incomeService, ILogger<IncomesController> logger)
    {
        this.incomeService = incomeService;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        logger.LogInformation($"{nameof(IncomesController)} - Called GET method.");
        
        return Ok();
    } 
}