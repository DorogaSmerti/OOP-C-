public class SecuritySystem
{
    public void AlarmSystem(int temp)
    {
        if(temp > 40)
        {
            Console.WriteLine("ALARM: Перегрев!");
        }

        else if(temp < 5)
        {
            Console.WriteLine("WARNING: Риск замерзания!");
        }
    }
}