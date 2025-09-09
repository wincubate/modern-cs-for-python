namespace ModernCS.Session2;

class InsufficientFundsException(BankAccount account, string? message = null, Exception? inner = null)
    : Exception(message, inner) 
{
    public BankAccount Account { get; } = account;
}
