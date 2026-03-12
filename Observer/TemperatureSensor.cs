public class TemperatureSensor
{
    private int _currentTemperature;

    public event Action<int> OnTemperatureChanged;

    public void SetTemperature(int newTemp)
    {
        _currentTemperature = newTemp;

        OnTemperatureChanged?.Invoke(newTemp);
    }
}