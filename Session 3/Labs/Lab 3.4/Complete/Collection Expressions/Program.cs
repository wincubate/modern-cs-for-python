List<int> elements1 = [11, 22, 44, 77, 99];
List<int> elements2 = [33, 44, 55, 66, 88, 99];

List<int> result = Merge(elements1, elements2);
foreach (int i in result)
{
    Console.Write($"{i} ");
}

static List<int> Merge(List<int> list1, List<int> list2) =>
    (list1, list2) switch
    {
        ([int a1, .. var rest1], [int a2, .. var rest2]) when a1 <= a2 => [a1, .. Merge(rest1, list2)],
        ([int a1, .. var rest1], [int a2, .. var rest2]) => [a2, .. Merge(list1, rest2)],
        ([], _ ) => list2,
        (_, []) => list1,
    };
