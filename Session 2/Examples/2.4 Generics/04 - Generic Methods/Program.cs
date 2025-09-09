int i = 42;
int j = 87;
Swap(ref i, ref j); // Type inference

Console.WriteLine($"i={i}\tj={j}");

void Swap<T>(ref T a, ref T b)
{
    (a, b) = (b, a);
}
