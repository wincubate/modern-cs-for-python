using MediatR;
using ShortR.Application.Common.Exceptions;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Application.Common.Interfaces.Time;
using ShortR.Domain;

namespace ShortR.Application.Commands.Shorten;

internal class ShortenCommandHandler : IRequestHandler<ShortenCommand, ShortenCommandResult>
{
    private readonly Uri HOST = new("https://localhost:7044/goto/");

    private readonly IShortenedUrlRepository _repository;
    private readonly ISystemClock _systemClock;

    public ShortenCommandHandler(
        IShortenedUrlRepository repository,
        ISystemClock systemClock
    )
    {
        _repository = repository;
        _systemClock = systemClock;
    }

    public async Task<ShortenCommandResult> Handle(ShortenCommand command, CancellationToken cancellationToken)
    {
        if (await _repository.ExistsAsync(command.Code))
        {
            string message = $"Code already exists as shortened URL";
            throw new AlreadyExistsException(command.Code, message);
        }

        var shortenedUrl = new ShortenedUrl
        {
            Id = Guid.NewGuid(),
            Code = command.Code,
            LongUri = new Uri(command.LongUrl),
            ShortUri = new Uri(HOST, command.Code),
            Created = _systemClock.UtcNow
        };
        await _repository.AddAsync(shortenedUrl);

        var commandResult = new ShortenCommandResult
        { 
            ShortenedUrl = shortenedUrl 
        };

        return commandResult;
    }
}
