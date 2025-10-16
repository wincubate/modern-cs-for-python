using ErrorOr;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShortR.Application.Common.Validation;

namespace ShortR.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddValidatorsFromAssemblyContaining(typeof(DependencyInjection))
            .AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
                cfg.AddOpenBehavior(typeof(GenericValidationBehaviour<,>));
            })
        ;
        return services;
    }
}
