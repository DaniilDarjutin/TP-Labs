public abstract class DamageHandler
{
    protected DamageHandler NextHandler;

    public void SetNext(DamageHandler handler)
    {
        NextHandler = handler;
    }

    public abstract int Handle(int damage);
}

public class Handler1 : DamageHandler
{
    public override int Handle(int damage)
    {
        if (damage <= 50)
        {
            Console.WriteLine($"Handler1 обработал {damage} урона.");
            return 0;
        }
        else
        {
            return NextHandler?.Handle(damage - 50) ?? damage;
        }
    }
}

public class Handler2 : DamageHandler
{
    public override int Handle(int damage)
    {
        if (damage <= 30)
        {
            Console.WriteLine($"Handler2 обработал {damage} урона.");
            return 0;
        }
        else
        {
            return NextHandler?.Handle(damage - 30) ?? damage;
        }
    }
}

public class Handler3 : DamageHandler
{
    public override int Handle(int damage)
    {
        Console.WriteLine($"Handler3 обработал {damage} урона.");
        return 0;
    }
}
