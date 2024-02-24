using BlazorPagingDemo.Data;

namespace BlazorPagingDemo.Services;

public class BookService
{
    private readonly MyDbContext _context;
    private static readonly Random random = new Random();

    public BookService(MyDbContext context)
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
