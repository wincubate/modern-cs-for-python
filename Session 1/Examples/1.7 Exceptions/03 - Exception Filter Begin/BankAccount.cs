namespace ModernCS.Session1;

class BankAccount(decimal initialBalance)
{
    private static int s_NextAccountNumber;

    static BankAccount()
    {
        s_NextAccountNumber = 100000;
    }

    private static int GetNextAccountNumber()
    {
        return s_NextAccountNumber++;
    }

    public int AccountNumber { get; } = GetNextAccountNumber();

    public decimal Balance { get; private set; } = initialBalance;

    public bool IsVIP
    {
        get
        {
            return Balance >= 5_000_000;
        }
    }

    public BankAccount() : this(0)
    {
    }

    public override string ToString()
    {
        return $"Account Number {AccountNumber} containing {Balance}";
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InsufficientFundsException(this, "Could not complete withdrawal from account");
        }
    }
}
