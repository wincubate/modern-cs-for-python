using ModernCS.Session3;

Album album = new(
    "Depeche Mode",
    "Violator",
    new DateTime(1990, 3, 19)
);

string description = album switch
{
    Album(string summary, int age) when age >= 25 => $"{summary} is vintage <3",
    Album(string summary, int age) when age >= 10 => $"{summary} is seasoned",
    Album(string summary, _) => $"{summary} is for youngsters only! ;-)"
};

Console.WriteLine(description);
