namespace ShortR.Application;

public interface IShortenQueryService
{
    Task<Uri> LookupAsync(string code);
}
