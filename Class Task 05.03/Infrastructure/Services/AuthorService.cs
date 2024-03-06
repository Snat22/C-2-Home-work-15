using Domain;

namespace Infrastructure;

    public class AuthorService
    {
        List<Author> _authors = new List<Author>();
        List<Book> _authorBooks = new List<Book>();
        public void AddAuthorBook(Book book)
        {
            if (_authors.Any(a => a.Id == book.Id))
            {
                System.Console.WriteLine("Book with the same ID already exists.");
            }

            _authorBooks.Add(book);
        }
        public List<Author> GetAuthors(AuthorFilter filter)
        {
            var filteredAuthor = _authors;
            if (filter.FullName != null)
            {
                filteredAuthor = filteredAuthor
                    .Where(e => (e.FirstName + e.LastName).ToLower().Contains(filter.FullName.ToLower().Trim()))
                    .ToList();
            }
            if (filter.Nationality != null)
            {
                filteredAuthor = filteredAuthor
                    .Where(e => e.Nationality.ToLower().Contains(filter.Nationality.ToLower().Trim()))
                    .ToList();
            }
            if (filter.BirthYear != null)
            {
                filteredAuthor = filteredAuthor
                    .Where(e => e.BirthDate.Year == filter.BirthYear)
                    .ToList();
            }

            return filteredAuthor;
        }
        public List<Author> GetAuthors()
        {
            return _authors;
        }
        public Author GetAuthorById(int id)
        {
            return _authors.FirstOrDefault(e => e.Id == id);
        }

        public void AddAuthor(Author author)
        {
            if (_authors.Any(a => a.Id == author.Id))
            {
                System.Console.WriteLine("Author with the same ID already exists.");
            }

            _authors.Add(author);
        }

        public void UpdateAuthor(Author author)
        {
            var UpAuthor = _authors.FirstOrDefault(e => e.Id == author.Id);
            if(UpAuthor == null)
            {
                System.Console.WriteLine("Author not found.");
            }

            UpAuthor.FirstName = author.FirstName;
            UpAuthor.LastName = author.LastName;
            UpAuthor.BirthDate = author.BirthDate;
            UpAuthor.Nationality = author.Nationality;
        }

        public void DeleteAuthor(int id)
        {
            var author = _authors.FirstOrDefault(e => e.Id == id);
            if (author == null)
            {
                throw new InvalidOperationException("Author not found.");
            }

            _authors.Remove(author);
        }
    }


