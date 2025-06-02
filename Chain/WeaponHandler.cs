using CowboyQuickDraw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowboyQuickDraw.Chain
{
    public abstract class WeaponHandler 
    {
        protected WeaponHandler nextWeapon;

        public void SetNextWeapon(WeaponHandler nextHandler) {  
            this.nextWeapon = nextHandler; 
        }
        public abstract bool Handle(Cowboy cowboy);
    }
}
