using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

namespace RxWorkshop
{
    public class LinQ3Example
    {
        //JOIN
        //http://reactivex.io/documentation/operators/join.html
        public static void Run()
        {
            var left = Observable.Interval( TimeSpan.FromSeconds( 1 ) );
            //concurrency introduced by giving the console read a dedicated thread
            var right = ReadInput().ToObservable( NewThreadScheduler.Default );

            var result = Observable.Join(
                left,
                right,
                //outer time window:
                l => Observable.Timer( TimeSpan.FromSeconds( 3 ) ),
                //inner time window on how long the user input is valid
                s => Observable.Empty<Unit>(),
                ( i, s ) => $"User wrote {s} in window {i}"
                );

            result.ForEach( n => Console.WriteLine(n) );
        }

        static IEnumerable<string> ReadInput()
        {
            while ( true )
            {
                yield return Console.ReadLine();
            }
        }
    }
}
