class Person(string firstName, int? age = null)
{
    public string? FirstName { get; private set; } = firstName;
    public int? Age { get; private set; } = age;
}