namespace LibraryManagementSystem;

public class Book : LibraryItemBase
{
    public string Author { get; private set; }

    public Book(string title, int year, string author) : base(title, year)
    {
        Author = author;
    }

    public override string GetItemType()
    {
        return "Book";
    }

    public override string GetDisplayInfo()
    {
        return $"{base.GetDisplayInfo()}, Author: {Author}";
    }
}