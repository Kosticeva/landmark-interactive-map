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
    /// Interaction logic for ListTagsWindow.xaml
    /// </summary>
    public partial class ListTagsWindow : Window
    {
        public Map map;
        public LandmarkWindow lw = null;
        public bool forChange = false;
        public Tag copy;
        public List<Landmark> tempLandmarks;
        public static bool notSaved = false;
        public bool doNotShow = false;
        public TagWindow tw = null;

        private ObservableCollection<Tag> existAllTags;
        public ObservableCollection<Tag> ExistTags
        {
            get;
            set;
        }

        private ObservableCollection<Tag> myAllTags;
        public ObservableCollection<Tag> MyTags
        {
            get;
            set;
        }

        public bool addATag(Tag t)
        {
            Search.Text = "";
            bool found = false;
            if (!forChange)     //ako se ne menja nista, samo trazi govnara
            {
                foreach (var tt in ExistTags)
                {
                    if (tt.ID.Equals(t.ID))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    ExistTags.Add(t);
                    existAllTags.Add(t);
                    notSaved = true;
                    return true;
                }
                
                return false;
            }

            forChange = false;
            //nesto se menja -> treba da se nadje kopija i doda asaf
            if (!copy.Equals(t))
            {
                ExistTags.Remove(copy);
                existAllTags.Remove(copy);
                ExistTags.Add(t);
                existAllTags.Add(t);
                MyTags.Remove(copy);
                myAllTags.Remove(copy);
                MyTags.Add(t);
                myAllTags.Add(t);

            }

            notSaved = true;
            return true;
            
        }

        public ListTagsWindow(Map map, LandmarkWindow lw)
        {
            InitializeComponent();
            this.map = map;
            this.lw = lw;

            tempLandmarks = new List<Landmark>();
            foreach (Landmark l in this.map.getLandmarks())
            {
                Landmark ll = new Landmark(l.ID, l.Name, l.Description, l.Type, l.Tags,
                    l.Climate, l.TStatus, l.Revenue, l.DoD, l.imagePath, l.EE, l.HAB, l.URB, l.position);
                tempLandmarks.Add(ll);
            }

            ExistTags = new ObservableCollection<Tag>();
            existAllTags = new ObservableCollection<Tag>();
            foreach (var t in map.getTags())
            {
                ExistTags.Add(t);  
                existAllTags.Add(t);
            }

            MyTags = new ObservableCollection<Tag>();
            myAllTags = new ObservableCollection<Tag>();
            foreach (var t in lw.tags)
            {
                MyTags.Add(t);
                myAllTags.Add(t);
            }

            this.DataContext = this;
        }

        public ListTagsWindow(Map map)
        {
            InitializeComponent();
            this.map = map;
            this.lw = null;

            tempLandmarks = new List<Landmark>();
            foreach (Landmark l in this.map.getLandmarks())
            {
                Landmark ll = new Landmark(l.ID, l.Name, l.Description, l.Type, l.Tags,
                    l.Climate, l.TStatus, l.Revenue, l.DoD, l.imagePath, l.EE, l.HAB, l.URB, l.position);
                tempLandmarks.Add(ll);
            }

            ExistTags = map.getTags();
            existAllTags = new ObservableCollection<Tag>(map.getTags());
            MyTags = null;
            myAllTags = null;
            this.DataContext = this;
        }

        private void NewTag1CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
           NewTag_OnClick(null,null);
        }

        private void DeleteTag1CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DeleteTag_OnClick(null,null);
        }

        private void AddTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Tag tt = (Tag) dgrCreatedTags.SelectedItem;
            if (tt != null && !MyTags.Contains(tt))
            {
                {
                    MyTags.Add(tt);
                    myAllTags.Add(tt);
                }
                notSaved = true;
            }else
            {
                MessageBox.Show(
                    "Please select one of the tags.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RemoveTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Tag tt = (Tag)dgrSelectedTags.SelectedItem;
            if (tt != null)
            {
                MyTags.Remove(tt);
                myAllTags.Remove(tt);
            }
            else
            {
                MessageBox.Show(
                    "Please select one of the tags.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Tag tt = (Tag)dgrSelectedTags.SelectedItem;
            if (tt != null)
            {
                ChangeTag_OnClick(dgrSelectedTags, null);
                return;
            }
            tt = (Tag)dgrCreatedTags.SelectedItem;
            if (tt != null)
            {
                ChangeTag_OnClick(dgrCreatedTags, null);
                return;
            }

            MessageBox.Show(
                "Please select one of the tags.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void OkTagsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OK_OnClick(null,null);
        }

        private void CancelTagsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cancel_OnClick(null,null);
        }

        private void ExitTagsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure you want to cancel all created changes to your tags?\nIf you click Yes, all created changes won't be saved.", "Cancel Tags", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr == MessageBoxResult.Yes)
            {
                if (tw != null)
                    tw.Close();

                doNotShow = true;
                this.Close();
            }
        }

        private void OK_OnClick(object sender, RoutedEventArgs e)
        {
            if (tw != null)
                tw.Close();

            if (lw!=null)
            {
                string v = "";
                foreach (var t in MyTags)
                {
                    v += t.TagView+" ";
                }

                lw.Tags_Field.Text = v;

                lw.tags = new ObservableCollection<Tag>();
                foreach (var t in MyTags)
                {
                    lw.tags.Add(t);
                }

            }

            map.setTags(existAllTags);
            map.setLandmarks(new ObservableCollection<Landmark>(tempLandmarks));
            MapWindow.notSaved = true;

            doNotShow = true;
            this.Close();
        }

        private void NewTag_OnClick(object sender, RoutedEventArgs e)
        {
            if (tw == null)
            {
                tw = new TagWindow(map, this);
                tw.Show();
            }
            else
            {
                tw.Topmost = true;  // important
                tw.Topmost = false; // important
                tw.Focus();         // important
            }
        }

        private void DeleteTag_OnClick(object sender, RoutedEventArgs e)
        {
            Tag tt = (Tag)dgrCreatedTags.SelectedItem;
            if (tt != null)
            {
                int cc = map.FindTag(tt);
                if (cc > 0)
                {
                    MessageBoxResult mbr =
                        MessageBox.Show(
                            "There are " + cc +
                            " landmarks that use the tag you want to delete. \nIf you click Yes, you agree to remove deleted tag from all landmarks. \nAre you sure you want to continue?",
                            "Tags Found", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (mbr == MessageBoxResult.Yes)
                    {
                        tempLandmarks = map.RemoveTag(tt, tempLandmarks);
                        ExistTags.Remove(tt);
                        existAllTags.Remove(tt);
                        MyTags.Remove(tt);
                        myAllTags.Remove(tt);
                        notSaved = true;
                        MessageBox.Show(
                            "Tag " + tt.TagView + " deleted from " + cc + " landmarks", "Tag Deleted",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    ExistTags.Remove(tt);
                    existAllTags.Remove(tt);
                    MyTags.Remove(tt);
                    myAllTags.Remove(tt);
                    notSaved = true;
                    MessageBox.Show(
                        "Tag " + tt.TagView + " deleted.",
                        "Tag Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select one of the tags.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChangeTag_OnClick(object sender, MouseButtonEventArgs e)
        {
            if (tw == null)
            {
                Tag tt = (Tag) ((DataGrid) sender).SelectedItem;
                if (tt != null)
                {
                    tw = new TagWindow(map, this);
                    copy = tt;
                    forChange = true;
                    tw.TagID_Field.Text = tt.ID;
                    tw.ClrPcker_Background.SelectedColor = (Color) ColorConverter.ConvertFromString(tt.Color);
                    tw.TagDescription_Field.Text = tt.Description;
                    tw.Show();
                }
                else
                {
                    MessageBox.Show("Please select one of the tags.", "Selection Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else
            {
                tw.Topmost = true;  // important
                tw.Topmost = false; // important
                tw.Focus();         // important
            }
        }

        Point startPoint = new Point();

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            if (lw != null)
            {
                Point mousePos = e.GetPosition(null);
                Vector diff = startPoint - mousePos;

                if (e.LeftButton == MouseButtonState.Pressed &&
                    (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                     Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
                {
                    // Get the dragged ListViewItem
                    Tag tt = (Tag) ((DataGrid) sender).SelectedItem;
                    DataGridRow dgr = new DataGridRow();
                    dgr.Item = tt;

                    // Find the data behind the ListViewItem

                    // Initialize the drag & drop operation
                    try
                    {
                        DataObject dragData = new DataObject("myFormat", tt);
                        DragDrop.DoDragDrop(dgr, dragData, DragDropEffects.Move);
                    }
                    catch (Exception ee)
                    {
                        
                    }
                }
            }
        }

        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (lw != null)
            {
                if (!e.Data.GetDataPresent("myFormat") || sender == e.Source)
                {
                    e.Effects = DragDropEffects.None;
                }
            }
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (lw != null)
            {
                if (e.Data.GetDataPresent("myFormat"))
                {
                    Tag tag = e.Data.GetData("myFormat") as Tag;
                    if (tag!=null && !MyTags.Contains(tag))
                    {
                        MyTags.Add(tag);
                        myAllTags.Add(tag);
                    }
                    notSaved = true;
                }
            }
        }

        Point startPoint1 = new Point();

        private void Remove_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint1 = e.GetPosition(null);
        }

        private void Remove_MouseMove(object sender, MouseEventArgs e)
        {
            if (lw != null)
            {
                Point mousePos = e.GetPosition(null);
                Vector diff = startPoint1 - mousePos;

                if (e.LeftButton == MouseButtonState.Pressed &&
                    (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                     Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
                {
                    // Get the dragged ListViewItem
                    Tag tt = (Tag)((DataGrid)sender).SelectedItem;
                    DataGridRow dgr = new DataGridRow();
                    dgr.Item = tt;
                    try
                    {
                        DataObject dragData = new DataObject("myFormat1", tt);
                        DragDrop.DoDragDrop(dgr, dragData, DragDropEffects.Move);
                    }
                    catch (Exception ee)
                    {
                        
                    }
                }
            }
        }

        private void Remove_DragEnter(object sender, DragEventArgs e)
        {
            if (lw != null)
            {
                if (!e.Data.GetDataPresent("myFormat1") || sender == e.Source)
                {
                    e.Effects = DragDropEffects.None;
                }
            }
        }

        private void Remove_Drop(object sender, DragEventArgs e)
        {
            if (lw != null)
            {
                if (e.Data.GetDataPresent("myFormat1"))
                {
                    Tag tag = e.Data.GetData("myFormat1") as Tag;
                    MyTags.Remove(tag);
                    myAllTags.Remove(tag);
                    notSaved = true;
                }
            }
        }

        private void Go_OnClick(object sender, TextChangedEventArgs e)
        {
            bool flag = false;

            string input = Search.Text.Trim();
            if (ExistTags != null)
            {
                for (int i = ExistTags.Count - 1; i >= 0; i--)
                    ExistTags.RemoveAt(i);

                if (input.Equals("") || input.Equals("Search for tag"))
                {
                    flag = true;
                    foreach (var l in existAllTags)
                    {
                        ExistTags.Add(l);
                    }
                }

                if (flag == false)
                {
                    foreach (var l in existAllTags)
                    {
                        if (l.Similar(input))
                        {
                            ExistTags.Add(l);
                        }
                    }
                }

            }

            flag = false;
            if (MyTags != null)
            {
                for(int i=MyTags.Count-1; i>=0; i--)
                    MyTags.RemoveAt(i);

                if (input.Equals("") || input.Equals("Search for tag"))
                {
                    flag = true;
                    foreach (var l in myAllTags)
                    {
                        MyTags.Add(l);
                    }
                }

                if (flag == false)
                {
                    foreach (var l in myAllTags)
                    {
                        if (l.Similar(input))
                        {
                            MyTags.Add(l);
                        }
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!doNotShow)
            {

                MessageBoxResult mbr1 = MessageBox.Show("Are you sure you want to exit choosing tags?", "Exit Tags", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr1 == MessageBoxResult.Yes)
                {
                    if (tw != null)
                        tw.Close();

                    if (notSaved)
                    {
                        MessageBoxResult mbr =
                            MessageBox.Show("Do you want to save all created changes before exiting?",
                                "Save Tags", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (mbr == MessageBoxResult.Yes)
                        {
                            if (lw != null)
                            {
                                string v = "";
                                foreach (var t in MyTags)
                                {
                                    v += t.TagView + " ";
                                }

                                lw.Tags_Field.Text = v;

                                lw.tags = new ObservableCollection<Tag>();
                                foreach (var t in MyTags)
                                {
                                    lw.tags.Add(t);
                                }

                            }

                            map.setTags(existAllTags);
                            map.setLandmarks(new ObservableCollection<Landmark>(tempLandmarks));
                            MapWindow.notSaved = true;
                        }
                    }
                }
                else if(mbr1 == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            lw.ltw1 = null;
        }

    }
}
