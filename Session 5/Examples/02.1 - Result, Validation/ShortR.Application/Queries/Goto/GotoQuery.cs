using ErrorOr;
using MediatR;

namespace ShortR.Application.Queries.Goto;

public record class GotoQuery : IRequest<ErrorOr<GotoQueryResult>>
{
    public required string Code { get; init; }
}
