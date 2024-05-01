using Library.Models;
using LibraryCore.Domain.Entities;

namespace Library.Mappers
{
    public interface IMapper<TEntity, TModel> where TEntity : IEntity where TModel : IModel
    {
        TEntity Map(TModel model);
        TModel Map(TEntity entity);
    }

}
