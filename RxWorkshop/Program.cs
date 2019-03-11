using System;
using System.Reactive.Linq;

namespace RxWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Observable.FromEventPattern()
            //scheduler bsp
            Observable.Timer(TimeSpan.FromSeconds(1)) // Threading.Timer wird genommen -> als default , kann über scheduler angepasst werden

        }
    }
}
