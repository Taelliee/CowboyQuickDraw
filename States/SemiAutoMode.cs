using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.Models;
using CowboyQuickDraw.Weapons;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.States
{
    public class SemiAutoMode : IFireMode
    {
        public FireModeType getModeName()
        {
            return FireModeType.SemiAutomatic;
        }
        public void Shoot(Weapon weapon, Cowboy target)
        {
            if (weapon.HasAmmo())
            {
                weapon.ConsumeAmmo();
                target.TakeDamage(weapon.Bullet.Damage);
                Console.WriteLine($"Single shot fired at {target.Name}. Ammo left: {weapon.AmmoCount}");
            }
            else
            {
                Console.WriteLine("No ammo to fire in semi-auto mode.");
            }
        }
    }
}
