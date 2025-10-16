using FluentValidation;

namespace ShortR.Application.Commands.Shorten;

public class ShortenCommandValidator : AbstractValidator<ShortenCommand>
{
    public ShortenCommandValidator()
    {
        RuleFor(command => command.Code)
            .MinimumLength(5)
            .MaximumLength(30)
            ;
        RuleFor(command => command.LongUrl)
            .Matches(@"\w+:(\/?\/?)[^\s]+")
            ;
    }
}
