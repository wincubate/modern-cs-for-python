Employee e = new();
//e.FirstName = "John";
//e.LastName = "Doe";

public class Employee
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private string Password { get; set; }
}

