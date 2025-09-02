using System.Diagnostics.CodeAnalysis;

Employee se = new SoftwareEngineer("John", "Doe", 25763);
Console.WriteLine(se.ToString());
se.Work();
Console.WriteLine(se.ToString());

abstract class Employee
{
    private static int _nextEmployeeNumber = 100_000;
    public int Number { get; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public Employee()
    {
        Number = _nextEmployeeNumber++;
    }

    [SetsRequiredMembers]
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";   
    }

    public abstract void Work();
}

class SoftwareEngineer : Employee
{
    protected int CodeLinesProduced { get; set; }

    [SetsRequiredMembers]
    public SoftwareEngineer(string firstName, string lastName, int codeLineProduced = 0)
        : base(firstName, lastName)
    {
        CodeLinesProduced = codeLineProduced;
    }

    public override sealed string ToString()
    {
        return $"{base.ToString()} [{CodeLinesProduced} C# lines]";
    }

    public override void Work()
    {
        CodeLinesProduced += 487;
    }
}