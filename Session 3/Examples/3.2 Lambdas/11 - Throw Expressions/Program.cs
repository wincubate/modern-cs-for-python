PersonRepository repository = new();
IEnumerable<Person> all = repository.GetAll();

repository.Add(null);

//repository.Add(new Employee { FirstName = "Anders", LastName = "Hejlsberg" });

foreach (Person p in all)
{
    Console.WriteLine(p.FirstName);
}
