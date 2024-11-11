public class HeroBuilder
{
    private Hero _hero = new Hero();

    public HeroBuilder SetName(string name)
    {
        _hero.Name = name;
        return this;
    }

    public HeroBuilder SetHealth(int health)
    {
        _hero.Health = health;
        return this;
    }

    public HeroBuilder SetStrength(int strength)
    {
        _hero.Strength = strength;
        return this;
    }

    public Hero Build()
    {
        return _hero;
    }
}