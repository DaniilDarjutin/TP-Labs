using System.Numerics;
using System;

public class Program
{
    public static void Main()
    {
        // Декоратор
        Console.WriteLine("=== Декоратор ===");
        Player player = new Player("Игрок");
        IEnemy enemy = new Enemy("Обычный враг", 100);
        IEnemy legendaryEnemy = new LegendaryEnemyDecorator(enemy);
        IEnemy windfuryEnemy = new WindfuryEnemyDecorator(legendaryEnemy);

        windfuryEnemy.Attack(player);

        // Адаптер
        Console.WriteLine("\n=== Адаптер ===");
        Weapon weapon = new Weapon { Name = "Заколдованный меч" };
        IEnemy weaponEnemy = new WeaponToEnemyAdapter(weapon);
        weaponEnemy.Attack(player);
        weaponEnemy.TakeDamage(10);

        // Фасад
        Console.WriteLine("\n=== Фасад ===");
        WeaponEquipmentFacade facade = new WeaponEquipmentFacade();
        Weapon mageWeapon = facade.GetWeaponForClass(CharacterClass.Mage);
        Console.WriteLine($"Получено оружие для класса Mage: {mageWeapon.Name}");

        // Заместитель (Прокси)
        Console.WriteLine("\n=== Заместитель ===");
        IPlayerProfileRepository repository = new PlayerProfileCacheRepository();
        PlayerProfile profile = repository.GetProfile("Игрок1");
        Console.WriteLine($"Профиль игрока: {profile.Name}, Очки: {profile.Score}");
        repository.UpdateHighScore("Игрок1", 150);
        Console.WriteLine($"Обновлённые очки игрока: {repository.GetProfile("Игрок1").Score}");
    }
}
