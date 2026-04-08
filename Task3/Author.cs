public class Author
{
    public string Name{get;set;}
    public List<Book> Books { get; set; }

    public Author(string name)
    {
        Name = name;
        Books = new List<Book>();
    }
}

public class AuthorDto
{
    public string Name { get; set; }
    public List<string> BookTitles { get; set; }

    public AuthorDto(string name, List<string> bookTitles)
    {
        Name = name;
        BookTitles = bookTitles;
    }
}