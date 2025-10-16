namespace ShortR.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services
            .AddProblemDetails()
            .AddControllers()
            ;

        return services;
    }
}
