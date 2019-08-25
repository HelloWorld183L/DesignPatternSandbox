using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternImplementation.Pizza_Implementation
{
    public abstract class ToppingDecorator : IPizza
    {
        private IPizza _pizza;
        protected string _name = "Unknown topping.";
        protected double _price = 0.00;

        public ToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public double GetCost()
        {
            return _pizza.GetCost() + _price;
        }

        public string GetDescription()
        {
            return $"{_pizza.GetDescription()} {_name}";
        }
    }
}
