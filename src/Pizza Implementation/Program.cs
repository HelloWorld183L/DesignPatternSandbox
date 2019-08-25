using DecoratorPatternImplementation.Pizza_Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzas = new List<IPizza>();
            pizzas.Add(new PepperoniDecorator(new Pizza()));
            pizzas.Add(new GarlicDecorator(new Pizza()));

            foreach (var pizza in pizzas)
            {
                Console.WriteLine(pizza.GetCost());
            }
        }
    }
}

