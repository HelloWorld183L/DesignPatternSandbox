using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns
{
    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("I shall stab you!");
        }
    }
}
