using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

namespace RxWorkshop
{
    public class ColdObservableExample
    {
        public static void Run()
        {
            var observable = Observable
                    .Timer(TimeSpan.FromSeconds(1), NewThreadScheduler.Default)
                    .Select(ts => DateTime.Now)
                ;

            observable.Subscribe(v =>
            {
                Console.WriteLine($"subscriber 1: {v}");
            });

            Thread.Sleep(2000);

            observable.Subscribe(v =>
            {
                Console.WriteLine($"subscriber 2: {v}");
            });
            
        }
        //public static void Run()
        //{
        //    int value = 0;
        //    var observable = Observable
        //        .Interval(TimeSpan.FromMilliseconds(1000))
        //        .Select(v => value++)
        //        ;

        //    observable.Subscribe( v =>
        //    {
        //        Console.WriteLine( $"subscriber 1: {v}" );
        //    } );

        //    Thread.Sleep( 1500 );

        //    observable.Subscribe( v =>
        //    {
        //        Console.WriteLine( $"subscriber 2: {v}" );
        //    } );
        //}
    }
}
