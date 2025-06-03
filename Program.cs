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
Weapon rifle1 = new Rifle(8, b1);
Weapon rifle2 = new Rifle(9, b3);

Cowboy cowboy1 = new Cowboy("Billy", 0.8);
Cowboy cowboy2 = new Cowboy("Tommy", 0.7);

cowboy1.AddWeapon(gun1);
cowboy1.AddWeapon(shotgun);
cowboy1.AddWeapon(rifle1);
cowboy2.AddWeapon(gun2);
cowboy2.AddWeapon(rifle2);

Console.WriteLine("Cowboy Shootout Begins!\n");

// Set initial fire modes
cowboy1.SetFireMode(FireModeType.SemiAutomatic);
cowboy2.SetFireMode(FireModeType.SemiAutomatic);

//while there are still weapons available, keep shooting
//while someone is alive, keep shooting

// Simulate rounds
for (int round = 1; round <= 10; round++)
{
    Console.WriteLine($"\n--- Round {round} ---");

    cowboy1.Shoot(cowboy2);
    if (cowboy2.Health <= 0) break;

    cowboy2.Shoot(cowboy1);
    if (cowboy1.Health <= 0) break;
    Console.WriteLine($"[{cowboy1.Name}] HP: {cowboy1.Health} | [{cowboy2.Name}] HP: {cowboy2.Health}");
}

// Change fire modes mid-combat
//Console.WriteLine("\nChanging fire modes mid-game...");
//cowboy1.SetFireMode(FireModeType.FullAutomatic);
//cowboy2.SetFireMode(FireModeType.Safe);

// Final round
//Console.WriteLine("\n--- Final Round ---");
//cowboy1.Shoot(cowboy2);
//cowboy2.Shoot(cowboy1);

Console.WriteLine($"\nResult: {cowboy1.Name} ({cowboy1.Health} HP), {cowboy2.Name} ({cowboy2.Health} HP)");
//check who is alive and print winner
if (cowboy1.Health > 0 && cowboy2.Health <= 0)
{
    Console.WriteLine($"{cowboy1.Name} wins!");
}
else if (cowboy2.Health > 0 && cowboy1.Health <= 0)
{
    Console.WriteLine($"{cowboy2.Name} wins!");
}
else
{
    Console.WriteLine("It's a draw!");
}