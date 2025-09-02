Money m1 = new()
{
    Euro = 1,
    Cents = 25
};
Money m2 = new()
{
    Euro = 1,
    Cents = 25
};

Console.WriteLine(m1.Equals(m2));

readonly struct Money
{
    public int Euro { get; init; }
    public int Cents { get; init; }

    public override string ToString()
    {
        return $"EUR {Euro}.{Cents:d2}";   
    }
}