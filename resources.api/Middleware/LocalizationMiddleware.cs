using resources.lib.Services;

namespace resources.api.Middleware;

public class LocalizationMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(
        HttpContext context,
        ILocalizationService localizationService)
    {
        var callerCulture = context.Request.Headers.AcceptLanguage.ToString();
        
        localizationService.SetCurrentCulture(callerCulture);
        
        await next(context);
    }
}