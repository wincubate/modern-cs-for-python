Student s = new("Jane");
Console.WriteLine(s.Name);

public class Student
{
    private static IDictionary<Guid, string> Names = new Dictionary<Guid, string>();

    private readonly Guid _id = Guid.NewGuid();

    public Student(string name)
    {
        Names.Add(_id, name);
    }

    public string Name => Names[_id];
}

//public class Student
//{
//    private static IDictionary<Guid, string> Names = new Dictionary<Guid, string>();

//    private readonly Guid _id = Guid.NewGuid();

//    public Student(string name) =>
//        Names.Add(_id, name);

//    public string Name
//    {
//        get => Names[_id];
//        set => Names[_id] = value;
//    }
//}
