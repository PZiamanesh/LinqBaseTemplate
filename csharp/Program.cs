
List<Book> books = new()
{
    new()
    {
        Id = 1,
        Title = "TCP/IP",
        AuthorId = 1,
        Description= "academic descriptio of networking",
        Category = "Networking",
        Price = 55.30m,
    },
    new()
    {
        Id = 2,
        Title = "Security",
        AuthorId = 1,
        Description= null,
        Category = "Security",
        Price = 60.30m,
    },
    new()
    {
        Id = 2,
        Title = "CCNA",
        AuthorId = 2,
        Description= "practical cisco networks",
        Category = "Networking",
        Price = 100.00m,
    }
};
List<Author> authors = new()
{
    new()
    {
        Id= 1,
        Name = "forouzan"
    },
    new()
    {
        Id= 2,
        Name = "wendel"
    },
    new()
    {
        Id= 3,
        Name = "rosen"
    }
};
List<int> numbers1 = new() { 15, 62, 99, 33, 54 };
List<int> numbers2 = new() { 15, 62, 59, 23, 44 };

//------



//------
public class Book
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}