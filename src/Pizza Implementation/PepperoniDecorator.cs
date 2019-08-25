using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternImplementation.Pizza_Implementation
{
    public class PepperoniDecorator : ToppingDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza)
        {
            _name = "Pepperoni topping";
            _price = 3.99;
        }
    }
}
