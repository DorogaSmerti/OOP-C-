public class AchievementSystem
{
    public void AchievementSystemController(int health, int damage)
    {
        if(health <= 50)
        {
            Console.WriteLine("досягнення Half Health");
        }

        if(health <= 0)
        {
            Console.WriteLine("досягнення First Death");
        }
    }
}