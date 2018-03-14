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
using System.Collections.ObjectModel;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for ListTypesWindow.xaml
    /// </summary>
    public partial class ListTypesWindow : Window
    {
        public static bool notSaved;
        public Map map;
        public LandmarkWindow lw = null;
        public List<Landmark> tempLandmarks;
        public LandmarkType tempLT;
        private bool changing = false;
        private LandmarkType forChanging;
        private bool doNotShow = false;
        public LandmarkTypeWindow ltw = null;

        private ObservableCollection<LandmarkType> ptypes;
        public ObservableCollection<LandmarkType> ltypes
        {
            get;
            set;
        }

        public ListTypesWindow(Map map, LandmarkWindow lw)
        {
            InitializeComponent();
            notSaved = false;
            this.map = map;
            tempLandmarks = new List<Landmark>();
            foreach (Landmark l in this.map.getLandmarks())
            {
                Landmark ll = new Landmark(l.ID, l.Name, l.Description, l.Type, l.Tags, 
                    l.Climate, l.TStatus, l.Revenue, l.DoD, l.imagePath, l.EE, l.HAB, l.URB, l.position);    
                tempLandmarks.Add(ll);
            }

            this.lw = lw;
            ptypes = new ObservableCollection<LandmarkType>();
            ltypes = new ObservableCollection<LandmarkType>();
            foreach (var t in this.map.getLandmarkTypes())
            {
                ptypes.Add(t);
                ltypes.Add(t);
            }

            this.DataContext = this;
        }

        public ListTypesWindow(Map map)
        {
            InitializeComponent();
            notSaved = false;
            this.map = map;
            tempLandmarks = new List<Landmark>();
            foreach (Landmark l in this.map.getLandmarks())
            {
                Landmark ll = new Landmark(l.ID, l.Name, l.Description, l.Type, l.Tags,
                    l.Climate, l.TStatus, l.Revenue, l.DoD, l.imagePath, l.EE, l.HAB, l.URB, l.position);
                tempLandmarks.Add(ll);
            }

            this.lw = null;
            ptypes = new ObservableCollection<LandmarkType>();
            ltypes = new ObservableCollection<LandmarkType>();
            foreach (var t in this.map.getLandmarkTypes())
            {
                ptypes.Add(t);
                ltypes.Add(t);
            }
            this.Select.IsEnabled = false;
            this.DataContext = this;
        }

        private void NewType_OnClick(object sender, RoutedEventArgs e)
        {
            if (ltw == null)
            {
                ltw = new LandmarkTypeWindow(map, this);
                ltw.Show();
            }
            else
            {
                ltw.Topmost = true;  // important
                ltw.Topmost = false; // important
                ltw.Focus();         // important
            }
        }

        private void NewLandmarkType1CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewType_OnClick(null, null);
        }

        private void SelectLandmarkTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Select_OnClick(null, null);
        }

        private void DeleteLandmarkTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Delete_OnClick(null, null);
        }

        private void EditTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Double_OnClick(null, null);
        }

        private void OkTypesCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_OnClick(null, null);
        }

        private void CancelTypesCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cancel_OnClick(null, null);
        }

        private void ExitTypesCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to cancel all created changes to your landmark types?\nIf you click Yes, all created changes won't be saved.", "Cancel Landmark Types", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                if (ltw != null)
                {
                    ltw.Close();
                }

                doNotShow = true;
                this.Close();
            }
        }

        private void OK_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.Select.IsEnabled)
            {
                if (ltw != null)
                {
                    ltw.Close();
                }

                lw.ChosenType = tempLT;
                lw.Chosen_landmark_type.Text = tempLT.TypeView;
                if(!lw.SetPicture)
                    lw.Image_Path = tempLT.IconPath;
                map.setLandmarkTypes(ptypes);
                map.setLandmarks(new ObservableCollection<Landmark>(tempLandmarks));
                MapWindow.notSaved = true;
                doNotShow = true;
                this.Close();
            }
            else
            {
                if (ltw != null)
                {
                    ltw.Close();
                }

                map.setLandmarkTypes(ptypes);
                map.setLandmarks(new ObservableCollection<Landmark>(tempLandmarks));
                MapWindow.notSaved = true;
                doNotShow = true;
                this.Close();
            }
            /*else
            {
                MessageBox.Show("Please select a valid landmark type.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/
        }

        public bool AddType(LandmarkType lt)
        {
            if (ptypes.Contains(lt) && changing==false)
                return false;

            if (changing == true)
            {
                if (lt.Equals(forChanging))
                {
                }
                else
                {
                    ptypes.Remove(forChanging);
                    ltypes.Remove(forChanging);
                    ptypes.Add(lt);
                    ltypes.Add(lt);
                }
            }
            else
            {
                ptypes.Add(lt);
                ltypes.Add(lt);
            }

            changing = false;
            return true;
        }

        private void Double_OnClick(object sender, MouseButtonEventArgs e)
        {
            if (ltw == null)
            {
                ltw = new LandmarkTypeWindow(map, this);
                forChanging = (LandmarkType) dgrTypes.SelectedItem;
                changing = true;
                ltw.LTID_Field.Text = forChanging.ID;
                ltw.LTName_Field.Text = forChanging.Name;
                ltw.LTDescription_Field.Text = forChanging.Description;
                ltw.Image_Path = forChanging.IconPath;
                ltw.Show();
                if (tempLT != null)
                {
                    if (forChanging.Equals(tempLT))
                    {
                        LTID.Text = "";
                        tempLT = null;
                    }
                }
            }
            else
            {
                ltw.Topmost = true;  // important
                ltw.Topmost = false; // important
                ltw.Focus();         // important
            }
        }

        private void Select_OnClick(object sender, RoutedEventArgs e)
        {
            tempLT = (LandmarkType)dgrTypes.SelectedItem;
            if(Select.Content.Equals("Select"))
            {
                if (tempLT != null)
                {
                    LTID.Text = tempLT.TypeView;
                    Select.Content = "Deselect";
                    notSaved = true;
                }
                else
                    MessageBox.Show("Please select one of the landmark types.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (tempLT != null)
                {
                    tempLT = null;
                    LTID.Text = "";
                    Select.Content = "Select";
                    notSaved = true;
                }
                else
                    MessageBox.Show("Please select one of the landmark types.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            forChanging = (LandmarkType)dgrTypes.SelectedItem;

            if (forChanging != null)
            {
                int cc = map.FindLandmarkTypes(forChanging, tempLandmarks);
                if (cc > 0)
                {
                    MessageBoxResult mbr =
                        MessageBox.Show(
                            "There are " + cc +
                            " landmarks that use the landmark type you want to delete. \nIf you click Yes, you agree to remove deleted landmark type from all landmarks. \nAre you sure you want to continue?",
                            "Landmark Types Found", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (mbr == MessageBoxResult.Yes)
                    {
                        tempLandmarks = map.RemoveLandmarkType(forChanging, tempLandmarks);
                        if (tempLT == forChanging)
                        {
                            tempLT = null;
                        }

                        LTID.Text = "";
                        ptypes.Remove(forChanging);
                        ltypes.Remove(forChanging);
                        MessageBox.Show(
                            "Landmark type " + forChanging.TypeView + " deleted from " + cc + " landmarks",
                            "Landmark Type Deleted", MessageBoxButton.OK, MessageBoxImage.Information);

                        notSaved = true;
                    }
                }
                else
                {
                    ptypes.Remove(forChanging);
                    ltypes.Remove(forChanging);
                    MessageBox.Show(
                        "Landmark type " + forChanging.TypeView + " deleted.",
                        "Landmark Type Deleted", MessageBoxButton.OK, MessageBoxImage.Information);

                    notSaved = true;
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select one of the landmark types.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SelectionChanged_OnClick(object sender, SelectionChangedEventArgs e)
        {
            LandmarkType ltt = (LandmarkType)dgrTypes.SelectedItem;

            if (tempLT != null)
            {
                if (ltt.Equals(tempLT))
                {
                    Select.Content = "Deselect";
                }
                else
                    Select.Content = "Select";
            }
            else
                Select.Content = "Select";
        }

        private void Go_OnClick(object sender, TextChangedEventArgs e)
        {
            bool flag = false;

            string input = Search.Text.Trim();
            if (ltypes != null)
            {
                for (int i = ltypes.Count - 1; i >= 0; i--)
                    ltypes.RemoveAt(i);

                if (input.Equals("") || input.Equals("Search for type"))
                {
                    flag = true;
                    foreach (var l in ptypes)
                    {
                        ltypes.Add(l);
                    }
                }

                if (flag == false)
                {
                    foreach (var l in ptypes)
                    {
                        if (l.Similar(input))
                        {
                            ltypes.Add(l);
                        }
                    }
                }

            }
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!doNotShow)
            {
                MessageBoxResult mbr1 = MessageBox.Show("Are you sure you want to exit choosing landmark type?",
                    "Exit Landmark Types", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr1 == MessageBoxResult.Yes)
                {
                    if (ltw != null)
                    {
                        ltw.Close();
                    }

                    if (notSaved)
                    {
                        MessageBoxResult mbr =
                            MessageBox.Show("Do you want to save all created changes before exiting?",
                                "Save Landmark Types", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (mbr == MessageBoxResult.Yes)
                        {
                            if (tempLT != null && this.Select.IsEnabled)
                            {
                                lw.ChosenType = tempLT;
                                lw.Chosen_landmark_type.Text = tempLT.TypeView;
                                if (!lw.SetPicture)
                                    lw.Image_Path = tempLT.IconPath;
                                map.setLandmarkTypes(ptypes);
                                map.setLandmarks(new ObservableCollection<Landmark>(tempLandmarks));
                                MapWindow.notSaved = true;
                            }
                            else if (!this.Select.IsEnabled)
                            {
                                map.setLandmarkTypes(ptypes);
                                map.setLandmarks(new ObservableCollection<Landmark>(tempLandmarks));
                                MapWindow.notSaved = true;
                            }
                        }
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            lw.ltw = null;
        }
    }

}
