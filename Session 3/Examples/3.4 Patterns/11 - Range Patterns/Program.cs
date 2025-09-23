var elements = new int[] { 11, 22, 33 };

Console.WriteLine(elements is [11, ..]);
Console.WriteLine(elements is [.., 33, 44]);
Console.WriteLine(elements is [11, ..] or [.., 44]);

//if( elements is [11, ..var sub])
//{
//	foreach (int i in sub)
//	{
//		Console.Write($"{i} ");
//	}
//}
