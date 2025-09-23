
Task task1 = Task.Run(() =>
{
    for (int i = 0; i < 100; i += 2)
    {
        Console.WriteLine(i);
    }
});

Task task2 = new(() =>
{
    for (int i = 1; i < 100; i += 2)
    {
        Console.WriteLine("\t" + i);
    }
});
task2.Start();

Console.ReadLine();