int x = 42;
Twice(x);
Console.WriteLine($"x={x}");

static void Twice(int x)
{
    x = 2 * x;
}

