string firstName = "Jesper";
string lastName = "Gulmann Henriksen";
string company = "The LEGO Group";

string s = $$"""
    {
      "firstName": "{{firstName}}",
      "lastName": "{{lastName}}",
      "company": "{{company}}"
    }
    """;

Console.WriteLine(s);
