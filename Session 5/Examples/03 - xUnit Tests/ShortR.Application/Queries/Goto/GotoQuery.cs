using MediatR;

namespace ShortR.Application.Queries.Goto;

public record class GotoQuery : IRequest<GotoQueryResult>
{
    public required string Code { get; init; }
}
