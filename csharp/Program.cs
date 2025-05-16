using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books = new()
{
    new()
    {
        Id = 1,
        Title = "TCP/IP",
        AuthorId = 1,
        Description= "academic descriptio of networking",
        Category = "Networking",
        Price = 155.99m,
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
        Id = 3,
        Title = "CCNA",
        AuthorId = 2,
        Description= "practical cisco networks",
        Category = "Networking",
        Price = 100.00m,
    },
    new()
    {
        Id = 4,
        Title = "EthicalHacking",
        AuthorId = 2,
        Description= "hacking networks",
        Category = "Security",
        Price = 120.00m,
    }
};

        List<BookCover> bookCovers = new()
{
    new()
    {
        Id = 1,
        BookId = 1,
        PosterTitle = "RedTcpIpCover"
    },
    new()
    {
        Id = 2,
        BookId = 1,
        PosterTitle = "BlueTcpIpCover"
    },
    new()
    {
        Id = 3,
        BookId = 3,
        PosterTitle = "GreenCiscoPress"
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

        //========================================================================

        List<int> numbers1 = new() { 5, 5, 5, 15, 62 };
        List<int> numbers2 = new() { 15, 62, 59, 23, 44 };

        var num = numbers1.Except(numbers2).ToList();


        //========================================================================

        var aaa = (from book in books
                   group book by book.Category
                        into booksGroup
                   select new
                   {
                       Catagory = booksGroup.Key,
                       TotalPrice = booksGroup.Sum(b => b.Price)
                   }).ToList();

        var bbb = (from author in authors
                   join book in books
                        on author.Id equals book.AuthorId
                        into booksGroup
                   from book in booksGroup.DefaultIfEmpty()
                   select new
                   {
                       Author = author.Name,
                       Book = book?.Title
                   }).ToList();

        var ccc = (from book in books
                   join author in authors
                        on book.AuthorId equals author.Id
                   join bookcover in bookCovers
                        on book.Id equals bookcover.BookId
                        into bookCoversGroup
                   select new
                   {
                       Author = author.Name,
                       Book = book.Title,
                       BookCovers = bookCoversGroup
                   }).ToList();

        //========================================================================
        WriteLine();
        ;
    }
}

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

public class BookCover
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public string PosterTitle { get; set; }
}
