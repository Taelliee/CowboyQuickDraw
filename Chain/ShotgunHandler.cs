using CowboyQuickDraw.Models;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.Chain
{
    public class ShotgunHandler : WeaponHandler
    {
        public override bool Handle(Cowboy cowboy)
        {
            foreach (Weapon shotgun in cowboy.WeaponInventory.Where(w => w.Type == WeaponType.Shotgun))
            {
                if (shotgun.HasAmmo())
                {
                    cowboy.CurrentWeapon = shotgun;
                    Console.WriteLine($"{cowboy.Name} switched to a shotgun.");
                    return true;
                }
            }

            if (nextWeapon != null)
            {
                return nextWeapon.Handle(cowboy);
            }

            return false;
        }
    }
}
