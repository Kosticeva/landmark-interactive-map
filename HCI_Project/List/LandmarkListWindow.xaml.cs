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
using System.Collections.ObjectModel;
using HCI_Project.Find_and_list;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for LandmarkListWindow.xaml
    /// </summary>
    public partial class LandmarkListWindow : Window
    {
        public static bool notSaved = false;
        public bool doNotShow = false;
        public ColumnManager cm = null;
        public LandmarkWindow lw = null;

        //private Canvas cc;
        private ObservableCollection<Landmark> AllLandmarks;
        public ObservableCollection<Landmark> AvailableLandmarks
        {
            get;
            set;
        }

        Map m;
        public Landmark copy = null;
        private MapWindow ancestor;

        public LandmarkListWindow(MapWindow mw, Map m)
        {
            InitializeComponent();
            this.m = m;
            ancestor = mw;

            AvailableLandmarks = new ObservableCollection<Landmark>();
            AllLandmarks = new ObservableCollection<Landmark>();

            foreach (var mark in m.getLandmarks())
            {
                AvailableLandmarks.Add(mark);
                AllLandmarks.Add(mark);
            }

            this.DataContext = this;
        }

        private void EditLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Double_OnClick(null,null);
        }

        private void DeleteLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Delete_OnClick(null,null);
        }

        private void OkLandmarksCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_OnClick(null,null);
        }

        private void CancelLandmarksCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cancel_OnClick(null,null);
        }

        private void ExitLandmarksCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            Landmark l = (Landmark)dgrLandmarks.SelectedItem;
            if (l == null)
                MessageBox.Show("Please select one of the landmarks.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                AvailableLandmarks.Remove(l);
                AllLandmarks.Remove(l);

                foreach (var v in ancestor.tempLandmarks)
                {
                    if (v.ID.Equals(l.ID))
                    {
                        ancestor.tempLandmarks.Remove(v);

                        foreach (var w in ancestor.Goal.Children)
                        {
                            LandmarkView lw = w as LandmarkView;
                            if (lw != null)
                            {
                                if (lw.LandmarkId.Equals(l.ID))
                                {
                                    ancestor.Goal.Children.Remove(lw);
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }

                notSaved = true;
            }
        }

        private void Double_OnClick(object sender, MouseButtonEventArgs e)
        {
            if (lw == null)
            {
                lw = new LandmarkWindow(m, this);
                lw.Show();
                Landmark l = (Landmark) dgrLandmarks.SelectedItem;
                lw.tempPosition = l.position;
                copy = l;
                lw.ID_Field.Text = l.ID;
                lw.Name_Field.Text = l.Name;
                lw.Description_Field.Text = l.Description;
                lw.ChosenType = l.Type;

                if (l.Type != null)
                    lw.Chosen_landmark_type.Text = l.Type.TypeView;
                else
                {
                    lw.Chosen_landmark_type.Text = "";
                }

                lw.Climate_Field.SelectedItem = l.Climate;
                lw.TouristStatus_Field.SelectedItem = l.TStatus;
                lw.AnnualRevenue_Field.Text = l.Revenue.ToString();
                lw.DateDiscovery.SelectedDate = DateTime.Parse(l.DoD);
                lw.Tags_Field.Text = l.TagView;
                lw.tags = l.getTags();
                lw.Image_Path = l.imagePath;
                lw.Eco.IsChecked = l.EE;
                lw.Danger.IsChecked = l.HAB;
                lw.Habitated.IsChecked = l.URB;
            }
            else
            {
                lw.Topmost = true;  // important
                lw.Topmost = false; // important
                lw.Focus();         // important
            }
        }

        public bool AddALandmark(Landmark l)
        {
             Search.Text = "";
             bool found = false;
             if (copy == null)
             {
                 foreach (var tt in AvailableLandmarks){
                     if (tt.Equals(l))
                     {
                         found = true;
                         break;
                     }
                 }

                 if (!found)
                 {
                     AvailableLandmarks.Add(l);
                     AllLandmarks.Add(l);
                     return true;
                 }

                 return false;
             }

             if (!copy.Equals(l))
             {
                 AvailableLandmarks.Remove(copy);
                 AvailableLandmarks.Add(l);
             }

            bool Exists = false;
            for(int i=0; i<ancestor.tempLandmarks.Count; i++)//each (var v in ancestor.tempLandmarks)
            {
                var v = ancestor.tempLandmarks[i];
                if (v.ID.Equals(copy.ID))
                {
                    ancestor.tempLandmarks.Remove(v);
                    Exists = true;
                    for(int j=0; j<ancestor.Goal.Children.Count; j++)//(var w in ancestor.Goal.Children)
                    {
                        LandmarkView vv = ancestor.Goal.Children[j] as LandmarkView;
                        if (vv != null)
                        {
                            if (vv.LandmarkId.Equals(copy.ID))
                            {
                                ancestor.Goal.Children.Remove(vv);
                                ancestor.removeRectangle(vv.Position);

                                LandmarkView sp = new LandmarkView(l.ID, l.position, l.imagePath);
                                sp.Background = Brushes.White;
                                Rectangle r = new Rectangle();
                                r.Width = 50;
                                r.Height = 50;
                                r.Stroke = Brushes.Black;
                                r.StrokeThickness = 1;
                                ImageBrush ib = new ImageBrush();
                                ib.ImageSource = new BitmapImage(new Uri(l.imagePath, UriKind.RelativeOrAbsolute));
                                r.Fill = ib;
                                sp.Width = 54;
                                sp.Height = 54;
                                ancestor.Goal.Children.Add(sp);
                                ancestor.Goal.Children.Add(r);
                                //sp.MouseLeftButtonUp += ancestor.map.doRightClick;
                                //r.MouseLeftButtonUp += ancestor.map.doRightClick;
                                Canvas.SetLeft(sp, sp.Position.X-2 /*+ (tbt.Width/2)*/);
                                Canvas.SetTop(sp, sp.Position.Y-2 /*+ (tbt.Height/2)*/);
                                Canvas.SetLeft(r, sp.Position.X);
                                Canvas.SetTop(r, sp.Position.Y);
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            
            if (Exists)
            {
                ancestor.tempLandmarks.Add(l);
            }

             return true;
        }

        private void OK_OnClick(object sender, RoutedEventArgs e)
        {
            if (lw != null)
                lw.Close();

            m.setLandmarks(AvailableLandmarks);
            m.copyLandmarks(ancestor.tempLandmarks);
            m.setPlacedLandmarks();
            MapWindow.notSaved = true;
            doNotShow = true;
            this.Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to cancel all created changes to your landmarks?\nIf you click Yes, all created changes won't be saved.", "Cancel Landmarks", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                if (lw != null)
                    lw.Close();

                doNotShow=true;
                m.setPlacedLandmarks();
                this.Close();
            }
        }

        private void Go_OnClick(object sender, TextChangedEventArgs e)
        {
            string input = Search.Text.Trim();

            for (int i = AvailableLandmarks.Count - 1; i >= 0; i--)
            {
                AvailableLandmarks.RemoveAt(i);
            }

            if(input.Equals(""))
            {
                foreach (var l in AllLandmarks)
                {
                    AvailableLandmarks.Add(l);
                }
                return;
            }

            foreach (var l in AllLandmarks)
            {
                if (l.Similar(input))
                {
                    AvailableLandmarks.Add(l);
                }
            }
        }

        private void Manage_OnClick(object sender, RoutedEventArgs e)
        {
            if(cm==null)
                cm = new ColumnManager(this);
            cm.Show();
        }

        Point startPoint = new Point();
        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Get the dragged ListViewItem
                Landmark l = (Landmark)((DataGrid)sender).SelectedItem;
                DataGridRow dgr = new DataGridRow();
                dgr.Item = l;

                // Find the data behind the ListViewItem

                Landmark ll = new Landmark(l.ID, l.Name, l.Description, l.Type, l.Tags,
                l.Climate, l.TStatus, l.Revenue, l.DoD, l.imagePath, l.EE, l.HAB, l.URB, l.position);
                // Initialize the drag & drop operation
                DataObject dragData = new DataObject("landmark", ll);
                DragDrop.DoDragDrop(dgr, dragData, DragDropEffects.Move);
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (!doNotShow)
            {
                MessageBoxResult mbr = MessageBox.Show("Are you sure you want to exit managing landmarks?",
                    "Exit Landmarks", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr == MessageBoxResult.Yes)
                {
                    if (lw != null)
                        lw.Close();

                    if (notSaved)
                    {
                        MessageBoxResult mbr1 =
                            MessageBox.Show("Do you want to save all created changes before exiting?",
                                "Save Landmarks", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (mbr1 == MessageBoxResult.Yes)
                        {
                            m.setLandmarks(AvailableLandmarks);
                            m.copyLandmarks(ancestor.tempLandmarks);
                            m.setPlacedLandmarks();
                            MapWindow.notSaved = true;
                        }
                        else
                        {
                            m.setPlacedLandmarks();
                        }
                    }

                    if (cm != null)
                        cm.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            ancestor.llw = null;
        }

    }
}
