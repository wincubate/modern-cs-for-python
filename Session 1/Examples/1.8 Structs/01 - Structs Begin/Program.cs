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

struct Money
{
    public int Euro { get; set; }
    public int Cents { get; set; }

    public override string ToString()
    {
        return $"EUR {Euro}.{Cents:d2}";   
    }
}