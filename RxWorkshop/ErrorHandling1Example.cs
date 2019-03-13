using System;
using System.Reactive.Linq;

namespace RxWorkshop
{
    public class ErrorHandling1Example
    {
        public static void Run()
        {
            var observable = Observable
                    .Range(0, 10)
                    .Select(value =>
                    {
                        if (value > 6)
                        {
                            throw new Exception("value greater than 6");
                        }

                        return value;
                    })
                ;//.Catch(new[]{11,12,13,14,15}.ToObservable());

            observable.Subscribe( new MyObserver(){Id=1} );

            observable.Subscribe(new MyObserver(){Id=2});

            Console.ReadLine();
        }
    }

    public class MyObserver : IObserver<int>
    {
        public int Id { get; set; }
        public void OnCompleted()
        {
            Console.WriteLine($"{Id} Completed");
        }
        public void OnError(Exception error)
        {
            Console.WriteLine($"{Id} {error.Message}");
        }
        public void OnNext(int value)
        {
            Console.WriteLine($"{Id} {value}");
        }
    }
}