using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.Models;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.States
{
    public class SafeMode : IFireMode
    {
        public FireModeType getModeName()
        {
            return FireModeType.Safe;
        }
        public void Shoot(Weapon weapon, Cowboy target)
        {
            Console.WriteLine("Weapon is on SAFE. Cannot fire.");
        }
    }
}
