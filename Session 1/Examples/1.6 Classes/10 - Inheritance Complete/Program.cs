SoftwareEngineer se = new()
{
    FirstName = "John",
    LastName = "Doe",
    CodeLinesProduced = 25763
};
Console.WriteLine(se.CodeLinesProduced);


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
}

class SoftwareEngineer : Employee
{
    public int CodeLinesProduced { get; set; }
}