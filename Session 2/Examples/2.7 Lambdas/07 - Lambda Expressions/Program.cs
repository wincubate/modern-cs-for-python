int i = 87;

Action<DateTime> func = dt =>
{
    bool isEven = i % 2 == 0;
    Console.WriteLine($"i={i}. Is even at {dt}: {isEven}");

    i++;
};
func(DateTime.Now);

//int[] numbers = [42, 87, 112, 176, 256];
//foreach (var item in Array.FindAll(numbers, i => i > 87))
//{
//    Console.WriteLine(item);
//}

//Func<int, bool> isEven = i => i % 2 == 0;
