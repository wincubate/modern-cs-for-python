namespace ModernCS.Session3;

public class EmployeeRepository
{
    private readonly IList<Employee> _employees;

    public EmployeeRepository()
    {
        Employee bora = new SoftwareArchitect
        (
            "Bo", "Rammstein", Level.Senior, 87
        );
        Employee jlm = new SoftwareEngineer
        (
            "Jørgen",
            "Leth Mortensen",
            Level.Senior,
            299992
        );
        Employee jth = new SoftwareEngineer
        (
            "Jørgen",
            "Thestrup",
            Level.Senior,
            411119
        );
        Employee uh = new SoftwareArchitect
        (
            "Ulrik",
            "Holm",
            Level.Senior,
            42
        );
        Employee lula = new SoftwareEngineer
        (
            "Luna",
            "Ladefoged",
            Level.Chief,
            90800
        );
        Employee mtt = new ProjectManager
        (
            "Miles",
            "Ton Taka",
            Level.Senior,
            "Banzai Raccoons"
        );
        Employee nasp = new ProjectManager
        (
            "Naja",
            "Split",
            Level.Chief,
            "Punching Pumpkins"
        );
        Employee pne = new StudentProgrammer
        (
            "Peter",
            "Nefa",
            jth
        );
        Employee apaa = new StudentProgrammer
        (
            "Anders",
            "Paaske",
            bora
        );
        Employee nby = new StudentProgrammer
        (
            "Nora",
            "Byskov",
            lula
        );
        Employee jegu = new SoftwareEngineer
        (
            "Jesper",
            "Gulmann Henriksen",
            Level.Lead,
            176
        );

        _employees = new List<Employee>
        {
            bora, jlm, jth, uh, lula, mtt, nasp, pne, apaa, nby, jegu
        };
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employees.ToList();
    }

    public void Add( Employee employee ) =>
        _employees.Add(employee ?? throw new ArgumentNullException(nameof(employee)));
}
