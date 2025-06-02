namespace CowboyQuickDraw.Chain
{
    public class WeaponChain
    {
        private WeaponHandler weapon;

        public WeaponChain()
        {
            this.weapon = new GunHandler();
            WeaponHandler weapon2 = new ShotgunHandler();
            WeaponHandler weapon3 = new RifleHandler();

            weapon.SetNextWeapon(weapon2);
            weapon2.SetNextWeapon(weapon3);
            weapon3.SetNextWeapon(null);
        }

        public WeaponHandler getFirstWeapon()
        {
            return this.weapon;
        }
    }
}
