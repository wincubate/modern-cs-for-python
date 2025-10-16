using ShortR.Domain;

namespace ShortR.Application.Common.Interfaces.Persistence;

public interface IShortenedUrlRepository
{
    Task<bool> ExistsAsync(string code, CancellationToken cancellationToken = default);
    Task<ShortenedUrl?> GetByCodeAsync(string code, CancellationToken cancellationToken = default);
    Task AddAsync(ShortenedUrl shortenedUrl);
}
