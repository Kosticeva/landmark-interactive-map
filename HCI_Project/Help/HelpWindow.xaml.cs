using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow(string key)
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            string[] parts = key.Split('|');

            string path = String.Format(@"{0}/Help_Pages/{1}.htm", curDir, parts[0]);
            if (!File.Exists(path))
            {
                key = "error";
            }
            Uri u = new Uri(String.Format("file:///{0}/Help_Pages/{1}.htm#{2}", curDir, parts[0], parts[1]));
            wbHelp.Navigate(u);
        }
    }
}
