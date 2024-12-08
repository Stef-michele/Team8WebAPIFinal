namespace Team8WebAPIFinal.Models
{
    public class FavoriteShow
    {
        public int Id { get; set; }
        public int ReleaseYear { get; set; }
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public required string FavoriteCharacter { get; set; }
        public required string Creator { get; set; }
    }
}