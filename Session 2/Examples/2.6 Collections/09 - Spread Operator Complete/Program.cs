//int[] row0 = [1, 2, 3];
//List<int> row1 = [4, 5, 6];
//IEnumerable<decimal> row2 = [7.1m, 8.2m, 9.3m];

//decimal[] all = [.. row0, .. row1, .. row2];

//foreach (var element in all)
//{
//    Console.WriteLine(element);
//}



List<string> elements = ["Hello", "World", "Booyah"];
string[] more = ["Yie", "Har"];
var lookup = new LookupTable([..elements, ..more]);

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
