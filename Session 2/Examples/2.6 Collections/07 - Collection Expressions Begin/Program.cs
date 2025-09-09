var elements = new string[]
{
    "Hello",
    "World",
    "Booyah"
};
var lookup = new LookupTable(elements);

Console.WriteLine(lookup.Get(2));


class LookupTable(string[] elements)
{
    public string Get(Index index)
    {
        return elements[index].ToUpper();
    }
}