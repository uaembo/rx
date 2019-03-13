using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

namespace RxWorkshop
{
    public class HotObservableExample
    {
        public static IObservable<int> ExternObservable()
        {
            int value = 0;
            var observable = Observable
                .Interval( TimeSpan.FromMilliseconds( 1000 ), NewThreadScheduler.Default )
                .Select( ts => value++ )
                .Publish();

            observable.Connect();

            return observable;
        }

        public static void Run()
        {
            var observable = ExternObservable();

            //the observable runs for a while
            // subscribers subscribe later
            Thread.Sleep( 1500 );

            observable.Subscribe( v =>
            {
                Console.WriteLine( $"subscriber 1: {v}" );
            } );

            Thread.Sleep( 1000 );

            observable.Subscribe( v =>
            {
                Console.WriteLine( $"subscriber 2: {v}" );
            } );

        }
    }
}
