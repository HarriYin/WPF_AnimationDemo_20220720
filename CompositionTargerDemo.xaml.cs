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

namespace WPF_AnimationDemo
{
    /// <summary>
    /// CompositionTargerDemo.xaml 的交互逻辑
    /// </summary>
    public partial class CompositionTargerDemo : Window
    {
     

        public CompositionTargerDemo()
        {
            InitializeComponent();
        }

        private double maxWidth = 300;
        private double startWidth = 0;
        void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            rectangle.Width += 10;
            if (rectangle.Width >= maxWidth)
            {
                rectangle.Width = startWidth;
                CompositionTarget.Rendering -= new EventHandler(CompositionTarget_Rendering);
                btnCompositionTarget.IsEnabled = true;
            }
        }

        private void btnCompositionTarget_Click(object sender, RoutedEventArgs e)
        {
            CompositionTarget.Rendering += new EventHandler(CompositionTarget_Rendering);
        }
    }
}
