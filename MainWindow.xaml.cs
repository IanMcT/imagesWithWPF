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

namespace imageExample
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

        private void btnChangePic_Click(object sender, RoutedEventArgs e)
        {
            int x = 2;
            if (x > 0)
                {
                MessageBox.Show("greater!");
                }
            if (x <= 0) { MessageBox.Show("less than greater!"); }
            if (x == 0) { MessageBox.Show("Equal!"); } else if (x == 1) { MessageBox.Show("it is 1!"); } else {
                MessageBox.Show("nothing fit!");
            }
            BitmapImage bi = new BitmapImage(new Uri("https://i.ebayimg.com/images/i/251420608123-0-1/s-l1000.jpg"));
            imgPicture.Source = bi;
            btnChangePic.Visibility = Visibility.Hidden;
            btnChangeBack.Visibility = Visibility.Visible;
        }

        private void btnChangeBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
