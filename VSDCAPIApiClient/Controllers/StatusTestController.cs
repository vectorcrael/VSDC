using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VSDCAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusTestController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<StatusTestController> _logger;

    public StatusTestController(ILogger<StatusTestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetStatus")]
    public IEnumerable<ServerStatus> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new ServerStatus
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Code = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

