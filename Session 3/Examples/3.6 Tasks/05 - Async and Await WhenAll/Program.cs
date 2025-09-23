List<string> urls = [
    "http://www.jp.dk",
    "http://dr.dk",
    "http://bold.dk"
];

var results = await Task
    .WhenAll(urls.Select(u => GetTextAsync(u)));
foreach (var result in results)
{
    Console.WriteLine(result);
    Console.WriteLine();
}

static async Task<string> GetTextAsync(string url)
{
    HttpClient client = new();

    string result = await client.GetStringAsync(url);

    return result[..256];
}
