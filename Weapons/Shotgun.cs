using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowboyQuickDraw.Weapons
{
    public class Shotgun : Weapon
    {
        public Shotgun(int ammoCount, Bullet bullet) 
            : base(ammoCount, bullet)
        {
            base.Type = Enums.WeaponType.Shotgun;
        }

        public override void Reload()
        {
            base.AmmoCount = 2; // Double barrel
            Console.WriteLine("Shotgun reloaded.");
        }
    }
}
