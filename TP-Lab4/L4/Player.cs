public class Player
{
    public string Name { get; set; }
    public int Health { get; private set; } = 100;

    public Player(string name)
    {
        Name = name;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} получил {damage} урона. Здоровье: {Health}");
    }
}
