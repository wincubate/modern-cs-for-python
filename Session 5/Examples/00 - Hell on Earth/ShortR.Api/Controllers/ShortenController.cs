using Microsoft.AspNetCore.Mvc;
using ShortR.Api.Contracts;
using ShortR.Api.Domain;
using ShortR.Api.Exceptions;
using ShortR.Api.Persistence;

namespace ShortR.Api.Controllers;

[ApiController]
public class ShortenController : ControllerBase
{
    private readonly ILogger<ShortenController> _logger;
    private readonly IShortenedUrlRepository _repository;

    private readonly Uri HOST = new("https://localhost:7044/goto/");

    public ShortenController(
        ILogger<ShortenController> logger,
        IShortenedUrlRepository repository
    )
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenAsync(ShortenRequestDto requestDto)
    {
        string code = requestDto.Code;
        string resource = $"https://localhost:7044/goto/{code}";

        if (await _repository.ExistsAsync(code))
        {
            string message = $"Code already exists as shortened URL";
            throw new AlreadyExistsException(code, message);
        }

        string longUrl = requestDto.LongUrl;
        var shortenedUrl = new ShortenedUrl
        {
            Id = Guid.NewGuid(),
            Code = code,
            LongUri = new Uri(longUrl),
            ShortUri = new Uri(HOST, code),
            Created = DateTime.Now // <-- Argh!
        };
        await _repository.AddAsync(shortenedUrl);
        var result = new ShortenResponseDto
        {
            Id = Guid.NewGuid().ToString(),
            ResultingUrl = longUrl,
            Created = DateTime.Now // <-- Argh!
        };

        return Created(resource, result);
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code)
    {
        ShortenedUrl? shortenedUrl = await _repository.GetByCodeAsync(code);

        if (shortenedUrl is null)
        {
            string message = "Code does not exist as a shortened URL";
            throw new NotFoundException(code, message);
        }

        return Redirect(shortenedUrl.LongUri.ToString());
    }
}
