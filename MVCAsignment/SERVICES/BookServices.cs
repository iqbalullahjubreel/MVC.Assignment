
public class BookServices : IBookService
{
    private readonly IBookRepository _bookRepository;
    public BookServices(IBookRepository repository)
    {
        _bookRepository = repository;
    }
    public Book AddNewBook(BookRequestModel requestModel)
    {
        Book books = new Book();
        books.Id = 4;
        books.Name = requestModel.Name;
        books.Description = requestModel.Description;
        books.IsAvailable = requestModel.IsAvailable;
        _bookRepository.AddBook(books);
        return books;
    }

    public void DeleteNewBook(int id)
    {
        Book bok = _bookRepository.GetBook(id);
        _bookRepository.DeleteBook(bok);
    }

    public List<Book> GetAllBooks()
    {
        return _bookRepository.GetAllBooks();
    }

    public Book GetABook(int id)
    {
        Book bok = _bookRepository.GetBook(id);
        return bok;
    }

    public Book UpdateABook(Book updatebook)
    {
        //Book bok = _bookRepository.GetBook(updatebook.Id);
        _bookRepository.UpdateBook(updatebook);
        return updatebook;
    }
}
