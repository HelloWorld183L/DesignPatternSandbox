using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public class Sword : IWeapon
    {
        public int Damage { get; set; } = 50;

        public void Attack()
        {
            Console.WriteLine($"Sword does {Damage} points of damage!");
        }
    }
}
