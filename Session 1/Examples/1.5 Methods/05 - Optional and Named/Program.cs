FavoriteTeam("Liverpool", ConsoleColor.Red, "Premier League");
FavoriteTeam("Tottenham", league: "Premier League");
FavoriteTeam("AGF");

static void FavoriteTeam(
    string team,
    ConsoleColor color = ConsoleColor.White,
    string league = "Superliga"
)
{
    ConsoleColor old = Console.ForegroundColor;

    Console.ForegroundColor = color;
    Console.WriteLine($"I support {team} playing in the {league}");
    Console.ForegroundColor = old;
}