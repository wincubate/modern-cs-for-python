using ShortR.Api.Domain;

namespace ShortR.Api.Persistence;

public interface IShortenedUrlRepository
{
    Task<bool> ExistsAsync(string code);
    Task<ShortenedUrl?> GetByCodeAsync(string code);
    Task AddAsync(ShortenedUrl shortenedUrl);
}
