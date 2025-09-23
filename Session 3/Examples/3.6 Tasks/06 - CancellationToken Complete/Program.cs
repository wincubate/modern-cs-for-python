List<string> urls = [
    "http://www.jp.dk",
    "http://dr.dk",
    "http://bold.dk"
];

// Set up cancellation
CancellationTokenSource cts = new();

cts.CancelAfter(5000);

try
{
    foreach (var url in urls)
    {
        string s = await GetTextAsync(url, cts.Token);
        Console.WriteLine(s);
        Console.WriteLine();
    }
}
catch(OperationCanceledException exception) when (exception.CancellationToken == cts.Token)
{
    Console.WriteLine("We cancelled it ourselves...");
}
finally
{
    Console.WriteLine("Done!");
}

static async Task<string> GetTextAsync(string url, CancellationToken cancellationToken)
{
    HttpClient client = new();

    string result = await client.GetStringAsync(url, cancellationToken);

    await Task.Delay(2000, cancellationToken);

    return result[..256];
}
