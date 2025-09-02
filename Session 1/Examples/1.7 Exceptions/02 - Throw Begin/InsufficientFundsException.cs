namespace ModernCS.Session1;

class InsufficientFundsException(BankAccount account, string? message = null, Exception? inner = null)
    : Exception(message, inner) 
{
    public BankAccount Account { get; } = account;
}
