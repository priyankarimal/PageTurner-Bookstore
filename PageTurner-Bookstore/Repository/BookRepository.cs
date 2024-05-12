using PageTurner_Bookstore.Models;

namespace PageTurner_Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel>GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id =1, Title="MVC", Author="Priyanka",Description="This is the description for MVC book."},
                new BookModel() {Id =2, Title="Dotnet Core", Author="Mahesh",Description="This is the description for Dotnet Core book."},
                new BookModel() {Id =3, Title="Java", Author="Monica",Description="This is the description for Java book."},
                new BookModel() {Id =4, Title="C#", Author="Prashuva",Description="This is the description for C# book."},
                new BookModel() {Id =5, Title="Php", Author="Namrata",Description="This is the description for Php book."},
                new BookModel() {Id =6, Title="Azure Devops", Author="Bibek",Description="This is the description for Azure Devops book."},

            };
        }
    }
}
