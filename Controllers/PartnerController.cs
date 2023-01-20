using System.Text.Json;
using DrcashPartner.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrcashPartner.Controllers;

[ApiController]
[Route("[controller]")]
public class PartnerController : ControllerBase
{

    private readonly ILogger<PartnerController> _logger;

    public PartnerController(ILogger<PartnerController> logger)
    {
        _logger = logger;
    }

    [HttpPost("/drcash-patients-callback/{message}")]
    public IActionResult PartnerPatientsCallBack(string message)
    {
        _logger.LogInformation("---> Getting message from Drcash on Patient Partner 1 SNS");
        
        _logger.LogInformation("{Message}", message);

        return Ok(message);
    }
    
    
    [HttpPost("/drcash-patients-callback/2/{message}")]
    public IActionResult PartnerPatientsCallBack2(string message)
    {
        _logger.LogInformation("---> Getting message from Drcash on Patient Partner 2 SNS");
        
        _logger.LogInformation("{Message}", message);
        
        return Ok(message);
    }
    
   
}
