using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns
{
    class Warrior
    {
        private IWeapon _weapon;

        public Warrior(IWeapon weapon)
        {
            _weapon = weapon;
            _weapon.Attack();
        }
    }
}
