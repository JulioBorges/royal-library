using RoyalLibrary.Domain;

namespace RoyalLibrary.Data.Repositories
{
    public class BooksRepository : BaseRepository<Book>
    {
        public BooksRepository(BookContext context) : base(context)
        {
        }
    }
}
