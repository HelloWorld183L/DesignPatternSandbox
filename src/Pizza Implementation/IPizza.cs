using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternImplementation.Pizza_Implementation
{
    public interface IPizza
    {
        string GetDescription();
        double GetCost();
    }
}
