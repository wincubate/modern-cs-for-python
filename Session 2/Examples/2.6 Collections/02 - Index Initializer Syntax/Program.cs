Dictionary<int, string> dict = new()
{
    [75192] = "Millennium Falcon",
    [21318] = "Tree House",
    [51515] = "Robot Inventor"
};
Console.WriteLine($"Number 51515 is \"{dict[51515]}\"" + Environment.NewLine);

foreach (KeyValuePair<int, string> kv in dict)
{
    Console.WriteLine($"Product {kv.Key} is \"{kv.Value}\"");
}
