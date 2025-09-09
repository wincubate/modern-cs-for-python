namespace ModernCS.Session2;

class InsufficientFundsException(BankAccount account, string? message = null, Exception? inner = null)
    : BankException(message, inner) 
{
    public BankAccount Account { get; } = account;
}
