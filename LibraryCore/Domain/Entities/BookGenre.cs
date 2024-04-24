namespace LibraryCore.Domain.Entities
{
    public class BookGenre : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
    }
}
