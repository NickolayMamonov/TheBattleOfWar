using TheBattleOfWar.Movement;
using TheBattleOfWar.Weapon;

namespace TheBattleOfWar.Factories;

public class TankFactory: AbstractFactory
{
    public override Movement.Movement CreateMovement()
    {
        return new Track();
    }

    public override Weapon.Weapon CreateWeapon()
    {
        return new TankGun();
    }
}