namespace ShortR.Api.Domain;

public record class ShortenedUrl
{
    public required Guid Id { get; init; }
    public required Uri LongUri { get; init; }
    public required string Code { get; init; }
    public required Uri ShortUri { get; init; }
    public DateTime? Created { get; init; }
}
