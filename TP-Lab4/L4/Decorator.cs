public abstract class BaseEnemyDecorator : IEnemy
{
    protected IEnemy WrappedEnemy;

    protected BaseEnemyDecorator(IEnemy wrappedEnemy)
    {
        WrappedEnemy = wrappedEnemy;
    }

    public virtual string Name => WrappedEnemy.Name;
    public virtual int Health => WrappedEnemy.Health;
    public virtual bool IsAlive() => WrappedEnemy.IsAlive();
    public virtual void TakeDamage(int damage) => WrappedEnemy.TakeDamage(damage);
    public virtual void Attack(Player player) => WrappedEnemy.Attack(player);
}

public class LegendaryEnemyDecorator : BaseEnemyDecorator
{
    public LegendaryEnemyDecorator(IEnemy wrappedEnemy) : base(wrappedEnemy) { }

    public override string Name => "Легендарный " + base.Name;

    public override void Attack(Player player)
    {
        base.Attack(player);
        Console.WriteLine($"{Name} наносит дополнительный урон!");
        player.TakeDamage(20);
    }
}

public class WindfuryEnemyDecorator : BaseEnemyDecorator
{
    public WindfuryEnemyDecorator(IEnemy wrappedEnemy) : base(wrappedEnemy) { }

    public override string Name => "Обладающий Неистовством Ветра " + base.Name;

    public override void Attack(Player player)
    {
        base.Attack(player);
        Console.WriteLine($"{Name} атакует второй раз!");
        base.Attack(player);
    }
}
