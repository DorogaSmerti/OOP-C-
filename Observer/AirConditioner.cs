public class AirConditioner
{
    public void ChangeTemperature(int temp)
    {
        if(temp < 17)
        {
            Console.WriteLine("Обогрев включен");
        }

        else if(temp > 25)
        {
            Console.WriteLine("Охлаждение включено");
        }

        else if(temp > 17 || temp < 25)
        {
            Console.WriteLine("Кондиционер выключен");
        }
    }
}