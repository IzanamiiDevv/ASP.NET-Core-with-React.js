using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_with_React.js.Controllers;

[ApiController]
[Route("/server")]
public class TemplateController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMain()
    {
        string message = "Main Server EndPoint";
        return Ok(new {Text = message});
    }
    [HttpGet("test")]
    public IActionResult GetTest()
    {
        string message = "Hello From Server";
        return Ok(new { Text = message });
    }
}
