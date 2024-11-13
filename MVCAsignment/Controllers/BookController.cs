using Microsoft.AspNetCore.Mvc;
using MVCAsignment.Models;
using System.Diagnostics;

namespace MVCAsignment.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _loggers;
        private readonly IBookService _bookService;

        public BookController(ILogger<BookController> logger, IBookService repository)
        {
            _loggers = logger;
            _bookService = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        { 
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult AddBook(BookRequestModel model)
        {
            Book book = _bookService.AddNewBook(model);
            return RedirectToAction("GetAllBooks");

        }
        [HttpGet]
        public IActionResult GetBook(int id)
        {
            Book bok = _bookService.GetABook(id);
            return View(bok);
        }
        public IActionResult GetAllBooks()
        {
            List<Book> bok = _bookService.GetAllBooks();
            return View(bok);
        }
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            Book bok = _bookService.GetABook(id);
            return View(bok);
        }
        [HttpPost]

        public IActionResult Updatebook(Book requestModel)
        {
            Book bok = _bookService.UpdateABook(requestModel);
            return RedirectToAction("GetAllBooks");

        }
        [HttpGet]

        public IActionResult DeleteBook(int id)
        {
            Book bok = _bookService.GetABook(id);
            return View();
        }
        [HttpPost, ActionName("DeleteBook")]
        public IActionResult RealDelete(int id)
        {
            _bookService.DeleteNewBook(id);
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
