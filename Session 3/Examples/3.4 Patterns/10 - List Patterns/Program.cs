var elements = new int[] { 11, 22, 33 };

Console.WriteLine(elements is [11, 22, 33]);
Console.WriteLine(elements is [11, 22, 33, 44]);
Console.WriteLine(elements is [> 10, < 100, 33 or 44]);

//Console.WriteLine(elements is [11, _, 33]);
//Console.WriteLine(elements is [11, _, _, _]);
