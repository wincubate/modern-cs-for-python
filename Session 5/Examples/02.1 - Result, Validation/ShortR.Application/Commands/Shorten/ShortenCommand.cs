using ErrorOr;
using MediatR;

namespace ShortR.Application.Commands.Shorten;

public record class ShortenCommand : IRequest<ErrorOr<ShortenCommandResult>>
{
    public required string Code { get; init; }
    public required string LongUrl { get; init; }
}
