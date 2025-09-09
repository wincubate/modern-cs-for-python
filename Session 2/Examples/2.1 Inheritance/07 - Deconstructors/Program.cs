Employee employee = new()
{
    FirstName = "John",
    LastName = "Doe"
};

(string firstName, string lastName) = employee;
Console.WriteLine(firstName);


class Employee
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
}

