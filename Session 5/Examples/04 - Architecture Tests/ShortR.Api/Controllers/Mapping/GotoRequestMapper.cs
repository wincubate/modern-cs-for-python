using ShortR.Application.Queries.Goto;

namespace ShortR.Api.Controllers.Mapping;

internal static class GotoRequestMapper
{
    public static GotoQuery MapFrom(this string code) =>
        new()
        {
            Code = code
        };

    public static string MapTo(this GotoQueryResult queryResult) =>
        queryResult.LongUri.ToString();
}
