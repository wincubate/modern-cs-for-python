Employee employee1 = new()
{
    FirstName = "John",
    LastName = "Doe"
};
Console.WriteLine(employee1.Number);

Employee employee2 = new()
{
    FirstName = "Jane",
    LastName = "Doe"
};
Console.WriteLine(employee2.Number);

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
