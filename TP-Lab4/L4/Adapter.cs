using System.Numerics;

public class Weapon
{
    public string Name { get; set; }

    public void Hit(Player player)
    {
        Console.WriteLine($"{Name} атакует {player.Name}!");
        player.TakeDamage(15);
    }
}

public class WeaponToEnemyAdapter : IEnemy
{
    private readonly Weapon _weapon;
    public string Name => "Магическое оружие";
    public int Health { get; private set; } = 50;

    public WeaponToEnemyAdapter(Weapon weapon)
    {
        _weapon = weapon;
    }

    public bool IsAlive() => Health > 0;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} получает {damage} урона!");
    }

    public void Attack(Player player)
    {
        _weapon.Hit(player);
    }
}
