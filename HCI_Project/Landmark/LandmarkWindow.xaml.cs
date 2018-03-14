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
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using EnvDTE;
using Path = System.Windows.Shapes.Path;
using Window = System.Windows.Window;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for LandmarkWindow.xaml
    /// </summary>
    public partial class LandmarkWindow : Window, INotifyPropertyChanged
    {
        public bool doNotShow = false;
        public LandmarkType ChosenType=null;
        public ObservableCollection<Tag> tags;
        private LandmarkListWindow llw = null;
        public bool SetPicture = false;
        public Point? tempPosition = null;

        private Landmark l;
        public ListTypesWindow ltw = null;
        public ListTagsWindow ltw1 = null;

        public Landmark getLandmark()
        {
            return l;
        }

        private Map map
        {
            get;
            set;
        }

        private string _image;
        public string Image_Path
        {
            get
            {
                return _image;
            }
            set
            {
                if (!value.Equals(_image))
                {
                    _image = value;
                    OnPropertyChanged("Image_Path");
                }
            }
        }

        private double _revenue;
        public double Revenue
        {
            get
            {
                return _revenue;
            }
            set
            {
                if (value != _revenue)
                {
                    _revenue = value;
                    OnPropertyChanged("Revenue");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }

        public LandmarkWindow(Map map)
        {
            InitializeComponent();
            this.map = map;
            tags = new ObservableCollection<Tag>();
            this.DataContext = this;
            this.Climate_Field.Items.Add("Ice cap");
            this.Climate_Field.Items.Add("Continental");
            this.Climate_Field.Items.Add("Moderate continental");
            this.Climate_Field.Items.Add("Subtropic");
            this.Climate_Field.Items.Add("Tropic");
            this.Climate_Field.Items.Add("Desert");
            this.TouristStatus_Field.Items.Add("Exploated");
            this.TouristStatus_Field.Items.Add("Available");
            this.TouristStatus_Field.Items.Add("Not available");
            _image = "/HCI_Project;component/Images/missing_pic.jpg";
        }

        public LandmarkWindow(Map map, LandmarkListWindow lw)
        {
            InitializeComponent();
            this.map = map;
            llw = lw;
            this.Climate_Field.Items.Add("Ice cap");
            this.Climate_Field.Items.Add("Continental");
            this.Climate_Field.Items.Add("Moderate continental");
            this.Climate_Field.Items.Add("Subtropic");
            this.Climate_Field.Items.Add("Tropic");
            this.Climate_Field.Items.Add("Desert");
            this.TouristStatus_Field.Items.Add("Exploated");
            this.TouristStatus_Field.Items.Add("Available");
            this.TouristStatus_Field.Items.Add("Not available");
            this.DataContext = this;
        }

        private void ManageTypesCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewType_OnClick(null, null);
        }

        private void ManageTagsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewTag_OnClick(null, null);
        }

        private void OkLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_Click(null, null);
        }

        private void CancelLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cancel_Click(null, null);
        }

        private void ExitLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (!ID_Field.Text.Equals("") && !Name_Field.Text.Equals("") && DateDiscovery.SelectedDate!=null && ChosenType!=null)
            {
                List<Tag> ttags = tags.ToList<Tag>();

                if (tempPosition == null)
                {
                    l = new Landmark(ID_Field.Text, Name_Field.Text, Description_Field.Text, ChosenType, ttags,
                        Climate_Field.SelectedValue.ToString(),
                        TouristStatus_Field.SelectedValue.ToString(), Double.Parse(AnnualRevenue_Field.Text),
                        DateDiscovery.SelectedDate.Value.Date.ToShortDateString(),
                        _image, (bool) Eco.IsChecked, (bool) Danger.IsChecked, (bool) Habitated.IsChecked,
                        new Point(-100, -100));
                }
                else
                {
                    l = new Landmark(ID_Field.Text, Name_Field.Text, Description_Field.Text, ChosenType, ttags,
                        Climate_Field.SelectedValue.ToString(),
                        TouristStatus_Field.SelectedValue.ToString(), Double.Parse(AnnualRevenue_Field.Text),
                        DateDiscovery.SelectedDate.Value.Date.ToShortDateString(),
                        _image, (bool)Eco.IsChecked, (bool)Danger.IsChecked, (bool)Habitated.IsChecked,
                        (Point)tempPosition); 
                }

                if (llw != null)
                {
                    if (llw.AddALandmark(l))
                    {
                        if (ltw1 != null)
                            ltw1.Close();
                        if (ltw != null)
                            ltw.Close();

                        LandmarkListWindow.notSaved = true;
                        llw.Search.Text = "";
                        doNotShow = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Landmark with entered code already exists. \nPlease try again.", "Landmark Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (map.addLandmark(l))
                    {
                        if (ltw1 != null)
                            ltw1.Close();
                        if (ltw != null)
                            ltw.Close();

                        MapWindow.notSaved = true;
                        doNotShow = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Landmark with entered code already exists. \nPlease try again.", "Landmark Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter ID, name and select date of \ndiscovery and landmark type for your landmark", "Landmark Data Error", MessageBoxButton.OK, MessageBoxImage.Warning); 
            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to cancel all created changes to your landmark?\nIf you click Yes, all created changes won't be saved.", "Cancel Landmark", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                if (ltw1 != null)
                    ltw1.Close();
                if (ltw != null)
                    ltw.Close();

                doNotShow = true;
                this.Close();
            }
        }

        private void NewTag_OnClick(object sender, RoutedEventArgs e)
        {
            if (ltw1 == null)
            {
                ltw1 = new ListTagsWindow(map, this);
                ltw1.Show();
            }
            else
            {
                ltw1.Topmost = true; // important
                ltw1.Topmost = false; // important
                ltw1.Focus(); // important
            }
        }

        private void NewType_OnClick(object sender, RoutedEventArgs e)
        {
            if (ltw == null)
            {
                ltw = new ListTypesWindow(map, this);
                ltw.Show();
                if (ChosenType != null)
                {
                    ltw.LTID.Text = ChosenType.TypeView;
                }
            }
            else
            {
                ltw.Topmost = true;  // important
                ltw.Topmost = false; // important
                ltw.Focus();         // important
            }
        }

        private void Browse_OnClick(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    SetPicture = true;
                    _image = fileDialog.FileName;
                    OnPropertyChanged("Image_Path");
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    break;
                default:
                    _image = "/HCI_Project;component/Images/missing_pic.jpg";
                    OnPropertyChanged("Image_Path");
                    break;

            }
        }

        private void Tags_Field_TextChanged(object sender, RoutedEventArgs e)
        {
            List<Tag> newTags = new List<Tag>();
            string fullText = Tags_Field.Text;
            string[] tagss = fullText.Split(' ');

            string invalidtags = "";

            for (int i = 0; i < tagss.Length; i++)
            {
                string rightForm = tagss[i].Replace('#', ' ');
                rightForm = rightForm.Trim();

                Tag t = map.getTag(rightForm);

                if (t != null) //ako tag postoji
                {
                    newTags.Add(t);
                }
                else
                {
                    invalidtags += tagss[i]+" ";
                }

            }

            tags = new ObservableCollection<Tag>(newTags);
            invalidtags = invalidtags.Trim();
            if (!invalidtags.Equals(""))
            {
                MessageBox.Show(
                    "Tag(s) " + invalidtags +
                    " do not exist. \nIf you want to use them, please make sure you create them first.", "Tag Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                ListTagsWindow tw = new ListTagsWindow(map, this);
                tw.Show();
            }

        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (!doNotShow)
            {
                MessageBoxResult mbr = MessageBox.Show("Are you sure you want to exit creating landmark?",
                    "Exit Landmark", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }

                if (llw != null)
                {
                    if (llw.copy != null)
                    {
                        if (ltw1 != null)
                            ltw1.Close();
                        if (ltw != null)
                            ltw.Close();

                        MessageBoxResult mbr1 =
                            MessageBox.Show("Do you want to save changes that you made to your landmark?",
                                "Save Landmark", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (mbr1 == MessageBoxResult.Yes)
                        {
                            OK_Click(null,null);
                        }

                    }
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if(llw!=null)
                llw.lw = null;
        }
    }
}

