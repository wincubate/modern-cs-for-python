namespace ModernCS.Session3;

record Album(string Artist, string AlbumName, DateTime ReleaseDate)
{
    public int Age
    {
        get
        {
            DateTime today = DateTime.Now;
            return today.Year - ReleaseDate.Year - (ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }

    public void Deconstruct(out string summary, out int age)
    {
        summary = $"\"{AlbumName}\" by {Artist}";

        DateTime today = DateTime.Now;
        age = today.Year - ReleaseDate.Year - (ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
    }
}
