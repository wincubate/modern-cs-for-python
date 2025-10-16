using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShortR.Api.Controllers.Mapping;
using ShortR.Application.Commands.Shorten;
using ShortR.Application.Queries.Goto;
using ShortR.Contracts;

namespace ShortR.Api.Controllers;

public class ShortenController : ErrorOrApiControllerBase
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
        ShortenCommand command = requestDto.MapFrom();
        ErrorOr<ShortenCommandResult> errorOrCommandResult = await _mediator.Send(command);

        return errorOrCommandResult.Match(
            onValue: commandResult =>
            {
                var (resource, responseDto) = commandResult.MapTo();
                return Created(resource, responseDto);
            },
            onError: Problem
        );
    }

    [HttpGet("/goto/{code}")]
    public async Task<IActionResult> GotoAsync(string code, CancellationToken cancellationToken = default)
    {
        GotoQuery query = code.MapFrom();
        ErrorOr<GotoQueryResult> errorOrQueryResult = await _mediator.Send(query, cancellationToken);

        return errorOrQueryResult.Match(
            onValue: queryResult =>
            {
                string redirectTo = queryResult.MapTo();
                return Redirect(redirectTo);
            },
            onError: Problem
        );
    }
}
