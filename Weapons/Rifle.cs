using CowboyQuickDraw.Models;

namespace CowboyQuickDraw.Weapons
{
    public class Rifle : Weapon
    {
        public Rifle(int ammoCount, Bullet bullet) 
            : base(ammoCount, bullet)
        {
            base.Type = Enums.WeaponType.Rifle;
        }

        public override void Reload()
        {
            base.AmmoCount = 10;
            Console.WriteLine("Rifle reloaded.");
        }
    }
}
