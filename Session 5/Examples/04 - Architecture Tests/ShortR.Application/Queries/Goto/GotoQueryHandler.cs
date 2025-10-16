using MediatR;
using ShortR.Application.Common.Exceptions;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Domain;

namespace ShortR.Application.Queries.Goto;

internal class GotoQueryHandler : IRequestHandler<GotoQuery, GotoQueryResult>
{
    private readonly IShortenedUrlRepository _repository;

    public GotoQueryHandler(IShortenedUrlRepository repository)
    {
        _repository = repository;
    }

    public async Task<GotoQueryResult> Handle(GotoQuery query, CancellationToken cancellationToken)
    {
        ShortenedUrl? shortenedUrl = await _repository.GetByCodeAsync(query.Code, cancellationToken);

        if (shortenedUrl is null)
        {
            string message = "Code does not exist as a shortened URL";
            throw new NotFoundException(query.Code, message);
        }

        var queryResult = new GotoQueryResult
        {
            LongUri = shortenedUrl.LongUri
        };
        return queryResult;
    }
}
