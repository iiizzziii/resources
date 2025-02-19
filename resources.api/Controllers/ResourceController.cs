using System.Globalization;
using System.Resources;
using Microsoft.AspNetCore.Mvc;
using resources.api.Models;
using resources.api.Services;
using resources.lib.Services;

namespace resources.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ResourceController : ControllerBase
{
    [HttpGet]
    [Route("culture")]
    public IActionResult GetCulture()
    {
        var response = new
        {
            ResourceLanguage = ResourceSetter.GetMessage("LANGUAGE"),
            CurrentCulture = CultureInfo.CurrentCulture.DisplayName
        };
        
        return Ok(response);
    }

    [HttpPost]
    [Route("validation")]
    public IActionResult ValidateRequest(
        [FromBody] RequestDto body)
    {
        return Ok(body.Body);
    }

    [HttpGet]
    [Route("error")]
    public IActionResult ThrowError()
    {
        var error = new Exception(ResourceSetter.GetMessage("E_EXCEPTION"));

        return Ok(error.Message);
    }
}