using Microsoft.AspNetCore.Mvc;
using PageTurner_Bookstore.Models;
using PageTurner_Bookstore.Repository;

namespace PageTurner_Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository=null;

            public BookController()
            {
               _bookRepository = new BookRepository();
            }
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id) ;
        }
        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName) ;
        }
    }
}
