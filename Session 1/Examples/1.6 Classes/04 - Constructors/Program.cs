Employee e = new("John", "Doe");

class Employee(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public Employee() : this(string.Empty, string.Empty)
    {        
    }
}

