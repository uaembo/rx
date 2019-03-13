using System;
using System.Reactive.Linq;

namespace RxWorkshop
{
    public class Observers1Example
    {        
        public static void Run()
        {
            var observable = Observable.Range(1, 5);
            observable.Subscribe(Console.WriteLine );
        }
    }
}