
using Domain;
using Infrastructure;

var bookSer = new BookService();

var book1 = new Book 
{
    Id = 1,
    Title = "Iskandarshox",
    Description = "Saloxiyati Guzasht",
    PageSize = 123,
    Price = 100,
    PublishYear = new DateTime(1890, 12, 22)
};

var book2 = new Book 
{
    Id = 2,
    Title = "Soft",
    Description = "Club Guzasht",
    PageSize = 1230,
    Price = 1000,
    PublishYear = new DateTime(2021,1,21)
};

var book3 = new Book 
{
    Id = 3,
    Title = "Zabon",
    Description = "Modari sinfi 8",
    PageSize = 1223,
    Price = 10,
    PublishYear = new DateTime(1690,11,12)
};
var book4 = new Book 
{
    Id = 4,
    Title = "Zanjabil",
    Description = "Asxab sinfi 111",
    PageSize = 23,
    Price = 10,
    PublishYear = new DateTime(2020,11,12)
};


bookSer.AddBook(book1);
bookSer.AddBook(book2);
bookSer.AddBook(book3);
bookSer.AddBook(book4);


var bookFilt = new BookFilter(){
    Price = 10,
};

foreach (var item in bookSer.GetBooks(bookFilt))
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Price);
    System.Console.WriteLine(item.PublishYear);
    System.Console.WriteLine(item.PageSize);
    System.Console.WriteLine("_____________________________________________________");
}

// var authorSer = new AuthorService();

// var author1 = new Author();
// author1.FirstName = "John";
// author1.LastName = "Wick";
// author1.BirthDate = new DateTime(1980,07,28);
// author1.Nationality = "India";

// var autSer = new AuthorService();
// autSer.AddAuthorBook(book1);
// autSer.AddAuthorBook(book2);
// autSer.AddAuthorBook(book3);
// autSer.AddAuthorBook(book4);
// autSer.AddAuthor(author1);
// var autFilt = new AuthorFilter();
// autFilt.FullName = "Snat";
// autFilt.BirthYear = 2001;
// autFilt.Nationality = "Tojik";


// foreach (var item in bookSer.GetBooksByPrice(10))
// {
//     System.Console.WriteLine(item.Title);
//     System.Console.WriteLine(item.Id);
//     System.Console.WriteLine(item.Price);
//     System.Console.WriteLine(item.PageSize);
// }


// foreach (var it in author1.Books)
// {
//  System.Console.WriteLine(it);   
// }