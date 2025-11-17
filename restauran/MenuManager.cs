namespace RestaurantApp;
public class MenuManager
{
    private readonly List<MenuItem> _menuItems = new();
    
    public void AddMenuItem(MenuItem menuItem)
    {
        _menuItems.Add(menuItem);
    }

    public string DisplayFullMenu()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine("--- ПОВНЕ МЕНЮ РЕСТОРАНУ ---");
        
        foreach(var item in _menuItems)
        {
            sb.AppendLine(item.GetDetails()); 
        }
        sb.AppendLine("-----------------------------");
        
        return sb.ToString();
    }

    public MenuItem FindItemById(int id)
    {
        return _menuItems.FirstOrDefault(item => item.Id == id);
    }

    public MenuItem FindItemByName(string name)
    {
        return _menuItems.FirstOrDefault(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

}