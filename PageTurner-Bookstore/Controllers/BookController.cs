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
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data =_bookRepository.GetBookById(id) ;
            return View(data);
        }
        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName) ;
        }
    }
}
