using ShortR.Domain;

namespace ShortR.Application;

public interface IShortenCommandService
{
    Task<ShortenedUrl> ShortenAsync(string code, string longUrl);
}
