using System;

public class EasyItemFactory : ItemFactory
{
    public override Weapon CreateWeapon()
    {
        return new Sword();
    }

    public override Potion CreatePotion()
    {
        return new HealthPotion();
    }
}