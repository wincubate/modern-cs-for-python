using ModernCS.Session3;

EmployeeRepository repository = new();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee employee in all)
{
    string description = Evaluate(employee as SoftwareEngineer);
    Console.WriteLine($"{employee.FullName} - {description}");
}

static string Evaluate(SoftwareEngineer? se) =>
    se switch
    {
        { Level: Level.Lead } => $"{se.FullName} does great work",
        { Level: Level.Chief } => $"You da boss, {se.FullName}",
        null => "You're not even a software engineer, dude!",
        _ => $"Well done coding SOLID, {se.Level}... :-)"
    };

//static void HailTheKing(Employee employee)
//{
//    if (employee is SoftwareEngineer { Level: Level.Chief, FullName: "Uncle Bob" })
//    {
//        Console.WriteLine("All hail to the king");
//    }
//}
