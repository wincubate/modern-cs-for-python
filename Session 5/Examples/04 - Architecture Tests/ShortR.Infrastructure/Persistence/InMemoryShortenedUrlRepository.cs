using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Domain;

namespace ShortR.Infrastructure.Persistence;

internal class InMemoryShortenedUrlRepository : IShortenedUrlRepository
{
    private static HashSet<ShortenedUrl> _shortenedUrls = [];

    public Task<bool> ExistsAsync(string code, CancellationToken cancellationToken)
    {
        return Task.FromResult(_shortenedUrls
            .Any(shortenedUrl => shortenedUrl.Code == code)
        );
    }

    public Task<ShortenedUrl?> GetByCodeAsync(string code, CancellationToken cancellationToken)
    {
        return Task.FromResult(_shortenedUrls
            .SingleOrDefault(shortenedUrl => shortenedUrl.Code == code)
        );
    }

    public Task AddAsync(ShortenedUrl shortenedUrl)
    {
        _shortenedUrls.Add(shortenedUrl);

        return Task.CompletedTask;
    }
}
