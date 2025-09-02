namespace ModernCS.Session1;

class BankException(string? message = null, Exception? inner = null)
    : Exception(message, inner)
{
}
