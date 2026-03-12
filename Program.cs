public class Program
{
    public static void Main(string[] args)
    {
        TemperatureSensor sensor = new();
        Display display = new();
        AirConditioner ac = new();
        SecuritySystem security = new();

        sensor.OnTemperatureChanged += display.ShowTemperature;
        sensor.OnTemperatureChanged += ac.ChangeTemperature;
        sensor.OnTemperatureChanged += security.AlarmSystem;

        sensor.SetTemperature(12);
        sensor.SetTemperature(20);
        sensor.SetTemperature(30);
        sensor.SetTemperature(50);

        Player player = new();
        UIHealthBar healthBar = new();
        GameLogger logger = new();
        AchievementSystem achievementSystem = new();
        SoundSystem soundSystem = new();

        player.HealthChanged += healthBar.HealthWrite;
        player.HealthChanged += logger.GameLoggerController;
        player.HealthChanged += achievementSystem.AchievementSystemController;
        player.HealthChanged += soundSystem.SoundSystemWriter;

        player.TakeDamaged(20);
        player.TakeDamaged(30);
        player.TakeDamaged(40);
        player.TakeDamaged(15);
    }
}