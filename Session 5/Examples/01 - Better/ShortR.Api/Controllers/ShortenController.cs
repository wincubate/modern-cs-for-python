using Microsoft.AspNetCore.Mvc;
using ShortR.Application;
using ShortR.Contracts;
using ShortR.Domain;

namespace ShortR.Api.Controllers;

[ApiController]
public class ShortenController : ControllerBase
{
    private readonly ILogger<ShortenController> _logger;
    private readonly IShortenCommandService _shortenCommandService;
    private readonly IShortenQueryService _shortenQueryService;

    public ShortenController(
        ILogger<ShortenController> logger,
        IShortenCommandService shortenCommandService,
        IShortenQueryService shortenQueryService
    )
    {
        _logger = logger;
        _shortenCommandService = shortenCommandService;
        _shortenQueryService = shortenQueryService;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenAsync(ShortenRequestDto requestDto)
    {
        string resource = $"https://localhost:7044/goto/{requestDto.Code}";

        var shortenedUrl = await _shortenCommandService.ShortenAsync(
            requestDto.Code,
            requestDto.LongUrl
        );

        var response = new ShortenResponseDto
        {
            Id = shortenedUrl.Id.ToString(),
            ResultingUrl = shortenedUrl.LongUri.ToString(),
            Created = shortenedUrl.Created
        };
        return Created(resource, response);
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code)
    {
        Uri uri = await _shortenQueryService.LookupAsync(code);

        return Redirect(uri.ToString());
    }
}
