using ShortR.Application.Common.Exceptions;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Domain;

namespace ShortR.Application;

internal class ShortenQueryService : IShortenQueryService
{
    private readonly IShortenedUrlRepository _repository;

    public ShortenQueryService(
        IShortenedUrlRepository repository
    )
    {
        _repository = repository;
    }

    public async Task<Uri> LookupAsync(string code)
    {
        ShortenedUrl? shortenedUrl = await _repository.GetByCodeAsync(code);

        if (shortenedUrl is null)
        {
            string message = "Code does not exist as a shortened URL";
            throw new NotFoundException(code, message);
        }

        return shortenedUrl.LongUri;
    }
}
