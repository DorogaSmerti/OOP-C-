namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public int PowerConsumption => 1000;
        public string DeviceName => Name;

        public override void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                Console.WriteLine($"{Name} почала готувати каву.");
            }
        }

        public override void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine($"{Name} завершила роботу.");
            }
        }

        public double GetEnergyUsage(int hours)
        {
            if (IsOn)
            {
                return (PowerConsumption * hours) / 1000.0;
            }
            return 0;
        }
    }
}