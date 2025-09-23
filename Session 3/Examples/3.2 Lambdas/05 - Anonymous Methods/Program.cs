Func<int, DateTime, bool> func = delegate(int i, DateTime dt)
{
    bool isEven = i % 2 == 0;
    Console.WriteLine($"i={i}. Is even at {dt}: {isEven}");

    return isEven;
};

func(87, DateTime.Now);
