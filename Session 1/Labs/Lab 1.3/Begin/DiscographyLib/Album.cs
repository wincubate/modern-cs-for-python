using System;

namespace DiscographyLib
{
    public sealed class Album(string artist, string albumName, DateTime releaseDate)
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Artist { get; } = artist;
        public string AlbumName { get; } = albumName;
        public DateTime ReleaseDate { get; } = releaseDate;
    }
}
