using System;

public class MediumItemFactory : ItemFactory
{
    public override Weapon CreateWeapon()
    {
        return new Kopyo();
    }

    public override Potion CreatePotion()
    {
        return new SpeedPotion();
    }
}