
namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> devices = new List<ISwitchable>();
        private List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            devices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach (var device in devices)
            {
                device.TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");

            double totalEnergy = 0;

            foreach (var consumer in energyDevices)
            {
                double energyUsed = consumer.GetEnergyUsage(hours);
                totalEnergy += energyUsed;

                Console.WriteLine($"- {consumer.DeviceName}: {energyUsed:F2} кВт·год (потужність: {consumer.PowerConsumption} Вт)");
            }

            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год");
            double cost = totalEnergy * 4.0;
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {cost:F2} грн");
        }
    }
}