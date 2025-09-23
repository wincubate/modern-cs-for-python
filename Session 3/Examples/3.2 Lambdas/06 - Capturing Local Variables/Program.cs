int i = 87;

Action<DateTime> func = delegate(DateTime dt)
{
    bool isEven = i % 2 == 0;
    Console.WriteLine($"i={i}. Is even at {dt}: {isEven}");

    i++;
};

func(DateTime.Now);
