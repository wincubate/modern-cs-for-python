using System.Numerics;

ICanBeCleared point = new Point<int>(42, 87);
point.Clear();

ICanBeCleared person = new Person("John", 19);
person.Clear();

interface ICanBeCleared
{
    void Clear();
}

struct Point<T>(T x, T y) : ICanBeCleared
    where T : INumber<T>
{
    public T X { get; private set; } = x;
    public T Y { get; private set; } = y;

    public void Clear()
    {
        (X,Y) = (T.Zero, T.Zero);
    }
}

class Person(string firstName, int? age = null) : ICanBeCleared
{
    public string? FirstName { get; private set; } = firstName;
    public int? Age { get; private set; } = age;

    public void Clear()
    {
        FirstName = "<<No name>>";
        Age = null;
    }
}

