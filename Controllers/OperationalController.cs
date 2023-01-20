using System.Text.Json;
using DrcashPartner.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrcashPartner.Controllers;

[ApiController]
[Route("[controller]")]
public class OperationalController : ControllerBase
{

    private readonly ILogger<OperationalController> _logger;

    public OperationalController(ILogger<OperationalController> logger)
    {
        _logger = logger;
    }

    [HttpPost("patients/{message}")]
    public IActionResult Patients(string message)
    {
        _logger.LogInformation("---> Getting message from Operational Patient SNS");
        _logger.LogInformation("{Message}", message);
        
        return Ok(message);
    }
    
}
