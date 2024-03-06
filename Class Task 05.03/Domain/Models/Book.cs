namespace Domain;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; }   
    public string Description { get; set; }

    public DateTime PublishYear { get; set; }

    public decimal Price { get; set; }

    public int PageSize { get; set; }
    
}
