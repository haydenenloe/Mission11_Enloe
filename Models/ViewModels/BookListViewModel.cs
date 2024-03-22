namespace Mission11_Enloe.Models.ViewModels;

public class BookListViewModel
{
    public IQueryable<Book> Books { get; set; }

    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

}