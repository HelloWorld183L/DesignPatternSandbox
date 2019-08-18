using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public interface IPlayer
    {
        int Health { get; set; }
        IWeapon Weapon { get; set; }
        void CheckWeapon();
    }
}
