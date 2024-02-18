using RoyalLibrary.Core.Repositories;
using RoyalLibrary.Domain;
using RoyalLibrary.Services.Base;
using System.Linq.Expressions;

namespace RoyalLibrary.Services
{
    public class BookService: IBookService
    {
        private readonly IRepository<Book> _repository;
        public BookService(IRepository<Book> repository) => _repository = repository;

        public async Task<IEnumerable<Book>> SearchBooks(string field, string value)
        {
            var query = _repository.GetQuery();

            var parameter = Expression.Parameter(typeof(Book), "book");
            var property = Expression.Property(parameter, field);
            var constant = Expression.Constant(value);
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            
            if (containsMethod == null)
            {
                throw new ArgumentException($"Selected field [{field}] is invalid");
            }

            var containsExpression = Expression.Call(property, containsMethod!, constant);

            var lambda = Expression.Lambda<Func<Book, bool>>(containsExpression, parameter);

            query = query.Where(lambda);

            return await _repository.QueryToListAsync(query);
        }
    }
}
