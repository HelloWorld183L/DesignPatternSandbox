using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns
{
    public class Axe : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("I shall do a mighty swing to kill you!");
        }
    }
}
