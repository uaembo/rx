using System;
using System.Reactive.Linq;

namespace RxWorkshop
{
    public class LinQ2Example
    {
        public static void Run()
        {
            var otherStream = Observable
                    .Interval(TimeSpan.FromSeconds(1))
                    .Select(t => DateTime.Now)
                ;

            var obs = Observable
                    .Interval(TimeSpan.FromSeconds(2))
                    .Zip(otherStream, (a, b) => $"{a}-{b}")
                ;

            obs.Subscribe(Console.WriteLine);
        }
    }
}
