namespace ModernCS.Session1;

static class Bank
{
    public static BankAccount CreateAccount(decimal initialAmount)
    {
        return new BankAccount(initialAmount);
    }

    public static void TransferFunds(BankAccount from, decimal amount, BankAccount to)
    {
        try
        {
            from.Withdraw(amount);
            to.Deposit(amount);
        }
        catch (InsufficientFundsException exception)
        {
            Console.WriteLine($"Only {exception.Account.Balance} in account");
            throw;
        }
        catch (Exception exception)
        {
            Console.WriteLine("Something unexpected went wrong");
            throw new BankException("Could not complete transfer", exception);
        }
    }
}
