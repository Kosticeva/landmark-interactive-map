using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ContextMenu = System.Windows.Controls.ContextMenu;
using DataObject = System.Windows.DataObject;
using DragDropEffects = System.Windows.DragDropEffects;
using DragEventArgs = System.Windows.DragEventArgs;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using KeyEventHandler = System.Windows.Input.KeyEventHandler;
using MessageBox = System.Windows.MessageBox;
using Orientation = System.Windows.Controls.Orientation;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        public LandmarkView clipboard;
        private User currentUser;
        public Map map;
        public static bool notSaved;
        public string SelectedLandmark;
        public bool doNotShow = false;
        public List<Landmark> tempLandmarks = new List<Landmark>();
        public bool unlocked = false;

        public LandmarkWindow lw = null;
        public ListTypesWindow ltw = null;
        public ListTagsWindow ltw1 = null;
        public LandmarkListWindow llw = null;
        public DefaultMap dm = null;

        public MapWindow(User u)
        {
            InitializeComponent();
            currentUser = u;
            map = u.getUserMap();
            map.mw = this;
            if (map.PlacedLandmarks.Count > 0)
            {
                foreach (Landmark l in map.PlacedLandmarks)
                {
                    Landmark ll = new Landmark(l.ID, l.Name, l.Description, l.Type, l.Tags,
                        l.Climate, l.TStatus, l.Revenue, l.DoD, l.imagePath, l.EE, l.HAB, l.URB, l.position);
                    LandmarkView sp = new LandmarkView(l.ID, l.position, l.imagePath);
                    sp.Background = Brushes.White;
                    Rectangle r = new Rectangle();
                    r.Width = 50;
                    r.Height = 50;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;
                    ImageBrush ib = new ImageBrush();
                    try
                    {
                        ib.ImageSource = new BitmapImage(new Uri(l.imagePath, UriKind.RelativeOrAbsolute));
                    }
                    catch (Exception e)
                    {
                        ib.ImageSource = new BitmapImage(new Uri(@"./../../Images/missing_pic.jpg", UriKind.Relative));
                    }
                    finally
                    {
                        r.Fill = ib;
                        sp.Width = 54;
                        sp.Height = 54;
                        sp.MouseLeftButtonUp += map.doRightClick;
                        sp.MouseLeftButtonDown += startDrag;
                        r.MouseLeftButtonUp += map.doRightClick;
                        r.MouseLeftButtonDown += startDrag;
                        Goal.Children.Add(sp);
                        Goal.Children.Add(r);
                        tempLandmarks.Add(l);
                        Canvas.SetLeft(sp, l.position.X - 2 /*+ (tbt.Width/2)*/);
                        Canvas.SetTop(sp, l.position.Y - 2 /*+ (tbt.Height/2)*/);
                        Canvas.SetLeft(r, sp.Position.X);
                        Canvas.SetTop(r, sp.Position.Y);
                    }
                }
            }

            notSaved = false;
        }

        private void NewLandmark_OnClick(object sender, RoutedEventArgs e)
        {
            if (lw == null)
            {
                lw = new LandmarkWindow(map);
                lw.Show();
            }
            else
            {
                lw.Topmost = true;  // important
                lw.Topmost = false; // important
                lw.Focus();         // important
            }
        }

        private void NewLandmarkType_OnClick(object sender, RoutedEventArgs e)
        {
            if(ltw==null){
                ltw = new ListTypesWindow(map);
                ltw.Show();
            }
            else
            {
                ltw.Topmost = true;  // important
                ltw.Topmost = false; // important
                ltw.Focus();         // important
            }
        }

        private void NewTag_OnClick(object sender, RoutedEventArgs e)
        {
            if(ltw1==null){
                ltw1= new ListTagsWindow(map);
                ltw1.Show();
            }
            else
            {
                ltw1.Topmost = true;  // important
                ltw1.Topmost = false; // important
                ltw1.Focus();         // important
            }
        }

        private void LandmarkList_OnClick(object sender, RoutedEventArgs e)
        {
            if (llw == null)
            {
                llw = new LandmarkListWindow(this, currentUser.getUserMap());
                llw.Show(); 
            }
            else
            {
                llw.Topmost = true;  // important
                llw.Topmost = false; // important
                llw.Focus();         // important
            }
            
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
           saveAll();
        }

        private void saveAll()
        {
            int incomplete = 0;
            foreach (Landmark l in map.getLandmarks())
            {
                if (l.Type == null)
                {
                    incomplete++;
                }
            }

            if (incomplete>0)
            {
                MessageBox.Show(
                    "You have some landmarks which do not have valid landmark type. \nPlease check your landmarks again.",
                    "Landmark type error", MessageBoxButton.OK, MessageBoxImage.Error);
                if(llw==null)
                    llw = new LandmarkListWindow(this, map);
                llw.Show();
            }
            else
            {
                currentUser.setUserMap(map);
                LoginModel.updateUser(currentUser);
                UserFileManipulation.saveUsers(LoginModel.Users);
                notSaved = false;
                MessageBox.Show("All data saved.",
                    "Save", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            if (ltw1 != null)
                ltw1.Close();

            if (ltw != null)
                ltw.Close();

            if (lw != null)
                lw.Close();

            if (llw != null)
                llw.Close();

            MessageBoxResult mbr1 = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mbr1 == MessageBoxResult.Yes)
            {
                if (notSaved)
                {
                    MessageBoxResult mbr = MessageBox.Show("You have not saved your data. \nDo you want to save first?", "Save", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                    if (mbr == MessageBoxResult.Yes)
                    {
                        saveAll();
                    }
                }

                doNotShow = true;
                this.Close();
            }
        }

        private void NewLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewLandmark_OnClick(null,null);
        }

        private void NewLandmarkTypeCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewLandmarkType_OnClick(null,null);
        }

        private void NewTagCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NewTag_OnClick(null,null);
        }

        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Save_OnClick(this, null);
        }

        private void ExitCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Exit_OnClick(this, null);
        }

        private void ListLandmarksCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            LandmarkList_OnClick(null,null);
        }

        private void DeleteLandmarkCommandBindind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            for (int i = Goal.Children.Count - 1; i >= 0; i--)
            {
                Rectangle rr = Goal.Children[i] as Rectangle;
                if (rr != null)
                {
                    if (rr.Stroke == Brushes.Red)
                    {
                        Goal.Children.Remove(rr);
                        break;
                    }
                }
            }

            for (int i = Goal.Children.Count - 1; i >= 0; i--)
            {
                LandmarkView rr = Goal.Children[i] as LandmarkView;
                if (rr != null)
                {
                    if (rr.LandmarkId.Equals(SelectedLandmark))
                    {
                        Goal.Children.Remove(rr);
                        map.PlacedLandmarks.Remove(map.GetLandmark(SelectedLandmark));
                        SelectedLandmark = null;
                        break;
                    }
                }
            }
        }

        private void CutLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //cut prvo brise iz postavljenih, zatim kopira kopiju sa canvasa i brise je sa canvasa, zaj sa rect
            if (SelectedLandmark != null)
            {
                //brise iz postavlj
                foreach (var v in map.PlacedLandmarks)
                {
                    if (SelectedLandmark.Equals(v.ID))
                    {
                        map.PlacedLandmarks.Remove(v);
                        break;
                    }
                }

                //kopira sa canvasa i brise view
                for (int i = Goal.Children.Count - 1; i >= 0; i--)
                {
                    LandmarkView lv = Goal.Children[i] as LandmarkView;
                    if (lv != null)
                    {
                        if (lv.LandmarkId.Equals(SelectedLandmark))
                        {
                            clipboard = lv;
                            Goal.Children.RemoveAt(i);
                            break;
                        }
                    }
                }

                //brise i rect
                for (int i = Goal.Children.Count - 1; i >= 0; i--)
                {
                    Rectangle r = Goal.Children[i] as Rectangle;
                    if (r != null)
                    {
                        double x = Canvas.GetLeft(r);
                        double y = Canvas.GetTop(r);
                        if (x == clipboard.Position.X && y == clipboard.Position.Y)
                        {
                            Goal.Children.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        private void CopyLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //copy prvo mora da pronadje land na mapi i zatim ga sacuva u clipboard
            if (SelectedLandmark != null)
            {
                for (int i = Goal.Children.Count - 1; i >= 0; i--)
                {
                    LandmarkView lw = Goal.Children[i] as LandmarkView;
                    if (lw != null)
                    {
                        if (lw.LandmarkId.Equals(SelectedLandmark))
                        {
                            clipboard = lw;
                            //Goal.Children.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }


        Point cursPos = new Point(-100,-100);
        private void PasteLandmarkCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //paste mora prvo da obrise postavljen landmark
            //zatim da postavi novi na novu poziciju
            //zajedno sa rectangle
            if (clipboard != null)
            {
                //brise postojeci iz spiska
                foreach (var v in map.PlacedLandmarks)
                {
                    if (clipboard.LandmarkId.Equals(v.ID))
                    {
                        map.PlacedLandmarks.Remove(v);
                        break;
                    }
                }

                //brise sa mape lw
                for (int i = Goal.Children.Count - 1; i >= 0; i--)
                {
                    LandmarkView lv = Goal.Children[i] as LandmarkView;
                    if (lv != null)
                    {
                        if (lv.LandmarkId.Equals(clipboard.LandmarkId))
                        {
                            Goal.Children.RemoveAt(i);
                            break;
                        }
                    }
                }

                //brise sa mape rect
                for (int i = Goal.Children.Count - 1; i >= 0; i--)
                {
                    Rectangle rr = Goal.Children[i] as Rectangle;
                    if (rr != null)
                    {
                        double x = Canvas.GetLeft(rr);
                        double y = Canvas.GetTop(rr);
                        if (x == clipboard.Position.X && y == clipboard.Position.Y)
                        {
                            Goal.Children.RemoveAt(i);
                            break;
                        }
                    }
                }

                //Dodaje kopiju
                Rectangle r = new Rectangle();
                r.Width = 50;
                r.Height = 50;
                r.Stroke = Brushes.Black;
                r.StrokeThickness = 1;
                ImageBrush ib = new ImageBrush();
                try
                {
                    ib.ImageSource = new BitmapImage(new Uri(clipboard.ImagePath, UriKind.RelativeOrAbsolute));
                }
                catch (Exception ee)
                {
                    ib.ImageSource = new BitmapImage(new Uri(@"./../../Images/missing_pic.jpg", UriKind.Relative));
                }
                finally
                {
                    r.Fill = ib;
                    clipboard.Position = cursPos;
                    clipboard.Background = Brushes.White;
                    Goal.Children.Add(clipboard);
                    Goal.Children.Add(r);
                    clipboard.MouseLeftButtonUp += map.doRightClick;
                    clipboard.MouseLeftButtonDown += startDrag;
                    r.MouseLeftButtonUp += map.doRightClick;
                    r.MouseLeftButtonDown += startDrag;
                    Canvas.SetLeft(clipboard, cursPos.X - 2 /*+ (tbt.Width/2)*/);
                    Canvas.SetTop(clipboard, cursPos.Y - 2 /*+ (tbt.Height/2)*/);
                    Canvas.SetLeft(r, cursPos.X);
                    Canvas.SetTop(r, cursPos.Y);
                    SelectedLandmark = null;
                }
            }
        }

        private void CheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            Target.Visibility = Visibility.Visible;
        }

        private void UnCheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            Target.Visibility = Visibility.Hidden;
        }

        private void CheckBoxV_OnClick(object sender, RoutedEventArgs e)
        {
            Target.Orientation = Orientation.Vertical;
            Target.Height = 400;
            Target.Width = 50;
            Barr.Width = 50;
            Barr.Height = 200;
            Barr1.Width = 50;
            Barr1.Height = 200;
        }

        private void UnCheckBoxV_OnClick(object sender, RoutedEventArgs e)
        {
            Target.Orientation = Orientation.Horizontal;
            Target.Height = 50;
            Target.Width = 400;
            Barr.Width = 200;
            Barr.Height = 50;
            Barr1.Width = 200;
            Barr1.Height = 50;
        }

        private void CheckBoxH_OnClick(object sender, RoutedEventArgs e)
        {
            Target.Orientation = Orientation.Horizontal;
            Target.Height = 50;
            Target.Width = 400;
            Barr.Width = 200;
            Barr.Height = 50;
            Barr1.Width = 200;
            Barr1.Height = 50;

        }

        private void UnCheckBoxH_OnClick(object sender, RoutedEventArgs e)
        {
            Target.Orientation = Orientation.Vertical;
            Target.Height = 400;
            Target.Width = 50;
            Barr.Width = 50;
            Barr.Height = 200;
            Barr1.Width = 50;
            Barr1.Height = 200;
        }

        private void Target_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(unlocked)
            {
                DataObject capsule = new DataObject("toolBarTray", Target);
                ToolBarTray tbt = Target;
                DragDrop.DoDragDrop(tbt, capsule, DragDropEffects.Move);
            }
        }

        private void Goal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Move;
        }

        private void Goal_Drop(object sender, DragEventArgs e)
        {
            ToolBarTray tbt = e.Data.GetData("toolBarTray") as ToolBarTray;
            Point blockPos = e.GetPosition(Goal);
            if (tbt == null)
            {
                Landmark l = e.Data.GetData("landmark") as Landmark;
                l.position = blockPos;
                LandmarkView sp = new LandmarkView(l.ID, blockPos, l.imagePath);
                sp.Background = Brushes.White;
                Rectangle r = new Rectangle();
                r.Width = 50;
                r.Height = 50;
                r.Stroke = Brushes.Black;
                r.StrokeThickness = 1;
                ImageBrush ib = new ImageBrush();

                try
                {
                    ib.ImageSource = new BitmapImage(new Uri(l.imagePath, UriKind.RelativeOrAbsolute));
                }
                catch (Exception ee)
                {
                    ib.ImageSource = new BitmapImage(new Uri(@"./../../Images/missing_pic.jpg", UriKind.Relative));

                }
                finally
                {
                    r.Fill = ib;
                    sp.Width = 54;
                    sp.Height = 54;
                    Point foundPos = new Point(-100, -100);

                    foreach (var v in Goal.Children)
                    {
                        var w = v as LandmarkView;
                        if (w != null)
                        {
                            if (w.LandmarkId.Equals(sp.LandmarkId))
                            {
                                Goal.Children.Remove(w);
                                foundPos = new Point(w.Position.X, w.Position.Y);
                                break;
                            }
                        }
                    }

                    if (foundPos != null)
                    {
                        foreach (var v in Goal.Children)
                        {
                            var w = v as Rectangle;
                            if (w != null)
                            {
                                double x = Canvas.GetLeft(w);
                                double y = Canvas.GetTop(w);
                                if (x == foundPos.X && y == foundPos.Y)
                                {
                                    Goal.Children.Remove(w);
                                    break;
                                }
                            }
                        }
                    }

                    if (mapDragAddHandlers)
                    {
                        sp.MouseLeftButtonUp += map.doRightClick;
                        sp.MouseLeftButtonDown += startDrag;
                        r.MouseLeftButtonUp += map.doRightClick;
                        r.MouseLeftButtonDown += startDrag;
                    }

                    Goal.Children.Add(sp);
                    Goal.Children.Add(r);
                    Canvas.SetLeft(sp, blockPos.X - 2 /*+ (tbt.Width/2)*/);
                    Canvas.SetTop(sp, blockPos.Y - 2 /*+ (tbt.Height/2)*/);
                    Canvas.SetLeft(r, blockPos.X);
                    Canvas.SetTop(r, blockPos.Y);

                    /* map.addLandmarkView(sp/*, tempLandmarks);*/

                    if (!mapDragAddHandlers)
                    {
                        foreach (var v in tempLandmarks)
                        {
                            //landmark je postavljen
                            if (l.ID.Equals(v.ID))
                            {
                                tempLandmarks.Remove(v);
                                break;
                            }
                        }

                        tempLandmarks.Add(l);
                        LandmarkListWindow.notSaved = true;
                    }
                    else
                    {
                        foreach (var v in map.PlacedLandmarks)
                        {
                            //landmark je postavljen
                            if (l.ID.Equals(v.ID))
                            {
                                map.PlacedLandmarks.Remove(v);
                                break;
                            }
                        }

                        SelectedLandmark = null;
                        mapDragAddHandlers = false;
                        map.PlacedLandmarks.Add(l);
                        notSaved = true;
                    }

                }
                return;
            }

            Canvas.SetLeft(tbt, blockPos.X /*+ (tbt.Width/2)*/);
            Canvas.SetTop(tbt, blockPos.Y /*+ (tbt.Height/2)*/);
            unlocked = false;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!doNotShow)
            {
                if (ltw1 != null)
                    ltw1.Close();

                if (ltw != null)
                    ltw.Close();

                if (lw != null)
                    lw.Close();

                if (llw != null)
                    llw.Close();

                MessageBoxResult mbr1 = MessageBox.Show("Are you sure you want to exit?", "Exit",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mbr1 == MessageBoxResult.Yes)
                {
                    if (notSaved)
                    {
                        MessageBoxResult mbr =
                            MessageBox.Show("You have not saved your data. \nDo you want to save first?",
                                "Save", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                        if (mbr == MessageBoxResult.Yes)
                        {
                            saveAll();
                        }
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void DockPanel_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(dm==null)
                dm = new DefaultMap(this);
            dm.Show();
        }

        public void removeRectangle(Point p)
        {
            foreach (var v in Goal.Children)
            {
                var w = v as Rectangle;
                if (w != null)
                {
                    double x = Canvas.GetLeft(w);
                    double y = Canvas.GetTop(w);
                    if (x == p.X && y == p.Y)
                    {
                        Goal.Children.Remove(w);
                        break;
                    }
                }
            }
        }

        private void Target_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            unlocked = true;
        }

        private void SelectPastePlace(object sender, System.Windows.Input.MouseEventArgs e)
        {
            cursPos = e.GetPosition(Goal);
        }

        private bool mapDragAddHandlers = false;
        public void startDrag(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (SelectedLandmark != null)
            {
                //DataObj mi je Landmark, 
                //Prvi arg je landmarkView
                //treba da nadjem odg landmarkview, enkapsuliram ga
                //i to je to.
                //nalazim odg lview

                DataObject capsule = new DataObject("landmark", map.GetLandmark(SelectedLandmark));
                LandmarkView lw = null;
                foreach (var v in Goal.Children)
                {
                    lw = v as LandmarkView;
                    if (lw != null)
                    {
                        if (lw.LandmarkId.Equals(SelectedLandmark))
                            break;
                    }
                }

                mapDragAddHandlers = true;
                DragDrop.DoDragDrop(lw, capsule, DragDropEffects.Move);
            }
        }
    }
}