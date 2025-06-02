using CowboyQuickDraw.Models;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.Chain
{
    public class GunHandler : WeaponHandler
    {
        public override bool Handle(Cowboy cowboy)
        {
            foreach (Weapon gun in cowboy.WeaponInventory.Where(w => w.Type == WeaponType.Gun))
            {
                if (gun.HasAmmo())
                {
                    cowboy.CurrentWeapon = gun;
                    Console.WriteLine($"{cowboy.Name} switched to a gun.");
                    return true;
                }
                else 
                {
                    Console.WriteLine("Gun is out of ammo!");    
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
