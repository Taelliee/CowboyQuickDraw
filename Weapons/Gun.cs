using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.Models;

namespace CowboyQuickDraw.Weapons
{
    public class Gun : Weapon
    {
        public Gun(int ammoCount, Bullet bullet) 
            : base(ammoCount, bullet)
        {
            base.Type = Enums.WeaponType.Gun;
        }

        public override void Reload()
        {
            base.AmmoCount = 6; // Revolver-style
            Console.WriteLine("Gun reloaded.");
        }
    }
}
