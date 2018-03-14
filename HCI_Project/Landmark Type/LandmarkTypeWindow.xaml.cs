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
using System.ComponentModel;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for LandmarkTypeWindow.xaml
    /// </summary>
    public partial class LandmarkTypeWindow : Window, INotifyPropertyChanged
    {
        private bool doNotShow = false;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private Map map;
        private ListTypesWindow ltw=null;

        public string _image;
        public string Image_Path
        {
            get
            {
                return _image;
            }
            set
            {
                if (!_image.Equals(value))
                {
                    _image = value;
                    OnPropertyChanged("Image_Path");
                }
            }
        }

        public LandmarkTypeWindow(Map map, ListTypesWindow ltw)
        {
            InitializeComponent();
            this.map = map;
            this.ltw = ltw;
            _image = "/HCI_Project;component/Images/missing_pic.jpg";
            this.DataContext = this;
        }

        private void OkTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_Click(null, null);
        }

        private void CancelTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cancel_Click(null, null);
        }

        private void ExitTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (!LTID_Field.Text.Equals("") && !LTName_Field.Text.Equals("") && !Image_Path.Equals("/HCI_Project;component/Images/missing_pic.jpg"))
            {
                LandmarkType lt = new LandmarkType(LTID_Field.Text, LTName_Field.Text, _image, LTDescription_Field.Text);

                if (ltw.AddType(lt))
                {
                    ListTypesWindow.notSaved = true;
                    ltw.Search.Text = "";
                    doNotShow = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Landmark type with entered code already exists. \nPlease try again.", "Landmark Type Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                MessageBox.Show("Please enter ID, name and choose an \nimage for your landmark type.", "Landmark Type Data Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to cancel all created changes to your landmark type?\nIf you click Yes, all created changes won't be saved.", "Cancel Landmark Type", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                doNotShow = true;
                this.Close();
            }

        }

        private void Browse_OnClick(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    var file = fileDialog.FileName;
                    _image = file;
                    OnPropertyChanged("Image_Path");
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                default:
                    _image = "/HCI_Project;component/Images/missing_pic.jpg";
                    OnPropertyChanged("Image_Path");
                    break;

            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (!doNotShow)
            {
                MessageBoxResult mbr = MessageBox.Show("Are you sure you want to exit creating landmark type?",
                    "Exit Landmark Type", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }

                if (ltw.tempLT != null)
                {
                    MessageBoxResult mbr1 =
                        MessageBox.Show("Do you want to save changes that you made to your landmark type?",
                            "Save Landmark Type", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (mbr1 == MessageBoxResult.Yes)
                    {
                        OK_Click(null, null);
                    }
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ltw.ltw = null;
        }

    }
}
