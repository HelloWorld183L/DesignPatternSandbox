using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public class Warrior : Contestant, IPlayer
    {
        private int _swordDamageMultiplier;
        public IWeapon Weapon { get; set; }
        public int Health { get; set; } = 200;

        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void CheckWeapon()
        {

        }
    }
}
