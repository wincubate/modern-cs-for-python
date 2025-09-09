Divide(87, 42);

static void Divide(int x, int y)
{
    int result;
    try
    {
        result = x / y;
        Console.WriteLine($"Your answer is {result}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine($"Please make '{nameof(y)}' non-zero");
    }
    catch
    {
        Console.WriteLine("Something went wrong");
    }
    finally
    {
        Console.WriteLine("Aaaaand... We're done!");
    }
}
