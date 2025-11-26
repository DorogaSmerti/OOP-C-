namespace LibraryManagementSystem;

public class LibraryManager
{
    private readonly LibraryCatalog<Book> _bookCatalog;
    private readonly LibraryCatalog<Magazine> _magazineCatalog;

    public LibraryManager()
    {
        _bookCatalog = new LibraryCatalog<Book>();
        _magazineCatalog = new LibraryCatalog<Magazine>();
    }

    public void AddItem(ILibraryItem item)
    {
        if (item is Book book)
        {
            _bookCatalog.AddItem(book);
        }
        else if (item is Magazine magazine)
        {
            _magazineCatalog.AddItem(magazine);
        }
    }
    
    public List<ILibraryItem> GetAllItems()
    {
        List<ILibraryItem> allItems = new List<ILibraryItem>();

        allItems.AddRange(_bookCatalog.GetAllItems());

        allItems.AddRange(_magazineCatalog.GetAllItems());

        return allItems;
    }

    public ILibraryItem GetItemById(int id)
    {
        ILibraryItem item = _bookCatalog.GetItemById(id);
        if (item != null)
        {
            return item;
        }

        item = _magazineCatalog.GetItemById(id);
        return item;
    }
}