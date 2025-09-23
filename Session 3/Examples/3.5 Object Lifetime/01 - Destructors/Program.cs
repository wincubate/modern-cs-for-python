int i = 0;

while(true)
{
    for (int counter = 0; counter < 10000; counter++)
    {
        A a = new(i);
        i++;
    }
    Console.Write(A.Counter);

    // Wait for next <ENTER>
    Console.ReadLine();
}


class A
{
    public static int Counter { get; private set; } = 0;
    public int X { get; }

    public A(int x)
    {
        //Console.WriteLine($"Creating on thread {Environment.CurrentManagedThreadId}");
        X = x;
        Counter++;
    }
    ~A()
    {
        //Console.WriteLine($"Finalizing on thread {Environment.CurrentManagedThreadId}");
        Counter--;
    }
}
