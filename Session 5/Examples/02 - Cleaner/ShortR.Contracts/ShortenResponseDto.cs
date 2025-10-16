using System.Text.Json.Serialization;

namespace ShortR.Contracts;

public record class ShortenResponseDto
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("resultingUrl")]
    public required string ResultingUrl { get; init; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }
}
