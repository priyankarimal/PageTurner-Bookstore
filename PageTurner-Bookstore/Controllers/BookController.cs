using Microsoft.AspNetCore.Mvc;

namespace PageTurner_Bookstore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books";
        }
        public string GetBook(int id)
        {
            return $"book with id ={id}";
        }
        public string SearchBook(string bookName, string authorName)
        {
            return $"Book with name={bookName} &Author={authorName}";
        }
    }
}
