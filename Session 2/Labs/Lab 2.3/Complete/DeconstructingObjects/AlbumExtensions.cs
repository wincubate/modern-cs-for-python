using DiscographyLib;

static class AlbumExtensions
{
    public static void Deconstruct(this Album album, out Guid id, out string summary, out int age)
    {
        id = album.Id;

        summary = $"\"{album.AlbumName}\" by {album.Artist}";

        DateTime today = DateTime.Now;
        age = today.Year - album.ReleaseDate.Year - (album.ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
    }
}
