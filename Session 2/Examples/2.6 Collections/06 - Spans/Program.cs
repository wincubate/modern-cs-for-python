int[] array = new int[10];
//Span<int> span = array.AsSpan();
//Span<int> slice = span.Slice(2, 5);

for (int i = 0; i < array.Length; i++)
{
    array[i] = i;
}

foreach (int i in array)
{
    Console.WriteLine(i);
}

#region Strings 

//string s = "Hello, World";
//ReadOnlySpan<char> span = s.AsSpan();
//ReadOnlySpan<char> slice = span.Slice(7, 5);
//foreach (char c in slice)
//{
//    Console.Write(c);
//}
//Console.WriteLine();

#endregion
