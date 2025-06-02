namespace CowboyQuickDraw.Models
{
    public class BulletList
    {
        private static BulletList _instance;
        private readonly List<Bullet> bullets;
        private BulletList()
        {
            bullets = new List<Bullet>() 
            { 
                new Bullet(".22LR", 10),
                new Bullet("9mm", 15),
                new Bullet(".38 Special", 25),
                new Bullet(".12GA", 30)
            };
        }

        public static BulletList GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BulletList();
            }
            return _instance;
        }

        public Bullet GetBulletByName(string name)
        {
            // Assuming 'Name' is a property of Bullet class
            return bullets.FirstOrDefault(b => b.BulletName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
