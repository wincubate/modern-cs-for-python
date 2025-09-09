Console.WriteLine();

interface ICanBeEmpty<T>
{
    static abstract T Empty { get; }
}