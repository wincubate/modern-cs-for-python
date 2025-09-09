public class PersonRepository
{
    private readonly List<Person> _persons;

    public PersonRepository()
    {
        Person bo = new()
        {
            FirstName = "Bo",
            LastName = "Rammstein"
        };
        Person pehn = new()
        {
            FirstName = "Peter",
            LastName = "Nothing Henriksen"
        };
        Person jeshe = new()
        {
            FirstName = "Jesper",
            LastName = "Guldfisk Henriksen"
        };

        _persons = [bo, pehn, jeshe];
    }

    public IEnumerable<Person> GetAll() => [.. _persons];

    public void Add(Person? person)
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }

        _persons.Add(person);
    }
}
