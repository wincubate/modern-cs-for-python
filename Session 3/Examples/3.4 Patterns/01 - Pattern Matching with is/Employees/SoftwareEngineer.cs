namespace ModernCS.Session3;

public record SoftwareEngineer(
    string FirstName,
    string LastName,
    Level? Level = default,
    int CodeLinesProduced = 0)
: Employee(FirstName,LastName)
{
    public override string ToString() => base.ToString();
}