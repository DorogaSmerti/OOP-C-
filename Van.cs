public class Van : Car
{
    private double LoadCapacity;
    private double CurrentLoad;

    public Van(string brand, int year, double mileage, int doors, double loadCpaacity)
    : base(brand, year, mileage, doors, 140.0)
    {
        LoadCapacity = loadCpaacity;
        CurrentLoad = 0;
    }

    public override string GetInfo() => $"Van: {Brand} ({Year}), Doors: {Doors}, Load: {CurrentLoad}/{LoadCapacity}kg, Fuel: {FuelLevel}L";

    public void LoadCargo(double weight)
    {
        if (CurrentLoad + weight <= LoadCapacity)
        {
            CurrentLoad += weight;
            Console.WriteLine($"{weight} kg loaded into the van.");
        }
        else
        {
            Console.WriteLine($"Too heavy! Cannot load more cargo.");
        }
    }

    public void UnloadCargo()
    {
        CurrentLoad = 0;
        Console.WriteLine("Van unloaded.");
    }
}
