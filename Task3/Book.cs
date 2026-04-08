public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }

    public Book(string title, Author author)
    {
        Title = title;
        Author = author;
    }
}

public class BookDto
{
    public string Title { get; set; }
    public string AuthorName { get; set; }

    public BookDto(string title, string authorName)
    {
        Title = title;
        AuthorName = authorName;
    }
}