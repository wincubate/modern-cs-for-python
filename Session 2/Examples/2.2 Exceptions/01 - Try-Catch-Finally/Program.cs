using ModernCS.Session2;

BankAccount from = Bank.CreateAccount(100);
BankAccount to = Bank.CreateAccount(100);

try
{
    Bank.TransferFunds(from, 50, to);
    Console.WriteLine("Successfully transferred funds");
}
catch (InsufficientFundsException exception)
{
    Console.WriteLine($"Only {exception.Account.Balance} in account");
    //throw;
}
//catch (Exception exception) // Generic
//{
//    Console.WriteLine("Something unexpected went wrong");
//}
finally
{
    Console.WriteLine("Done processing transaction...");
}
