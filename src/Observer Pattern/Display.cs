using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns.Observer_Pattern
{
    class Display
    {
        static void Main(string[] args)
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
