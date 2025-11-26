namespace LibraryManagementSystem;

public abstract class LibraryItemBase : ILibraryItem
{
    public int Id { get; }
    public string Title { get; }
    public int Year { get; }

    public static int _nextId = 1;

    public LibraryItemBase(string title, int year)
    {
        Id = _nextId;
        _nextId++;

        Title = title;
        Year = year;
    }

    public abstract string GetItemType();

    public virtual string GetDisplayInfo()
    {
        return $"{GetItemType()} ID: {Id}, Title: \"{Title}\", Year: {Year}";
    }
}