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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_AnimationDemo
{
    /// <summary>
    /// PropertyAnimationDemo.xaml 的交互逻辑
    /// </summary>
    public partial class PropertyAnimationDemo : Window
    {
        public PropertyAnimationDemo()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 30;
            doubleAnimation.To = 300;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2.7);
            doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
            //doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;

            rectangle.BeginAnimation(Rectangle.WidthProperty,doubleAnimation);
        }
    }
}
