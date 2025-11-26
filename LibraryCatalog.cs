namespace LibraryManagementSystem;

public class LibraryCatalog<T> where T : ILibraryItem
{
    private readonly List<T> _items;

    public LibraryCatalog()
    {
        _items = new List<T>();
    }

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAllItems()
    {
        return new List<T>(_items);
    }

    public T GetItemById(int id)
    {
        return _items.FirstOrDefault(item => item.Id == id);
    }
}