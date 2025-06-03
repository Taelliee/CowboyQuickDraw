using CowboyQuickDraw.Chain;
using CowboyQuickDraw.Interfaces;
using CowboyQuickDraw.States;
using static CowboyQuickDraw.Enums;

namespace CowboyQuickDraw.Models
{
    public class Cowboy
    {
        private double accuracy;

        public string Name { get; private set; }
        public int Health { get; private set; }
        public double Accuracy
        {
            get => accuracy;
            private set
            {
                if (value > 0 && value <= 1)
                {
                    accuracy = value;
                }
            }
        }
        public Weapon CurrentWeapon { get; set; }
        public List<Weapon> WeaponInventory { get; private set; }

        public Cowboy(string name, double accuracy)
        {
            Name = name;
            Health = 100;
            Accuracy = accuracy;
            WeaponInventory = new List<Weapon>();
        }

        public void AddWeapon(Weapon weapon)
        {
            WeaponInventory.Add(weapon);

            if (CurrentWeapon == null)
            {
                CurrentWeapon = weapon;
            }
        }

        public void Shoot(Cowboy target)
        {
            if (CurrentWeapon != null && CurrentWeapon.HasAmmo())
            {
                Random rnd = new Random();
                if (rnd.NextDouble() <= Accuracy)
                {
                    CurrentWeapon.Fire(target);
                }
                else
                {
                    CurrentWeapon.ConsumeAmmo();
                    Console.WriteLine($"{Name} missed! Ammo left: {CurrentWeapon.AmmoCount}");
                }
            }
            else
            {
                Console.WriteLine($"{Name} needs to switch weapons!");
                SwitchWeapon();
            }
        }

        public void TakeDamage(int amount)
        {
            Health = Math.Max(0, Health - amount);
            Console.WriteLine($"{Name} took {amount} damage! Health is now {Health}.");
        }

        public void SwitchWeapon()
        {
            WeaponChain chain = new WeaponChain();
            bool switched = chain.getFirstWeapon().Handle(this);

            if (!switched)
            {
                Console.WriteLine($"{Name} has no usable weapons left!");
            }
            else
            {
                SetFireMode(FireModeType.SemiAutomatic);
            }
        }

        public void SetFireMode(FireModeType modeType)
        {
            if (CurrentWeapon == null) return;

            IFireMode newMode = modeType switch
            {
                FireModeType.Safe => new SafeMode(),
                FireModeType.SemiAutomatic => new SemiAutoMode(),
                FireModeType.FullAutomatic => new FullAutoMode(),
                _ => throw new ArgumentException("Invalid fire mode")
            };

            CurrentWeapon.SetFireMode(newMode);
        }
    }
}
