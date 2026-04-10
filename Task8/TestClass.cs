public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public TestClass( ) { }

    public override string ToString()
    {
        return $"Имя: {Name}, Возраст: {Age}, Город: {City}";
    }
}