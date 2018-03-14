using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for DefaultMap.xaml
    /// </summary>
    public partial class DefaultMap : Window
    {
        private MapWindow mw;
        private string img_path = null;

        public DefaultMap(MapWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri(img_path, UriKind.Relative));
            mw.Goal.Background = ib;
            Close();
        }

        private void Img1Img_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_path = @".\..\..\Images\phys_world_map_.jpg";
            Img1.Background = Brushes.Green;
            Img2.Background = Brushes.White;
        }

        private void Img2Img_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_path = @".\..\..\Images\color_blank.png";
            Img2.Background = Brushes.Green;
            Img1.Background = Brushes.White;
        }
    }
}
