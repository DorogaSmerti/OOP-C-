namespace LibraryManagementSystem;

public interface ILibraryItem
{
    public int Id { get; }
    public string Title { get; }
    public int Year { get; }
    public string GetDisplayInfo();
}