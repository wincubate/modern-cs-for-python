using System.Numerics;

Point<int> point = new(42, 87);
Person person = new("John", 19);

struct Point<T>(T x, T y) where T : INumber<T>
{
    public T X { get; private set; } = x;
    public T Y { get; private set; } = y;
}

class Person(string firstName, int? age = null)
{
    public string? FirstName { get; private set; } = firstName;
    public int? Age { get; private set; } = age;
}

