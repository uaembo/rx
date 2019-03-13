using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

namespace RxWorkshop
{
    public class WarmObservableExample
    {
        public static void Run()
        {
            var observable = Observable
                .Timer( TimeSpan.FromSeconds( 1 ), NewThreadScheduler.Default )
                .Select( ts => DateTime.Now )                
                .Publish();

            observable.Subscribe( v =>
            {
                Console.WriteLine( $"subscriber 1: {v}" );
            } );

            Thread.Sleep( 2000 );

            observable.Subscribe( v =>
            {
                Console.WriteLine( $"subscriber 2: {v}" );
            } );

            observable.Connect();
        }
    }
}
