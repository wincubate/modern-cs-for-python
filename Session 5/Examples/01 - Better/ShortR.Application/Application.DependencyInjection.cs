using Microsoft.Extensions.DependencyInjection;

namespace ShortR.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddTransient<IShortenCommandService, ShortenCommandService>()
            .AddTransient<IShortenQueryService, ShortenQueryService>()
            ;
        return services;
    }
}
