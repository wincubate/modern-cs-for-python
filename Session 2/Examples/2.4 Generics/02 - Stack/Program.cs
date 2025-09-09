using System.Collections;

Stack stack = new();
stack.Push(new Person { FirstName = "John", Age = 42 });
stack.Push(new Person { FirstName = "Jane", Age = 87 });

// stack.Push...

Person? top = stack.Peek() as Person;
Person? removed = stack.Pop() as Person;
foreach (Person person in stack)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public string? FirstName { get; init; }
    public int? Age { get; init; }
}