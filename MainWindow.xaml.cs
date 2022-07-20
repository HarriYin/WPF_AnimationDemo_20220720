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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_AnimationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDispatcherTimer_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimerDemo dispatcherTimerDemo = new DispatcherTimerDemo();
            dispatcherTimerDemo.ShowDialog();
            
        }

        private void btnCompositionTarget_Click(object sender, RoutedEventArgs e)
        {
            CompositionTargerDemo compositionTargerDemo = new CompositionTargerDemo();
            compositionTargerDemo.ShowDialog();
        }

        private void btnPropertyAnimation_Click(object sender, RoutedEventArgs e)
        {
            PropertyAnimationDemo propertyAnimationDemo = new PropertyAnimationDemo();
            propertyAnimationDemo.ShowDialog();
        }
    }
}
