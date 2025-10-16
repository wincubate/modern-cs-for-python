using ShortR.Api.Domain;

namespace ShortR.Api.Persistence;

internal class InMemoryShortenedUrlRepository : IShortenedUrlRepository
{
    private static HashSet<ShortenedUrl> _shortenedUrls = [];

    public Task<bool> ExistsAsync(string code)
    {
        return Task.FromResult(_shortenedUrls
            .Any(shortenedUrl => shortenedUrl.Code == code)
        );
    }

    public Task<ShortenedUrl?> GetByCodeAsync(string code)
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
