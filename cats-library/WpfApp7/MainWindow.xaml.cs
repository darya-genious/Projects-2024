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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
         
            if (sender == cats1.Items[0])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\kerl.jpg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[1])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\mein-kun1.jpg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[2])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\pers.jpeg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[3])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\regdoll.jpeg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[4])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\britan.jpg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[5])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\nevskaya.jpeg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[6])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\turkish.jpg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[7])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\norv.jpg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[8])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\siberian.jpeg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
            if (sender == cats1.Items[9])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\laperm.jpeg", UriKind.Absolute));
                img1.Source = new_source;
                img1.InvalidateVisual();
            }
        }

        private void ListBoxItem_Selected2(object sender, RoutedEventArgs e)
        {
            if (sender == cats2.Items[0])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\karaket.jpeg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[1])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\karakal.jpeg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[2])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\kamysh.jpg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[3])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\bob.jpg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[4])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\anatol.png", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[5])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\burman.jpeg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[6])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\bombey.jpeg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[7])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\bengal.jpeg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[8])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\american.jpg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
            if (sender == cats2.Items[9])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\korat.jpeg", UriKind.Absolute));
                img2.Source = new_source;
                img2.InvalidateVisual();
            }
        }

        private void ListBoxItem_Selected3(object sender, RoutedEventArgs e)
        {

            if (sender == cats3.Items[0])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\peterbold.jpg", UriKind.Absolute));
                img3.Source = new_source;
                img3.InvalidateVisual();
            }
            if (sender == cats3.Items[1])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\donskoy.jpeg", UriKind.Absolute));
                img3.Source = new_source;
                img3.InvalidateVisual();
            }
            if (sender == cats3.Items[2])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\kanadsky.jpg", UriKind.Absolute));
                img3.Source = new_source;
                img3.InvalidateVisual();
            }
            if (sender == cats3.Items[3])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\ykr.jpeg", UriKind.Absolute));
                img3.Source = new_source;
                img3.InvalidateVisual();
            }
            if (sender == cats3.Items[4])
            {
                BitmapImage new_source = new BitmapImage(new Uri("C:\\Users\\AseR\\Desktop\\files\\cats\\elf.jpeg", UriKind.Absolute));
                img3.Source = new_source;
                img3.InvalidateVisual();
            }
        }
    }
}
