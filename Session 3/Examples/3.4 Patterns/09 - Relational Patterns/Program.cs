int temperature = int.Parse(Console.ReadLine()!);

string forecast = temperature switch
{
    <= 0 => "Freezing...",
    < 12 => "Autumn-like",
    <= 19 => "Spring-ish",
    <= 40 => "Summer!",
    _ => "Death Valley?"
};

Console.WriteLine(forecast);
