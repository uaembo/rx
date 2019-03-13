using System;

namespace RxWorkshop
{
    public class Event1Example
    {
        static event Action<int> _event;
        public static void Run()
        {
            _event += Console.WriteLine;

            _event( 0 );
        }
    }
}