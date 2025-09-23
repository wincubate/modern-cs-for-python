IEnumerable<Movie> movies =
[
    new("Total Recall", 2012, 6.2f),
    new("Evil Dead", 1981, 7.5f),
    new("The Matrix", 1999, 8.7f),
    new("Cannonball Run", 1981, 6.3f),
    new("Star Wars: Episode IV - A New Hope", 1977, 8.6f),
    new("Don't Look Up", 2021, 7.3f),
    new("Evil Dead", 2013, 6.5f),
    new("Who Am I", 2014, 7.5f),
    new("Total Recall", 1990, 7.5f),
    new("The Interview", 2014, 6.5f)
];


// TODO: a) Find the movie which premiered first (without OrderBy())
Movie? queryA = movies
    .MinBy(movie => movie.Year)
    ;
Console.WriteLine(queryA);


// TODO: b) Find the first movie with a rating above 9.0f
// (or the just first movie if no such high-rated movie exists)
Movie queryB = movies
    .FirstOrDefault(movie => movie.ImdbRating >= 9.0f, movies.First())
    ;
Console.WriteLine(queryB);


// TODO: c) Find the second-to-last movie of the list (if it exists)
Movie? queryC = movies
    .ElementAtOrDefault(^2)
    ;
Console.WriteLine(queryC);


// TODO: d) Find all the movies except the first and last to premiere
IEnumerable<Movie> queryD = movies
    .OrderBy(movie => movie.Year)
    .Take(1..^1)
    ;
foreach (Movie movie in queryD)
{
    Console.WriteLine(movie);
}


// TODO: e) Find the sequence movies with the remakes removed
IEnumerable<Movie> queryE = movies
    .OrderBy(movie => movie.Year)
    .DistinctBy(movie => movie.Title)
    ;
foreach (Movie movie in queryE)
{
    Console.WriteLine(movie);
}


// TODO: f) Group the movies into groups of 4 movies each
// (with the last group potentially containing fewer than 4 elements,
//  if 4 does not divide the total number of movies)
var queryF = movies
    .Chunk(4)
    ;
foreach (var chunk in queryF)
{
    foreach (Movie movie in chunk)
    {
        Console.WriteLine(movie);
    }
    Console.WriteLine();
}
