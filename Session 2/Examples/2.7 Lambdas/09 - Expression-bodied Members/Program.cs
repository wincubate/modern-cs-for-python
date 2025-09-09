Person ash = new() 
{ 
    FirstName = "Bruce", 
    LastName = "Campbell", 
    Age = 57
};
Console.WriteLine(ash);

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public override string ToString()
    {
        return $"{FullName} is {Age} year{(Age == 1 ? "" : "s")} old";
    }
}

//public class Person
//{
//    public required string FirstName { get; set; }
//    public required string LastName { get; set; }
//    public int Age { get; set; }

//    public string FullName => $"{FirstName} {LastName}";

//    public override string ToString() =>
//        $"{FullName} is {Age} year{(Age == 1 ? "" : "s")} old";
//}
