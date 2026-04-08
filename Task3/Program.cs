
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        Author author = new Author("Джон Смит");
        author.Books.Add(new Book("Книга 1", author));
        author.Books.Add(new Book("Книга 2", author));

        AuthorDto authorDto = new AuthorDto(author.Name, author.Books.Select(b => b.Title).ToList());
        string authorJson = JsonSerializer.Serialize(authorDto);

        Console.WriteLine(authorJson);
    }
}
