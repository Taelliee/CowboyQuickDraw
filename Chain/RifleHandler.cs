using CowboyQuickDraw.Models;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.Chain
{
    public class RifleHandler : WeaponHandler
    {
        public override bool Handle(Cowboy cowboy)
        {
            foreach (Weapon riffle in cowboy.WeaponInventory.Where(w => w.Type == WeaponType.Rifle))
            {
                if (riffle.HasAmmo())
                {
                    cowboy.CurrentWeapon = riffle;
                    Console.WriteLine($"{cowboy.Name} switched to a riffle.");
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
