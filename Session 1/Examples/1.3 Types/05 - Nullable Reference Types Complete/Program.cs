string firstName = "Bruce";
string? middleName = Console.ReadLine();
string lastName = "Campbell";

string fullName = $"{firstName} {middleName} {lastName}";
Console.WriteLine(fullName);

Console.WriteLine(middleName?.Length ?? 0);
Console.WriteLine(middleName!.Length);
