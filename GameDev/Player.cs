public class Player
{
    private int _health{get;set;}

    public event Action<int, int> HealthChanged;

    public void TakeDamaged(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;

        HealthChanged?.Invoke(_health, damage);
    }
}