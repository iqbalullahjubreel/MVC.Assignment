public interface IBookRepository
{
    Book AddBook(Book books);
    void DeleteBook(Book books);
    Book UpdateBook(Book books);
    List<Book> GetAllBooks();
    Book GetBook(int Id);
}
