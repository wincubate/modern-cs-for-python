namespace ModernCS.Session3;

public class ProjectManager : Employee
{
    public Level? Level { get; set; }
    public string? Team { get; set; }

    public ProjectManager(
        string firstName,
        string lastName,
        Level? level = default,
        string? team = default
    ) : base(firstName, lastName)
    {
        Level = level;
        Team = team;
    }

    public void Deconstruct(
        out string firstName, 
        out string lastName,
        out Level? level,
        out string? team
    )
    {
        Deconstruct(out firstName, out lastName);

        level = Level;
        team = Team;
    }
}