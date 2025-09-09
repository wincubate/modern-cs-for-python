LookupDelegate del = TransformString;
Console.WriteLine(del("hello!"));

List<string> elements =
[
    "Hello",
    "World",
    "Booyah"
];
var lookup = new LookupTable(elements, TransformString);

Console.WriteLine(lookup.Get(2));

static string TransformString(string s)
{
    return s.ToUpper();
}

delegate string LookupDelegate(string s);

class LookupTable(List<string> elements, LookupDelegate mapping)
{
    private static string DefaultMapping(string s)
    {
        return s;
    }

    public string Get(Index index)
    {
        return mapping(elements[index]);
    }

    public LookupTable() : this([], DefaultMapping)
    {
    }
}
