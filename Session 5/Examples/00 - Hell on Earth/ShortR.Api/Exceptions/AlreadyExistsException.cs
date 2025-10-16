namespace ShortR.Api.Exceptions;

public class AlreadyExistsException(string code, string? message = null, Exception? inner = null)
    : Exception(message, inner)
{
    public string Code { get; } = code;
}
