using System.Collections.Generic;

Stack<Person> stack = new();
stack.Push(new Person { FirstName = "John", Age = 42 });
stack.Push(new Person { FirstName = "Jane", Age = 87 });

// stack.Push...

Person top = stack.Peek();
Person removed = stack.Pop();
foreach (Person person in stack)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public string? FirstName { get; init; }
    public int? Age { get; init; }
}