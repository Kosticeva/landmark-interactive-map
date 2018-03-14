using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Xceed.Wpf.Toolkit;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for TagWindow.xaml
    /// </summary>
    public partial class TagWindow : Window
    {
        private Map map;
        private ListTagsWindow ltw= null;
        private bool doNotShow = false;

        public TagWindow(Map map, ListTagsWindow ltw)
        {
            InitializeComponent();
            this.map = map;
            this.ltw = ltw;
            DataContext = this;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (!TagID_Field.Text.Equals(""))
            {
                Tag t = new Tag(TagID_Field.Text, ClrPcker_Background.SelectedColorText, TagDescription_Field.Text);

                if (ltw.addATag(t))
                {
                    ListTagsWindow.notSaved=true;
                    ltw.Search.Text = "";
                    doNotShow = true;
                    Close();
                }
                else
                    System.Windows.MessageBox.Show("Tag with entered code already exists. \nPlease try again.", "Tag Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                System.Windows.MessageBox.Show("Please enter ID for your tag.", "Tag Data Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = System.Windows.MessageBox.Show("Are you sure you want to cancel all created changes to your tag?\nIf you click Yes, all created changes won't be saved.", "Cancel Tag", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                doNotShow = true;
                this.Close();
            }

        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (!doNotShow)
            {
                MessageBoxResult mbr = System.Windows.MessageBox.Show("Are you sure you want to exit creating tag?",
                    "Exit Tag", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }

                if (ltw.copy != null)
                {
                    MessageBoxResult mbr1 =
                        System.Windows.MessageBox.Show("Do you want to save changes that you made to your tag?",
                            "Save Tag", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (mbr1 == MessageBoxResult.Yes)
                    {
                        OK_Click(null, null);
                    }
                }
            }
        }

        private void OkTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_Click(null,null);
        }

        private void CancelTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cancel_Click(null,null);
        }

        private void ExitTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ltw.tw = null;
        }

    }
}
