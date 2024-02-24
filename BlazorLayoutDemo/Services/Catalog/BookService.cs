using BlazorLayoutDemo.Data;
using BlazorLayoutDemo.Entity;

namespace BlazorLayoutDemo.Services;

public class BookService
{
    private readonly CatalogDbContext _context;
    private static readonly Random random = new Random();

    public BookService(CatalogDbContext context)
    {
        _context = context;
    }

    public void AddRandomBooks(int numberOfBooks)
    {
        for (int i = 0; i < numberOfBooks; i++)
        {
            var book = new Book
            {
                Title = $"Book {i}",
                Author = $"Author {random.Next(1, 100)}"
            };

            _context.Books.Add(book);
        }

        _context.SaveChanges();
    }
}
