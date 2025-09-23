namespace ModernCS.Session3;

public class StudentProgrammer : Employee
{
    public Employee MentoredBy { get; set; }

    public override string ToString() =>
        base.ToString() + ($" / Mentor: {MentoredBy}");

    public StudentProgrammer(
        string firstName,
        string lastName,
        Employee mentoredBy
    ) : base(firstName, lastName)
    {
        MentoredBy = mentoredBy;
    }
}
