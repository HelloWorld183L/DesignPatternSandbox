using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.Observer_Pattern
{
    class Observable : IObservable
    {
        public List<IObserver> Observers { get; set; }

        public Observable()
        {
            Observers = new List<IObserver>();
        }

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

        public int GetTemperature()
        {
            Random randomTemperature = new Random();
            return randomTemperature.Next(-50, 50);
        }

        public static void Run()
        {
            var observer = new Observer();
            var observer2 = new Observer();
            var observable = new Observable();
            observable.Add(observer);
            observable.Add(observer2);
            observable.Notify();
        }

    }
}
