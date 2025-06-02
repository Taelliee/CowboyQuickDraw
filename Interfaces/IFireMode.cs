using CowboyQuickDraw.Models;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.Interfaces
{
    public interface IFireMode
    {
        FireModeType getModeName();
        void Shoot(Weapon weapon, Cowboy target);
    }
}
