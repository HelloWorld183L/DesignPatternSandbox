using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public class Bow : IWeapon
    {
        public int Damage { get; set; } = 50;

        public void Attack()
        {
            Console.WriteLine($"Bow does {Damage} points of damage!");
        }
    }
}
