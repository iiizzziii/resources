using System.Globalization;
using System.Resources;
using Microsoft.AspNetCore.Mvc;
using resources.api.Services;
using resources.lib.Services;

namespace resources.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResourceController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCulture()
    {
        var resource = ResourceSetter.GetMessage("LANGUAGE");
        
        return Ok(CultureInfo.CurrentCulture.DisplayName);
    }
}