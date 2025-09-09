Point<int> pt1 = new(42, 87);
Console.WriteLine(pt1);

Point<double> pt2 = new(11.2, 8.7);
Console.WriteLine(pt2);

readonly struct Point<T>
{
    public T X { get; init; }
    public T Y { get; init; }

    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }
}
