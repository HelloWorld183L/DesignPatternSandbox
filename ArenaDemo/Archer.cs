using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public class Archer : Contestant, IPlayer
    {
        public int Health { get; set; } = 200;
        public IWeapon Weapon { get; set; }
        public int BowDamageMultiplier { get; set; }
        
        public Archer(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void CheckWeapon()
        {

        }
    }
}
