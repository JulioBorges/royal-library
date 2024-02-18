using Microsoft.EntityFrameworkCore;

namespace RoyalLibrary.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }
    }
}
