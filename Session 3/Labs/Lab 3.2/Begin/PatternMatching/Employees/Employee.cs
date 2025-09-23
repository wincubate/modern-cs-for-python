namespace ModernCS.Session3;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public override string ToString() => $"{FullName} [{this.GetType().Name}]";

    public Employee(string firstName, string lastName) =>
        (FirstName, LastName) = (firstName, lastName);

    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }
}
