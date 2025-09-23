namespace ModernCS.Session3;

public record Employee(string FirstName, string LastName)
{
    public string FullName => $"{FirstName} {LastName}";

    public override string ToString() => $"{FullName} [{this.GetType().Name}]";
}
