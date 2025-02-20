using System.Globalization;
using System.Resources;
using resources.lib.Resources;

namespace resources.api.Services;

[Obsolete("use direct call: Class.Key")]
public static class ResourceSetter
{
    private static readonly ResourceManager ResourceManager = new(
        "resources.lib.Resources.Messages", 
        typeof(Messages).Assembly);

    public static string GetMessage(string key)
    {
        return ResourceManager.GetString(key, CultureInfo.CurrentCulture) 
               ?? 
               $"[{key} not found]";
    }
}