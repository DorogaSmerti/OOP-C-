public class Car : Vehicle
{
    protected int Doors;
    protected double FuelLevel;

    public Car(string brand, int year, double mileage, int doors, double maxSpeed = 180.0)
    : base(brand, year, mileage, maxSpeed)
    {
        Doors = doors;
        FuelLevel = 50;
    }

    public override string GetInfo()
    {
        return $"Car: {Brand} ({Year}), Doors: {Doors}, Fuel: {FuelLevel}L";
    }

    public override void Move(double distance)
    {
        base.Move(distance);
        FuelLevel -= distance * 0.1;

        if (FuelLevel <= 0)
        {
            FuelLevel = 0;
        }
    }

    public void Refuel(double literas)
    {
        FuelLevel += literas;
        if (FuelLevel >= 50.0)
        {
            FuelLevel = 50.0;
        }
    }
}
