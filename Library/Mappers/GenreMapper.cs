using Library.Models;
using LibraryCore.Domain.Entities;

namespace Library.Mappers
{
    public class GenreMapper : IMapper<Genre, GenreModel>
    {
        public Genre Map(GenreModel model)
        {
            return new Genre()
            {
                Name = model.Name,
                Note = model.Note
            };
        }

        public GenreModel Map(Genre entity)
        {
            return new GenreModel()
            {
                Name = entity.Name,
                Note = entity.Note
            };
        }
    }
}
