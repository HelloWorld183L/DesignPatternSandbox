using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.Observer_Pattern
{
    class Observer : IObserver
    {
        public Observable Observable { get; set; }

        public Observer()
        {
            Observable = new Observable();
        }

        public void Update()
        {
            Console.WriteLine($"The temperature today is... {Observable.GetTemperature()}");
        }

    }
}
