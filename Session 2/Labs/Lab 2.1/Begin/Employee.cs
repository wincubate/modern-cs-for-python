namespace ModernCs.Lab1_1;

abstract class Employee(string firstName, string lastName)
{
    private static int _nextEmployeeNumber = 100_000;
    public int Number { get; } = _nextEmployeeNumber++;

    public string FirstName { get; init; } = firstName;
    public string LastName { get; init; } = lastName;

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

    public abstract void Work();
}
