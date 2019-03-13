using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

namespace RxWorkshop
{
    public class SchedulerExample
    {
        public static void Run()
        {
            var observable = Observable.Interval(TimeSpan.FromMilliseconds(100))
                .ObserveOn(NewThreadScheduler.Default);

            //the observable runs for a while
            // subscribers subscribe later
            Thread.Sleep(1500);

            observable.Subscribe(v =>
            {
                Console.WriteLine($"subscriber 1: {v}");
            });

            Thread.Sleep(1000);

            observable.Subscribe(v =>
            {
                Console.WriteLine($"subscriber 2: {v}");
            });

        }
    }
}