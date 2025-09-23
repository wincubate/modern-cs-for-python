Person p1 = new()
{
    FirstName = "John",
    LastName = "Doe"
};
Person p2 = new()
{
    FirstName = "John",
    LastName = "Doe"
};

Dictionary<Person, int> dictionary = new()
{
    [p1] = 42
};

Console.WriteLine(dictionary[p2]);

class Person // : IEquatable<Person>
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    //public bool Equals(Person? other) => other != null &&
    //    FirstName == other.FirstName &&
    //    LastName == other.LastName;

    //public override bool Equals(object? obj)
    //{
    //    Person? other = obj as Person;
    //    if (other != null)
    //    {
    //        return
    //            FirstName == other!.FirstName &&
    //            LastName == other!.LastName;
    //    }
    //    return false;
    //}

    //public override int GetHashCode() => (FirstName, LastName).GetHashCode();
}