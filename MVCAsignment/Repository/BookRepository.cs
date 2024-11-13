
public class BookRepository : IBookRepository
{
    static List<Book> _book = new List<Book>()
    {
        new Book {Id =1,Name = "THE LOST PRINCES", Description = "THRILLING",IsAvailable = false},
        new Book {Id =2,Name = "ADE GOES TO SCHOOL", Description = "ADVENTURES",IsAvailable = true},
        new Book {Id =3,Name = "TREASURE ISLAND", Description = "HORROR",IsAvailable = true}
    };
    public Book AddBook(Book books)
    { 
        _book.Add(books);
        return books;
    }

    public void DeleteBook(Book books)
    {
        _book.Remove(books);
    }

    public List<Book> GetAllBooks()
    {
        return _book.ToList();
    }

    public Book GetBook(int id)
    {
        Book? result = _book.Find(x => x.Id == id);
        return result;
    }

    public Book UpdateBook(Book books)
    {
        Book piz = GetBook(books.Id);
        piz.Name = books.Name;
        piz.Description = books.Description;
        piz.IsAvailable = books.IsAvailable;
        return piz;
    }
}