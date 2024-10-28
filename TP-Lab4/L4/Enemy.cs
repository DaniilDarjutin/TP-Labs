using System;
using System.Numerics;
public interface IEnemy
{
    string Name { get; }
    int Health { get; }
    bool IsAlive();
    void TakeDamage(int damage);
    void Attack(Player player);
}

public class Enemy : IEnemy
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public bool IsAlive() => Health > 0;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} получил {damage} урона.");
    }

    public virtual void Attack(Player player)
    {
        Console.WriteLine($"{Name} атакует {player.Name}.");
        player.TakeDamage(10);
    }
}
