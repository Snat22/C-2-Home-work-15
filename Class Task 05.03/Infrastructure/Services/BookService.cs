using Domain;

namespace Infrastructure;

public class BookService
{
    List<Book> _books = new List<Book>();
    
          public List<Book> GetBooks(BookFilter book)
    {
        if (book.Title != null)
        {
            _books = _books.Where(e=> e.Title.ToLower().Trim().Contains(book.Title.ToLower().Trim())).ToList();
        }
        if (book.PubYear != null)
        {
            _books = _books.Where(e=> e.PublishYear.Year == book.PubYear).ToList();
        }
        if (book.Price != null)
        {
            _books = _books.Where(e=> e.Price <= book.Price).ToList();
        }
        return _books;
    }

    // public Author GetBooksByAuthorId(int id)
    // {
   
    // }

    public void AddBook(Book book)
    {
            _books.Add(book);
            System.Console.WriteLine("Added sucessfully");

    }

    public void UpdateBook(Book book)
    {
        var upBo = _books.FirstOrDefault(e=> e.Id==book.Id);
        if (upBo == null)
        {
            System.Console.WriteLine("Not Founded");
            return ;
        }

        upBo.Title = book.Title;
        upBo.Description = book.Description;
        upBo.PublishYear = book.PublishYear;
        upBo.Price = book.Price;
    }
    public void DeleteBook(int id)
    {
        var deleted = _books.FirstOrDefault(e=> e.Id == id);
               if (deleted == null)
        {
            System.Console.WriteLine("Not Founded");
            return ;
        }

        _books.Remove(deleted);
        Console.WriteLine("Author deleted successfully");

    }




}
