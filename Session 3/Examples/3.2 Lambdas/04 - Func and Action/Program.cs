//Func<int, DateTime, bool> func = C.Check;
//func(87, DateTime.Now);
Console.WriteLine();

class C
{
    public static bool Check(int i, DateTime dt)
    {
        bool isEven = i % 2 == 0;
        Console.WriteLine($"i={i}. Is even at {dt}: {isEven}");

        return isEven;
    }
}