using System;
using System.Reactive.Subjects;

namespace RxWorkshop
{
    public class Observers2Example
    {
        static Subject<int> _subject = new Subject<int>();

        public static void Run()
        {
            var disposable = _subject.Subscribe( Console.WriteLine );

            _subject.OnNext( 1 );

            disposable.Dispose();

            _subject.OnNext( 2 );
        }
    }
}
