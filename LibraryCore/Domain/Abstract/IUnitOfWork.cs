namespace LibraryCore.Domain.Abstract
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
        public IBookRepository BookRepository { get; }
    }
}
