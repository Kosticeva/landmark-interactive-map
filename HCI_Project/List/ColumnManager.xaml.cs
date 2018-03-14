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

namespace HCI_Project.Find_and_list
{
    /// <summary>
    /// Interaction logic for ColumnManager.xaml
    /// </summary>
    public partial class ColumnManager : Window
    {
        private LandmarkListWindow llw = null;
        
        public ColumnManager(LandmarkListWindow llw)
        {
            this.llw = llw;
            InitializeComponent();
            foreach (var c in llw.dgrLandmarks.Columns)
            {
                switch (c.Header.ToString())
                {
                    case "ID":
                        if(c.Visibility==Visibility.Visible)
                            IDC.IsChecked = true;
                        else
                            IDC.IsChecked = false;
                        break;
                    case "Name":
                        if (c.Visibility == Visibility.Visible)
                            NameC.IsChecked = true;
                        else
                            NameC.IsChecked = false;
                        break;
                    case "Description":
                        if (c.Visibility == Visibility.Visible)
                            DescC.IsChecked = true;
                        else
                            DescC.IsChecked = false;
                        break;
                    case "Climate":
                        if (c.Visibility == Visibility.Visible)
                            ClimC.IsChecked = true;
                        else
                            ClimC.IsChecked = false;
                        break;
                    case "Tourist status":
                        if (c.Visibility == Visibility.Visible)
                            TSC.IsChecked = true;
                        else
                            TSC.IsChecked = false;
                        break;
                    case "Revenue":
                        if (c.Visibility == Visibility.Visible)
                            Rev.IsChecked = true;
                        else
                            Rev.IsChecked = false;
                        break;
                    case "Ecologically endangered?":
                        if (c.Visibility == Visibility.Visible)
                            EcoC.IsChecked = true;
                        else
                            EcoC.IsChecked = false;
                        break;
                    case "Habitat of endangered species?":
                        if (c.Visibility == Visibility.Visible)
                            HabC.IsChecked = true;
                        else
                            HabC.IsChecked = false;
                        break;
                    case "Located in urban environment?":
                        if (c.Visibility == Visibility.Visible)
                            UrbC.IsChecked = true;
                        else
                            UrbC.IsChecked = false;
                        break;
                    case "Date of discovery":
                        if (c.Visibility == Visibility.Visible)
                            DateC.IsChecked = true;
                        else
                            DateC.IsChecked = false;
                        break;
                    case "Landmark Type":
                        if (c.Visibility == Visibility.Visible)
                            LTC.IsChecked = true;
                        else
                            LTC.IsChecked = false;
                        break;
                    case "Image":
                        if (c.Visibility == Visibility.Visible)
                            ImgC.IsChecked = true;
                        else
                            ImgC.IsChecked = false;
                        break;
                    case "Tags":
                        if (c.Visibility == Visibility.Visible)
                            TagC.IsChecked = true;
                        else
                            TagC.IsChecked = false;
                        break;
                }
            }
        }

        private void IDC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c= llw.dgrLandmarks.Columns[0];
            c.Visibility = Visibility.Visible;
        }

        private void IDC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[0];
            c.Visibility = Visibility.Hidden;
        }

        private void NameC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[1];
            c.Visibility = Visibility.Visible;
        }

        private void NameC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[1];
            c.Visibility = Visibility.Hidden;
        }

        private void DescC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[2];
            c.Visibility = Visibility.Visible;
        }

        private void DescC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[2];
            c.Visibility = Visibility.Hidden;
        }

        private void ClimC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[3];
            c.Visibility = Visibility.Visible;
        }

        private void ClimC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[3];
            c.Visibility = Visibility.Hidden;
        }

        private void TSC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[4];
            c.Visibility = Visibility.Visible;
        }

        private void TSC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[4];
            c.Visibility = Visibility.Hidden;
        }

        private void Rev_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[5];
            c.Visibility = Visibility.Visible;
        }

        private void Rev_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[5];
            c.Visibility = Visibility.Hidden;
        }

        private void EcoC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[6];
            c.Visibility = Visibility.Visible;
        }

        private void EcoC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[6];
            c.Visibility = Visibility.Hidden;
        }

        private void HabC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[7];
            c.Visibility = Visibility.Visible;
        }

        private void HabC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[7];
            c.Visibility = Visibility.Hidden;
        }

        private void UrbC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[8];
            c.Visibility = Visibility.Visible;
        }

        private void UrbC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[8];
            c.Visibility = Visibility.Hidden;
        }

        private void DateC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[9];
            c.Visibility = Visibility.Visible;
        }

        private void DateC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[9];
            c.Visibility = Visibility.Hidden;
        }

        private void LTC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[10];
            c.Visibility = Visibility.Visible;
        }

        private void LTC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[10];
            c.Visibility = Visibility.Hidden;
        }

        private void ImgC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[11];
            c.Visibility = Visibility.Visible;
        }

        private void ImgC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[11];
            c.Visibility = Visibility.Hidden;
        }

        private void TagC_Checked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[12];
            c.Visibility = Visibility.Visible;
        }

        private void TagC_Unchecked(object sender, RoutedEventArgs e)
        {
            DataGridColumn c = llw.dgrLandmarks.Columns[12];
            c.Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            llw.cm = null;
        }

    }
}
