

namespace TheBattleOfWar.Factories;

public abstract class AbstractFactory
{
    public abstract Movement.Movement CreateMovement();
    public abstract Weapon.Weapon CreateWeapon();
}