using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using resources.api.Models;
using resources.lib.Resources;

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
            ResourceLanguage = Messages.LANGUAGE,
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
        var error = new Exception(Messages.E_EXCEPTION);

        var response = new
        {
            ErrorMessage = error.Message,
            CurrentCulture = CultureInfo.CurrentCulture.DisplayName
        };
        
        return Ok(response);
    }
}