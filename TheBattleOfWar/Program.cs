// See https://aka.ms/new-console-template for more information

using TheBattleOfWar;
using TheBattleOfWar.Factories;

Unit tank = new Unit(new TankFactory());
Unit infantryman = new Unit(new InfantrymanFactory());
Unit assaultAircraft = new Unit(new AssaultAircraftFactory());

infantryman.Move();
tank.Attack();
assaultAircraft.Attack();