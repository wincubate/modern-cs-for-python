namespace ModernCS.Session2;

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
        when (exception.Account.IsVIP)
        {
            Console.WriteLine("Don't worry, rich kid. We've got you covered!");

            // Handle VIP account...
        }
        catch (Exception exception)
        {
            Console.WriteLine("Something unexpected went wrong");
            throw new BankException("Could not complete transfer", exception);
        }
    }
}
