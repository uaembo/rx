using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace RxWorkshop
{
    public class ErrorHandling3Example
    {
        public static void Run()
        {
            var subject = new Subject<int>();
            
            subject.Select(value =>
            {
                if (value > 6)
                {
                    throw new Exception("value greater than 6");
                }

                return value;
            })
                .Catch(new[]{1000}.ToObservable())
                .Subscribe(i => Console.WriteLine($"select {i}"), () => Console.WriteLine("Completed"));

            subject.Subscribe((i) => Console.WriteLine($"raw {i}"));


            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);

            try
            {
                subject.OnNext(7);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            //never shows up in select
            subject.OnNext(5);

            Console.ReadLine();
        }


    }
}