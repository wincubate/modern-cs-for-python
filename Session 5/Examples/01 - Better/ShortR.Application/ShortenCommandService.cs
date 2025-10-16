using ShortR.Application.Common.Exceptions;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Application.Common.Interfaces.Time;
using ShortR.Domain;

namespace ShortR.Application;

internal class ShortenCommandService : IShortenCommandService
{
    private readonly Uri HOST = new("https://localhost:7044/goto/");

    private readonly IShortenedUrlRepository _repository;
    private readonly ISystemClock _systemClock;

    public ShortenCommandService(
        IShortenedUrlRepository repository,
        ISystemClock systemClock
    )
    {
        _repository = repository;
        _systemClock = systemClock;
    }

    public async Task<ShortenedUrl> ShortenAsync(string code, string longUrl)
    {
        if (await _repository.ExistsAsync(code))
        {
            string message = $"Code already exists as shortened URL";
            throw new AlreadyExistsException(code, message);
        }

        var shortenedUrl = new ShortenedUrl
        {
            Id = Guid.NewGuid(),
            Code = code,
            LongUri = new Uri(longUrl),
            ShortUri = new Uri(HOST, code),
            Created = _systemClock.UtcNow
        };
        await _repository.AddAsync(shortenedUrl);

        return shortenedUrl;
    }
}
