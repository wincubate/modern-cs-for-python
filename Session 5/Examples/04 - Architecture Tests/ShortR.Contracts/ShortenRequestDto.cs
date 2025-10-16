using System.Text.Json.Serialization;

namespace ShortR.Contracts;

public record class ShortenRequestDto
{
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    [JsonPropertyName("longUrl")]
    public required string LongUrl { get; init; }
}
