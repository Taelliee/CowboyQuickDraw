using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowboyQuickDraw.Models
{
    public class Bullet
    {
        public Bullet(string bulletName, int damage)
        {
            BulletName = bulletName;
            Damage = damage;
        }

        public string BulletName { get; set; }
        public int Damage { get; set; }
    }
}
