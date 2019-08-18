using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public class Arena
    {
        private bool _isOver = true;

        public void StartMatch()
        {
            var warrior = new Warrior(new Sword());
            var archer = new Archer(new Bow());

            var warriorFanBoy = new Spectator();
            warrior.AddSpectator(warriorFanBoy);
            var archerFanBoy = new Spectator();
            archer.AddSpectator(archerFanBoy);

            while (!_isOver)
            {
                if (archer.Health == 0 || warrior.Health == 0)
                {
                    Console.WriteLine("The match is over!!");
                }
                else
                {
                    archer.Weapon.Attack();
                    warrior.Weapon.Attack();
                }
            }
        }
    }
}
