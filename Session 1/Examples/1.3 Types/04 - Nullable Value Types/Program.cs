int? i = 87;
int? j = null;

if (i.HasValue)
{
    int k = i.Value + j ?? 42;
    Console.WriteLine(k);
}
