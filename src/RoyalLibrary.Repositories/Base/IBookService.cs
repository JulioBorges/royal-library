using RoyalLibrary.Domain;

namespace RoyalLibrary.Services.Base
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> SearchBooks(string field, string value);
    }
}
