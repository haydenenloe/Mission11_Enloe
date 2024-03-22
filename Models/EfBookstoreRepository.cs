namespace Mission11_Enloe.Models;

public class EfBookstoreRepository : IBookstoreRepository
{
    private BookstoreContext _context;
    
    public EfBookstoreRepository(BookstoreContext temp)
    {
        _context = temp;
    }

    public IQueryable<Book> Books => _context.Books;
}