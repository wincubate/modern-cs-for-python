int[] numbers = [ 10, 20, 30, 40, 0, 1, 2, 3, 8 ];
var query = numbers
    .Where( i => i < 10)
    .Select( i =>  87 / i )
    ;

// No exception yet!

foreach (var i in query)
{
    Console.WriteLine(i);
}
