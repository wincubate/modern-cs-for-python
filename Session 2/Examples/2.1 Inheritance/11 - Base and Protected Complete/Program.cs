using System.Diagnostics.CodeAnalysis;

SoftwareEngineer se = new("John", "Doe", 25763);
//Console.WriteLine(se.CodeLinesProduced);


class Employee
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
}