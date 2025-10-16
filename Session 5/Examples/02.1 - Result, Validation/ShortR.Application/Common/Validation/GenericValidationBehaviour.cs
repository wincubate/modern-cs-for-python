using ErrorOr;
using FluentValidation;
using FluentValidation.Results;
using MediatR;

namespace ShortR.Application.Common.Validation;

internal class GenericValidationBehaviour<TRequest, TResponse> :
    IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : IErrorOr
{
    private readonly IValidator<TRequest>? _validator;

    public GenericValidationBehaviour(IValidator<TRequest>? validator = null)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validator is not null)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(request, cancellationToken);
            if (validationResult.IsValid is false)
            {
                return (dynamic)validationResult.Errors
                    .ConvertAll(error => Error.Validation(
                        code: error.PropertyName,
                        description: error.ErrorMessage
                    ));
            }
        }

        return await next();
    }
}
