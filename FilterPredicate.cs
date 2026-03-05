public delegate bool FilterPredicate(int number);

public class FilterPredicates()
{
    public static void FilterArray(int[] numbers, FilterPredicate predicate)
    {
        foreach(var item in numbers)
        {
            if (predicate(item))
            {
                Console.WriteLine(item);
            }
        }
    }

    public static void Run(string[] args)
    {
        int[] ints = new int[10];
        FilterArray(ints, x => x % 2 == 0);
        FilterArray(ints, x => x > 5);
        FilterArray(ints, x => x % 2 != 0);
    }
}