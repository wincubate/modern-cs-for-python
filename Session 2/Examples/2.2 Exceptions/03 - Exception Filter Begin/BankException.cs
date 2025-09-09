namespace ModernCS.Session2;

class BankException(string? message = null, Exception? inner = null)
    : Exception(message, inner)
{
}
