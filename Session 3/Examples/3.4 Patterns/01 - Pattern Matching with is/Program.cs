using ModernCS.Session3;

EmployeeRepository repository = new();
IEnumerable<Employee> all = repository.GetAll();

foreach (Employee e in all)
{
    //For software engineers:

    //Console.WriteLine($"{e.FullName} has produced {e.CodeLinesProduced} lines of C#");
}
