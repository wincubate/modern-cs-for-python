using ShortR.Domain;

namespace ShortR.Application.Commands.Shorten;

public record class ShortenCommandResult
{
    public required ShortenedUrl ShortenedUrl { get; init; }
}
