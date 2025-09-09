Point<int> pt1 = Point<int>.Zero;
Console.WriteLine(pt1.X);
Console.WriteLine(pt1.Y);

//Point<double> pt2 = new(11.2, 8.7);
//Console.WriteLine(pt2);

readonly struct Point<T> where T : struct
{
    public T X { get; init; }
    public T Y { get; init; }

    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }

    public static Point<T> Zero
    {
        get
        {
            return new(default, default);
        }
    }
}
