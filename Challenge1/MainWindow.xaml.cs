using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Challenge1
{
    //TODO fix 
    public partial class MainWindow : Window
    {
        private IObservable<DateTime> _dateTimeStream;
        public MainWindow()
        {
            InitializeComponent();

            _dateTimeStream = Observable.Interval(TimeSpan.FromSeconds(1))
                .Select(t => DateTime.Now);


            _dateTimeStream.Subscribe(d => Title = d.Ticks.ToString());

        }
    }


}
