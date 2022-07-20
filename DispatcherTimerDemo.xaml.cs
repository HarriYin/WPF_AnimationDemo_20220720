using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_AnimationDemo
{
    /// <summary>
    /// DispatcherTimerDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DispatcherTimerDemo : Window
    {
        private double maxWidth = 100;
        private double startWidth = 0;


        public DispatcherTimerDemo()
        {
            InitializeComponent();

            startWidth = rectangle.Width;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer tmr = new DispatcherTimer();
            tmr.Interval = TimeSpan.FromMilliseconds(100);
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Tmr_Tick(object? sender, EventArgs e)
        {
            rectangle.Width += 10;
            if (rectangle.Width > maxWidth)
            {
                rectangle.Width = startWidth;
                (sender as DispatcherTimer).Stop();
            }
        }
    }
}
