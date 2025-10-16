using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShortR.Api.Controllers.Mapping;
using ShortR.Application.Common.Exceptions;
using ShortR.Contracts;

namespace ShortR.Api.Controllers;

[ApiController]
public class ShortenController : ControllerBase
{
    private readonly ILogger<ShortenController> _logger;
    private readonly IMediator _mediator;

    public ShortenController(
        ILogger<ShortenController> logger,
        IMediator mediator
    )
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost("/shorten")]
    public async Task<IActionResult> ShortenAsync(ShortenRequestDto requestDto)
    {
        try
        {
            var command = requestDto.MapFrom();
            var commandResult = await _mediator.Send(command);
            var (resource, responseDto) = commandResult.MapTo();
        
            return Created(resource, responseDto);
        }
        catch(AlreadyExistsException exception)
        {
            return Problem(
                statusCode: StatusCodes.Status409Conflict,
                title: $"A shortened URL already exists for '{exception.Code}'"
            );
        }
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code, CancellationToken cancellationToken = default)
    {
        try
        {
            var query = code.MapFrom();
            var queryResult = await _mediator.Send(query, cancellationToken);
            string redirectTo = queryResult.MapTo();    

            return Redirect(redirectTo);
        }
        catch(NotFoundException exception)
        {
            return Problem(
                statusCode: StatusCodes.Status404NotFound,
                title: $"No shortened URL exists for '{exception.Code}'"
            );
        }
    }
}
