using ModernCS.Session1;

BankAccount from = Bank.CreateAccount(100);
BankAccount to = Bank.CreateAccount(100);

try
{
    Bank.TransferFunds(from, 200, to);
    Console.WriteLine("Successfully transferred funds");
}
catch (BankException exception)
{
    Console.WriteLine(exception.StackTrace);
}
