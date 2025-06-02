using CowboyQuickDraw.Models;
using CowboyQuickDraw.Weapons;
using static CowboyQuickDraw.Enums;

//BulletList bullets = BulletList.GetInstance();
Bullet b1 = new Bullet(".22LR", 10);
Bullet b2 = new Bullet("9mm", 15);
Bullet b3 = new Bullet(".38 Special", 25);
Bullet b4 = new Bullet(".12GA", 30);

Weapon gun1 = new Gun(3, b1);
Weapon gun2 = new Gun(2, b2);
Weapon shotgun = new Shotgun(2, b4);
Weapon rifle = new Rifle(8, b1);

Cowboy cowboy1 = new Cowboy("Billy", 0.8);
Cowboy cowboy2 = new Cowboy("Tommy", 0.7);

cowboy1.AddWeapon(gun1);
cowboy1.AddWeapon(shotgun);
cowboy2.AddWeapon(gun2);
cowboy2.AddWeapon(rifle);

Console.WriteLine("Cowboy Shootout Begins!\n");

// Set initial fire modes
cowboy1.SetFireMode(FireModeType.SemiAutomatic);
cowboy2.SetFireMode(FireModeType.SemiAutomatic);

// Simulate rounds
for (int round = 1; round <= 6; round++)
{
    Console.WriteLine($"\n--- Round {round} ---");

    cowboy1.Shoot(cowboy2);
    if (cowboy2.Health <= 0) break;

    cowboy2.Shoot(cowboy1);
    if (cowboy1.Health <= 0) break;
}

// Change fire modes mid-combat
//Console.WriteLine("\nChanging fire modes mid-game...");
//cowboy1.SetFireMode(FireModeType.FullAutomatic);
//cowboy2.SetFireMode(FireModeType.Safe);

// Final round
Console.WriteLine("\n--- Final Round ---");
cowboy1.Shoot(cowboy2);
cowboy2.Shoot(cowboy1);

Console.WriteLine($"\nResult: {cowboy1.Name} ({cowboy1.Health} HP), {cowboy2.Name} ({cowboy2.Health} HP)");