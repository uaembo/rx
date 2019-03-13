using System;
using System.Reactive.Linq;
using System.Threading;

namespace RxWorkshop
{
    public class LinQ1Example
    {
        public static void Run()
        {
            var otherStream = new[]
                {
                    "eins", "zwei", "drei", "vier", "fünf"
                }
                .ToObservable();

            var obs =  Observable
                    .Range(1, 5)
                    .Zip(otherStream, (a, b) => $"{a}-{b}")
                    .Where((zipped) => zipped.Contains("ei"))
                ;

            obs.Subscribe( Console.WriteLine );
        }
    }
}
