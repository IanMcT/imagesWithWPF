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
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.ShowDialog();
            BitmapImage bi = new BitmapImage(new Uri(openFileDialog.FileName));

            System.Windows.Media.ImageMetadata im = bi.Metadata;
            MessageBox.Show(im.ToString());

            WriteableBitmap bitmap = new WriteableBitmap(bi);
            imgPicture.Source = bi;

             //bitmap
/*            BitmapImage bi = new BitmapImage(new Uri(openFileDialog.FileName));
            imgPicture.Source = bi;

            int stride = bi.PixelWidth * 4;
            int size = bi.PixelHeight * stride;
            byte[] pixels = new byte[size];
            bi.CopyPixels(pixels, stride, 0);

            

            int x = 0;
            int y = 0;
            int index = y * stride + 4 * x;


            byte red = pixels[index];
            byte green = pixels[index + 1];
            byte blue = pixels[index + 2];
            byte alpha = pixels[index+3];
            MessageBox.Show(red.ToString()+", " + green.ToString() + ", " + blue.ToString());
            */
        }

        private void btnChangeBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
