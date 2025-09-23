List<string> urls = [
    "http://www.jp.dk",
    "http://dr.dk",
    "http://bold.dk"
];

foreach (var url in urls)
{
    string s = await GetTextAsync(url);
    Console.WriteLine(s);
    Console.WriteLine();
}

static async Task<string> GetTextAsync(string url)
{
    HttpClient client = new();

    string result = await client.GetStringAsync(url);

    return result[..256];
}
