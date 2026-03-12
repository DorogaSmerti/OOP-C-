public class SoundSystem
{
    public void SoundSystemWriter(int health, int damage)
    {
        Console.WriteLine("відтворює звук");

        if(health <= 20 && health > 0)
        {
            Console.WriteLine("відтворює звук критичного стану");
        }
    }
}