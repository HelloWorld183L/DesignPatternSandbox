using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternImplementation.Pizza_Implementation
{
    public class GarlicDecorator : ToppingDecorator
    {
        public GarlicDecorator(IPizza pizza) : base(pizza)
        {
            _name = "Garlic topping";
            _price = 1.99;
        }
    }
}
