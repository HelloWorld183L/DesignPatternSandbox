using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.Observer_Pattern
{
    class Observable : IObservable
    {
        public int Temperature { get; }
        public List<IObserver> Observers { get; set; }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

    }
}
