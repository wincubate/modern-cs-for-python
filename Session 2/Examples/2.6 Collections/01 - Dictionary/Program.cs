Dictionary<int, string> dict = new();
dict.Add(75192, "Millennium Falcon");
dict.Add(21318, "Tree House");
dict.Add(51515, "Robot Inventor");
Console.WriteLine($"Number 51515 is \"{dict[51515]}\""+ Environment.NewLine);

foreach (KeyValuePair<int, string> kv in dict)
{
    Console.WriteLine($"Product {kv.Key} is \"{kv.Value}\"");
}
