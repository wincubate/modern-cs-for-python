using System.Diagnostics.CodeAnalysis;

Employee e = new("John", "Doe");

class Employee
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public Employee()
    {        
    }

    [SetsRequiredMembers] // <-- "Attribute" - not to be mistaken with Python "attributes"
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

