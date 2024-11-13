public interface IBookService
{
    void DeleteNewBook(int id);

    Book AddNewBook(BookRequestModel requestModel);

    Book UpdateABook(Book updatebook);

    List<Book> GetAllBooks();

    Book GetABook(int id);
}
