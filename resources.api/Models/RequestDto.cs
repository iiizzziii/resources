namespace resources.api.Models;

#pragma warning disable CS8618

public class RequestDto
{
    // [LocalizedRequired("E_VALIDATION")]
    [LocalizedRequired]
    public string Body { get; init; }
}