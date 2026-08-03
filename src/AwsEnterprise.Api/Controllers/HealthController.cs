using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // return Ok("API is healthy");

        return Ok(new 
            { 
                Status = "Running", 
                Application = "AWS Enterprise API",
                Version = "1.0.0",
                Timestamp = DateTime.UtcNow 
            });
    }
}