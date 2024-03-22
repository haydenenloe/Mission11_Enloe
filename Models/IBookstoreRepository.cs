namespace Mission11_Enloe.Models;

public interface IBookstoreRepository
{
    public IQueryable<Book> Books { get; }
}