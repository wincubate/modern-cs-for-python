using ShortR.Application.Commands.Shorten;
using ShortR.Contracts;

namespace ShortR.Api.Controllers.Mapping;

internal static class ShortenRequestMapper
{
    public static ShortenCommand MapFrom(this ShortenRequestDto requestDto) =>
        new()
        {
            Code = requestDto.Code,
            LongUrl = requestDto.LongUrl
        };

    public static (string resource, ShortenResponseDto dto) MapTo(this ShortenCommandResult commandResult)
    {
        string resource = commandResult.ShortenedUrl.ShortUri.ToString();
        var responseDto = new ShortenResponseDto
        {
            Id = commandResult.ShortenedUrl.Id.ToString(),
            ResultingUrl = commandResult.ShortenedUrl.LongUri.ToString(),
            Created = commandResult.ShortenedUrl.Created
        };

        return (resource, responseDto);
    }
}
