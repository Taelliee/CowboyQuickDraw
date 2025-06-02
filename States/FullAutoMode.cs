using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.Models;
using CowboyQuickDraw.Weapons;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.States
{
    public class FullAutoMode : IFireMode
    {
        public FireModeType getModeName()
        {
            return FireModeType.FullAutomatic;
        }

        public void Shoot(Weapon weapon, Cowboy target)
        {
            int shots = Math.Min(3, weapon.AmmoCount); // Up to 3 shots

            if (shots > 0 && weapon is Rifle r)
            {
                r.ConsumeAmmo(shots);

                int totalDamage = shots * weapon.Bullet.Damage;
                target.TakeDamage(totalDamage);
                Console.WriteLine($"Fired {shots} rounds in full-auto mode! Ammo left: {weapon.AmmoCount}");
            }
            else
            {
                Console.WriteLine("Out of ammo for full-auto mode.");
            }
        }
    }
}
