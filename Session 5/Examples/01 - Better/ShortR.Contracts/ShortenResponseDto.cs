namespace ShortR.Contracts;

public record class ShortenResponseDto
{
    public required string Id { get; init; }
    public required string ResultingUrl { get; init; }
    public DateTime? Created { get; set; }
}
