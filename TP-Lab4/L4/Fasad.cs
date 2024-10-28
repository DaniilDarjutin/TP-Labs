public enum CharacterClass { Mage, Warrior, Thief }

public class EquipmentChest
{
    public Weapon GetWeapon(CharacterClass characterClass)
    {
        return characterClass switch
        {
            CharacterClass.Mage => new Weapon { Name = "Волшебный посох" },
            CharacterClass.Warrior => new Weapon { Name = "Меч" },
            CharacterClass.Thief => new Weapon { Name = "Кинжал" },
            _ => throw new ArgumentException("Неизвестный класс персонажа")
        };
    }
}

public class WeaponEquipmentFacade
{
    private readonly EquipmentChest _equipmentChest = new EquipmentChest();

    public Weapon GetWeaponForClass(CharacterClass characterClass)
    {
        return _equipmentChest.GetWeapon(characterClass);
    }
}
