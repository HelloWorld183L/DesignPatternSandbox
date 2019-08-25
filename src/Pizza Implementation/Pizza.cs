using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternImplementation.Pizza_Implementation
{
    public class Pizza : IPizza
    {
        public double GetCost()
        {
            return 5.99;
        }

        public string GetDescription()
        {
            return "YUM YUM LOOK AT THAT DOUGH OOOOOOOOH";
        }
    }
}
