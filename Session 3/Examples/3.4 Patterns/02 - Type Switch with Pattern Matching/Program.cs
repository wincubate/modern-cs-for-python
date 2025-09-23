using ModernCS.Session3;

EmployeeRepository repository = new();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee e in all)
{
    switch (e)
    {
        case SoftwareArchitect sa:
            Console.WriteLine($"{sa.FullName} plays with Miro");
            break;

        case SoftwareEngineer se:
            Console.WriteLine($"{se.FullName} has a fun job coding all day");
            break;

        case null:
        default:
            break;
    }

    #region when

    //case SoftwareEngineer se when se.Level == SoftwareEngineerLevel.Lead:
    //    WriteLine($"{se.FullName} is a lead software engineer");
    //    break;

    #endregion
}
