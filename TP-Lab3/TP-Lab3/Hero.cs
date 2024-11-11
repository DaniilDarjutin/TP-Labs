public class Hero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }

    public override string ToString()
    {
        return $"Герой: {Name}, Здоровье: {Health}, Сила: {Strength}";
    }
}