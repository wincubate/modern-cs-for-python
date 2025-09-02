Console.WriteLine(Sum(42, 87));

int Sum(params int[] values)
{
    int total = 0;
    foreach (int i in values)
    {
        total += i;
    }
    return total;
}