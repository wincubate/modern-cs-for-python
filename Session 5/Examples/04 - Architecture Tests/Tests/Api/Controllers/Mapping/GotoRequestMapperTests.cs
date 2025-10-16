using ShortR.Api.Controllers.Mapping;
using ShortR.Application.Queries.Goto;

namespace Tests.Api.Controllers.Mapping;

public class GotoRequestMapperTests
{
    [Fact]
    public void MapFrom_IsCorrect()
    {
        // Arrange
        string inputCode = "duplo";

        // Act
        GotoQuery actual = inputCode.MapFrom();

        // Assert
        GotoQuery expected = new()
        {
            Code = "duplo"
        };
        Assert.Equal(expected, actual);
    }
}