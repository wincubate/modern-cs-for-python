using ShortR.Domain;

namespace ShortR.Application.Common.Interfaces.Persistence;

public interface IShortenedUrlRepository
{
    Task<bool> ExistsAsync(string code);
    Task<ShortenedUrl?> GetByCodeAsync(string code);
    Task AddAsync(ShortenedUrl shortenedUrl);
}
