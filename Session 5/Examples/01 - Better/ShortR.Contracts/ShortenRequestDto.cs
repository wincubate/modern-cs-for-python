namespace ShortR.Contracts;

public record class ShortenRequestDto
{
    public required string Code { get; init; }
    public required string LongUrl { get; init; }
}
