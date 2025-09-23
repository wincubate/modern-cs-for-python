List<string> urls =[
    "http://www.jp.xxx",
    "http://dr.dk",
    "http://bold.dk"
];

foreach (var url in urls)
{
    string s = GetText(url);
    Console.WriteLine(s);
    Console.WriteLine();
}

static string GetText(string url)
{
    HttpClient client = new();

    string result = client.GetStringAsync(url).Result;

    return result[..256];
}
