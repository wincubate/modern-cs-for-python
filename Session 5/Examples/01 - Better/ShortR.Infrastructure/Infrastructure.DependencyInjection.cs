using Microsoft.Extensions.DependencyInjection;
using ShortR.Application.Common.Interfaces.Persistence;
using ShortR.Application.Common.Interfaces.Time;
using ShortR.Infrastructure.Persistence;
using ShortR.Infrastructure.Time;

namespace ShortR.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services
            .AddSingleton<IShortenedUrlRepository, InMemoryShortenedUrlRepository>()
            .AddTransient<ISystemClock,DefaultSystemClock>()
            ;

        return services;
    }
}
