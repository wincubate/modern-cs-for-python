using NSubstitute;
using ShortR.Application.Common.Exceptions;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Application.Queries.Goto;
using ShortR.Domain;

namespace Tests.Application.Queries.Goto;

public class GotoQueryHandlerTests
{
    private IShortenedUrlRepository _mockRepository;

    public GotoQueryHandlerTests()
    {
        var mockRepository = Substitute.For<IShortenedUrlRepository>();
        mockRepository
            .GetByCodeAsync("mariokart", Arg.Any<CancellationToken> ())
            .Returns(new ShortenedUrl()
            {
                Code = "mariokart",
                Id = Guid.Parse("0199d8d4-32df-75ff-b0aa-8e45e89c5097"),
                LongUri = new("https://www.lego.com/en-dk/product/mario-kart-mario-standard-kart-72037"),
                ShortUri = new("https://localhost:7044/goto/mariokart")
            })
            ;
            
        _mockRepository = mockRepository;
    }

    
    [Fact]
    public async Task Handle_ReturnsCorrectShortenedUrl_WhenCodeExists()
    {
        // Arrange
        GotoQueryHandler sut = new(_mockRepository);

        GotoQuery queryInput = new()
        {
            Code = "mariokart"
        };

        // Act
        GotoQueryResult actual = await sut.Handle(queryInput, CancellationToken.None);

        // Assert
        GotoQueryResult expected = new()
        {
            LongUri = new("https://www.lego.com/en-dk/product/mario-kart-mario-standard-kart-72037"),
        };
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task Handle_Throws_WhenCodeDoesNotExist()
    {
        GotoQueryHandler sut = new(_mockRepository);

        GotoQuery queryInput = new()
        { 
            Code = "doesnotexist" 
        };

        // Act
        NotFoundException exception = await Assert.ThrowsAsync<NotFoundException>(async () =>
        {
            await sut.Handle(queryInput, CancellationToken.None);
        });

        // Assert
        Assert.Contains(exception.Code, "doesnotexist");
    }
}