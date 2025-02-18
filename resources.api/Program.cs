using resources.api.Middleware;
using resources.lib.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILocalizationService, LocalizationService>();
builder.Services.AddControllers();

var app = builder.Build();

// app.UseRequestLocalization(new RequestLocalizationOptions {
//     ApplyCurrentCultureToResponseHeaders = true });

app.UseMiddleware<LocalizationMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();