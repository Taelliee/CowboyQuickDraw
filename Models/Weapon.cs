using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.States;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.Models
{
    public abstract class Weapon
    {
        private int ammoCount;

        protected Weapon(int ammoCount, Bullet bullet)
        {
            AmmoCount = ammoCount;
            Bullet = bullet;
            Mode = new SafeMode();
        }

        public IFireMode Mode { get; set; }
        public int AmmoCount
        {
            get => ammoCount;
            set => ammoCount = Math.Max(0, value); // sets to 0 if negative or invalid
        }
        public Bullet Bullet { get; set; }

        public WeaponType Type { get; set; }

        public void SetFireMode(IFireMode newMode)
        {
            Mode = newMode;
            Console.WriteLine($"Switched to {Mode.getModeName()} mode.");
        }

        public bool HasAmmo()
        {
            return AmmoCount > 0;
        }

        public virtual void Fire(Cowboy target) {
            if (AmmoCount <= 0)
            {
                Console.WriteLine($"{this.GetType().Name} is out of ammo!");
                //switch weapons?
                return;
            }
            if (Mode != null && !FireModeType.Safe.Equals(Mode.getModeName()))
            {
                Mode.Shoot(this, target);
            }
        }
        public abstract void Reload();

        public virtual void ConsumeAmmo(int amount = 1) {
            ammoCount = Math.Max(0, ammoCount - amount);
        }
    }
}
