
using TheBattleOfWar.Factories;

namespace TheBattleOfWar;

public class Unit
{
    private Movement.Movement _movement;
    private Weapon.Weapon _weapon;

    public Unit(AbstractFactory abstractFactory)
    {
        _weapon = abstractFactory.CreateWeapon();
        _movement = abstractFactory.CreateMovement();
    }

    public void Move()
    {
        _movement.Move();
    }

    public void Attack()
    {
        _weapon.Attack();
    }
    
}