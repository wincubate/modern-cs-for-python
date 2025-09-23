using ModernCS.Session3;

////////////////////////////////////////////////////
// a)
// Write the Code Production Index for each employee
////////////////////////////////////////////////////
foreach (var employee in new EmployeeRepository().GetAll())
{
    int codeIndex = employee switch
    {
        SoftwareArchitect sa => sa.VisioDrawingsProduced * 250,
        SoftwareEngineer se => se.CodeLinesProduced,
        _ => 0
    };
    Console.WriteLine($"{employee.FullName}: {codeIndex}");
}

////////////////////////////////////////////////////////////////
// b)
// All student programmers mentored by a chief software engineer
////////////////////////////////////////////////////////////////
IEnumerable<StudentProgrammer> studentProgrammers = new EmployeeRepository()
    .GetAll()
    .Where(e => e is StudentProgrammer
    { 
        MentoredBy: SoftwareEngineer 
        { 
            Level: Level.Chief 
        } 
    })
    .OfType<StudentProgrammer>()
    ;

foreach (var employee in studentProgrammers)
{
    Console.WriteLine(employee);
}
