using System.Globalization;

namespace resources.lib.Services;

public class LocalizationService : ILocalizationService
{
    public void SetCurrentCulture(string culture)
    {
        const string defaultCulture = "en-GB";
        
        var cultureInfo = new CultureInfo(
            string.IsNullOrWhiteSpace(culture) 
                ? defaultCulture 
                : culture);

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;
    }
}