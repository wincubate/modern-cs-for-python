Hand left = GetRandomMember<Hand>();
Hand right = GetRandomMember<Hand>();

Outcome winner = (left, right) switch
{
    (Hand.Paper, Hand.Rock) => Outcome.Left,
    (Hand.Paper, Hand.Scissors) => Outcome.Right,
    (Hand.Rock, Hand.Paper) => Outcome.Right,
    (Hand.Rock, Hand.Scissors) => Outcome.Left,
    (Hand.Scissors, Hand.Paper) => Outcome.Left,
    (Hand.Scissors, Hand.Rock) => Outcome.Right,
    (_, _) => Outcome.Tie
};

Console.WriteLine($"{left} vs {right}:\t{winner}");

static T GetRandomMember<T>() where T : struct, Enum
{
    Random random = new();
    T[] ts = [..Enum
        .GetValues(typeof(T))
        .OfType<T>()
    ];

    return ts[random.Next(ts.Length)];
}

enum Hand
{
    Paper,
    Scissors,
    Rock
}

enum Outcome
{
    Left,
    Right,
    Tie
}
