using TheBattleOfWar.Movement;
using TheBattleOfWar.Weapon;

namespace TheBattleOfWar.Factories;

public class AssaultAircraftFactory:AbstractFactory
{
    public override Movement.Movement CreateMovement()
    {
        return new Fly();
    }

    public override Weapon.Weapon CreateWeapon()
    {
        return new Rocket();
    }
}