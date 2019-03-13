using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Challenge2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _rng = new Random();
        private IObservable<int> _rngStream;
        private IObservable<bool> _mousePressedObservable;
        public MainWindow()
        {
            InitializeComponent();

            _rngStream = Observable.Interval(TimeSpan.FromMilliseconds(100))
                .Select(t => _rng.Next(0, 10));

            _mousePressedObservable = Observable.FromEventPattern<MouseEventArgs>(this, "MouseMove")
                        .Select(r => r.EventArgs)
                        .Select(evt => Mouse.LeftButton == MouseButtonState.Pressed)
                        ;

            //TODO
            // 

        }
    }




    //Example Join

    //public partial class MainWindow : Window
    //{

    //    private IObservable<DateTime> _dateTimeStream;
    //    private IObservable<bool> _mousePressedObservable;
    //    public MainWindow()
    //    {
    //        InitializeComponent();

    //        _dateTimeStream = Observable.Interval(TimeSpan.FromSeconds(1))
    //            .Select(t => DateTime.Now);

    //        _mousePressedObservable = Observable.FromEventPattern<MouseEventArgs>(this, "MouseMove")
    //            .Select(r => r.EventArgs)
    //            .Select(evt => Mouse.LeftButton == MouseButtonState.Pressed)
    //            ;

    //        var joined = Observable.Join(
    //            _dateTimeStream,
    //            _mousePressedObservable,
    //            //outer time window:
    //            l => Observable.Timer(TimeSpan.FromSeconds(1)),
    //            //inner time window on how long the user input is valid
    //            s => Observable.Empty<Unit>(),
    //            (i, s) => $"button {(s ? "pressed" : "released")} in window {i}"
    //        );



    //        joined.Subscribe(d => Title = d);

    //    }
    //}
}
