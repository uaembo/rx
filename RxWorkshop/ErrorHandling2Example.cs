using System;
using System.Reactive.Linq;

namespace RxWorkshop
{
    public class ErrorHandling2Example
    {
        public static void Run()
        {
            var observable = Observable
                    .Interval(TimeSpan.FromSeconds(1))
                    .Select(value =>
                    {
                        if (value > 6)
                        {
                            throw new Exception("value greater than 6");
                        }

                        return value;
                    })
                .Catch(new[]{11l,12,13,14,15}.ToObservable());

            observable.Subscribe(Console.WriteLine);

            Console.ReadLine();
        }


    }
}