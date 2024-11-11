using System;

public abstract class ItemFactory
{
    public abstract Weapon CreateWeapon();
    public abstract Potion CreatePotion();
}