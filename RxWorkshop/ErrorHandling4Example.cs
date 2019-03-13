using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace RxWorkshop
{
    public class ErrorHandling4Example
    {
        public static void Run()
        {
            var hot = Observable.Interval(TimeSpan.FromSeconds(1))
                
                .Publish();

            hot.Connect();

            hot
                .ObserveOn(NewThreadScheduler.Default)
                .Select(value =>
                {
                    if (value > 6)
                    {
                        throw new Exception("value greater than 6");
                    }

                    return value;
                })

                .Subscribe(i => Console.WriteLine($"select {i}"));

            hot.Subscribe(i => Console.WriteLine($"raw {i}"));




            Console.ReadLine();
        }


    }
}