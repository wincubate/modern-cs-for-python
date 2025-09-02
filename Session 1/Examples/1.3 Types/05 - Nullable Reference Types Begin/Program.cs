string firstName = "Bruce";
string? middleName = null;
string lastName = "Campbell";

string fullName = $"{firstName} {middleName ?? string.Empty} {lastName}";

Console.WriteLine(fullName);
Console.WriteLine(middleName?.Length ?? 0);
