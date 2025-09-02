Console.WriteLine(Calculator.Add(42, 87));
Console.WriteLine(Calculator.Add(42, 87, 112));
Console.WriteLine(Calculator.Add(9.7, 0.1));

class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Add(int x, int y, int z)
    {
        return x + y + z;
    }
    public static double Add(double a, double b)
    {
        return a + b;
    }
}