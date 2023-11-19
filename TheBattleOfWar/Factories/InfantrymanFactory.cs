using TheBattleOfWar.Movement;
using TheBattleOfWar.Weapon;

namespace TheBattleOfWar.Factories;

public class InfantrymanFactory:AbstractFactory
{
    public override Movement.Movement CreateMovement()
    {
        return new Run();
    }

    public override Weapon.Weapon CreateWeapon()
    {
        return new AutomaticRifle();
    }
}