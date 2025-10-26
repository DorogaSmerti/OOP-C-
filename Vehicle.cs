public class Vehicle
{
    protected string Brand;
    protected int Year;
    protected double Mileage;
    protected double MaxSpeed;

    public Vehicle(string brand, int year, double mileage, double maxSpeed)
    {
        this.Brand = brand;
        this.Year = year;
        this.Mileage = mileage;
        this.MaxSpeed = maxSpeed;
    }

    public virtual string GetInfo() => $"{Brand} ({Year}), Mileage: {Mileage} km";

    public virtual double GetMaxSpeed() => MaxSpeed;

    public virtual void Move(double distance)
    {
        Mileage += distance;
        Console.WriteLine($"{Brand} drove {distance} km.");
    }
}
