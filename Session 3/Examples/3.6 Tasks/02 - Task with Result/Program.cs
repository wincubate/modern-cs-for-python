Task<DateTime> t = Task.Run(() => DateTime.Now);

Console.WriteLine(t.Result); // <-- Blocking!
