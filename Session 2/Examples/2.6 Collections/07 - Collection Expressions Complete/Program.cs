List<string> elements =
[
    "Hello",
    "World",
    "Booyah"
];
var lookup = new LookupTable(elements);

Console.WriteLine(lookup.Get(2));


class LookupTable(List<string> elements)
{
    public string Get(Index index)
    {
        return elements[index].ToUpper();
    }

    public LookupTable() : this([])
    {
    }
}
