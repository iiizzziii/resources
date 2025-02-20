using System.ComponentModel.DataAnnotations;
using resources.api.Services;
using resources.lib.Resources;

namespace resources.api.Models;

public class LocalizedRequiredAttribute/*(string key)*/ : RequiredAttribute
{
    public override string FormatErrorMessage(string member)
    {
        // return ResourceSetter.GetMessage(key);
        return Messages.E_VALIDATION;
    }
}