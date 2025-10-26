public class Scooter : Vehicle
{
    private int BatteryCapacity;
    private double BatteryLevel;

    public Scooter(string brand, int year, double mileage, int batteryCapacity)
    : base(brand, year, mileage, 45.0)
    {
        BatteryCapacity = batteryCapacity;
        BatteryLevel = 100;
    }

    public override string GetInfo() => $"Scooter: {Brand} ({Year}), Battery: {BatteryLevel}% of {BatteryCapacity}Ah";

    public override void Move(double distance)
    {
        base.Move(distance);
        BatteryLevel -= distance * 0.5;
        if (BatteryLevel <= 0)
        {
            BatteryLevel = 0;
        }
    }

    public void Charge()
    {
        BatteryLevel = 100;
        Console.WriteLine($"{Brand} has been fully charged.");
    }
}
