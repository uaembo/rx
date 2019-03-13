using System;

namespace RxWorkshop
{
    public class Event2Example
    {
        static event Action<int> _event;
        public static void Run()
        {
            _event += Handler;

            _event( 0 );

            _event -= Handler;

            //nre
            //_event( -1 );
        }

        private static void Handler( int value )
        {
            Console.WriteLine( value );
        }
    }
}