using System;

public class HardItemFactory : ItemFactory
{
    public override Weapon CreateWeapon()
    {
        return new Bow();
    }

    public override Potion CreatePotion()
    {
        return new StaminaPotion();
    }
}