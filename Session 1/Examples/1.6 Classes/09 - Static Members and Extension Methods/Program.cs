int i = 87;

Console.WriteLine(i.IsEven());
Console.WriteLine(IntExtensions.IsEven(i));

static class IntExtensions
{
    public static bool IsEven(this int i)
    {
        return i % 2 == 0;
    }
}

