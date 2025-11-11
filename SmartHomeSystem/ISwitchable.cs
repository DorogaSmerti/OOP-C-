
namespace SmartHomeSystem
{
    public interface ISwitchable
    {
        string Name { get; }
        bool IsOn { get; }

        void TurnOn();
        void TurnOff();
    }
}