List<LEGOSet> sets = [
    new()
    {
        Number = 75192,
        Title = "Millennium Falcon",
        Pieces = 7541
    },
    new()
    {
        Number = 51515,
        Title = "Robot Inventor",
        Pieces = 949
    },
    new()
    {
        Number = 21318,
        Title = "Tree House",
        Pieces = 3036
    },
    new()
    {
        Number = 77255,
        Title = "Lightening McQueen",
        Pieces = 270
    },
    new()
    {
        Number = 10365,
        Title = "Captain Jack Sparrow's Pirate Ship",
        Pieces = 2862
    }
];

var results = from set in sets
              where set.Pieces >= 1000
              select set.Title.ToUpper();

foreach (var set in results)
{
    Console.WriteLine(set);
}

record LEGOSet
{
    public required int Number { get; init; }
    public required string Title { get; init; }
    public required int Pieces { get; init; }
};