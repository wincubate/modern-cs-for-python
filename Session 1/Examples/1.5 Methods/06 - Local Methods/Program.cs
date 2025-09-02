FavoriteTeam("Liverpool", ConsoleColor.Red, "Premier League");
FavoriteTeam("Tottenham", league: "Premier League");
FavoriteTeam("AGF");

static void FavoriteTeam(
    string team,
    ConsoleColor color = ConsoleColor.White,
    string league = "Superliga"
)
{
    void Print()
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"I support {team} playing in the {league}");
    }

    ConsoleColor old = Console.ForegroundColor;
    Print();
    Console.ForegroundColor = old;
}