using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HCI_Project
{
    [Serializable]
    public class Map
    {
        [NonSerialized] public MapWindow mw;
        public List<Landmark> PlacedLandmarks;

        private Dictionary<String, Landmark> landmarks
        {
            get;
            set;
        }

        private Dictionary<String, LandmarkType> landmarkTypes
        {
            get;
            set;
        }

        private Dictionary<String, Tag> tags
        {
            get;
            set;
        }

        public Map()
        {
            landmarks = new Dictionary<string, Landmark>();
            landmarkTypes = new Dictionary<string, LandmarkType>();
            tags = new Dictionary<string, Tag>();
            PlacedLandmarks = new List<Landmark>();
            mw = null;
        }

        public bool addLandmark(Landmark l)
        {
            if (landmarks.ContainsKey(l.ID))
                return false;

           landmarks.Add(l.ID, l);

            return true;
        }

        public bool addLandmarkType(LandmarkType lt)
        {
            if (landmarkTypes.ContainsKey(lt.ID))
                return false;

            landmarkTypes.Add(lt.ID, lt);

            return true;
        }

        public bool addTag(Tag t)
        {
            if (tags.ContainsKey(t.ID))
                return false;

            tags.Add(t.ID, t);

            return true;
        }

        public ObservableCollection<Landmark> getLandmarks()
        {
            ObservableCollection<Landmark> collection = new ObservableCollection<Landmark>();
            foreach (KeyValuePair<String, Landmark> l in landmarks)
            {
                collection.Add(l.Value);
            }

            return collection;
        }

        public void setLandmarks(ObservableCollection<Landmark> ls)
        {
            landmarks = new Dictionary<string, Landmark>();
            foreach (var l in ls)
            {
                landmarks.Add(l.ID, l);
            }
        }

        public ObservableCollection<LandmarkType> getLandmarkTypes()
        {
            ObservableCollection<LandmarkType> collection = new ObservableCollection<LandmarkType>();
            foreach(KeyValuePair<String, LandmarkType> lt in landmarkTypes)
            {
                collection.Add(lt.Value);
            }

            return collection;

        }

        public void setLandmarkTypes(ObservableCollection<LandmarkType> ltypes)
        {
            landmarkTypes = new Dictionary<string, LandmarkType>();
            foreach (var lt in ltypes)
            {
                landmarkTypes.Add(lt.ID, lt);
            }
        }

        public ObservableCollection<Tag> getTags()
        {
            ObservableCollection<Tag> collection = new ObservableCollection<Tag>();
            foreach (KeyValuePair<String, Tag> t in tags)
            {
                collection.Add(t.Value);
            }

            return collection;
        }

        public void setTags(ObservableCollection<Tag> taggs)
        {
            tags = new Dictionary<string, Tag>();
            foreach (var t in taggs)
            {
                tags.Add(t.ID, t);
            }
        }

        public Tag getTag(string id)
        {
            if(tags.ContainsKey(id))
                return tags[id];

            return null;
        }

        public Landmark GetLandmark(string id)
        {
            if (landmarks.ContainsKey(id))
                return landmarks[id];

            return null;
        }

        public int FindTag(Tag t)
        {
            int count = 0;
            foreach (Landmark l in landmarks.Values)
            {
                if (l.Tags.Contains(t))
                {
                    count++;
                }
            }

            return count;
        }

        public List<Landmark> RemoveTag(Tag t, List<Landmark> ll)
        {
            foreach (Landmark l in ll)
            {
                while (l.Tags.Contains(t))
                {
                    l.Tags.Remove(t);
                }
            }

            return ll;
        }

        public int FindLandmarkTypes(LandmarkType lt, List<Landmark> lmarks)
        {
            int count = 0;
            foreach (Landmark l in lmarks)
            {
                if (l.Type.Equals(lt))
                {
                    count++;
                }
            }

            return count;
        }

        public List<Landmark> RemoveLandmarkType(LandmarkType lt, List<Landmark> lmarks)
        {
            foreach (Landmark l in lmarks)
            {
                if (l.Type.Equals(lt))
                {
                    if (l.imagePath.Equals(l.Type.IconPath))
                    {
                        l.imagePath = "/HCI_Project;component/Images/missing_pic.jpg";
                    }

                    l.TypeView = "";
                    l.Type = null;
                }
            }

            return lmarks;
        }

        /*public void addLandmarkView(LandmarkView lw, List<Landmark> tempLs)
        {
            //Ako je neki od landmarkova u placed landmarks jednak sa lw
            //tj ako vec imamo postavljen landmark lw premesti ga
            foreach (var l in tempLs)
            {
                if (l.ID.Equals(lw.LandmarkId))
                {
                    l.position = lw.Position;
                    return;
                }
            }

            //landmarks[lw.LandmarkId].position = lw.Position;
        }*/

        //metoda koja zamenjuje placed landmarks sa templandmarks -> za save
        public void copyLandmarks(List<Landmark> copies)
        {
            PlacedLandmarks = new List<Landmark>();

            foreach (Landmark ll in copies)
            {
                PlacedLandmarks.Add(ll);
            }
        }

        //metoda koja postavlja landmarkove na mapu
        public void setPlacedLandmarks()
        {
            for (int i = mw.Goal.Children.Count - 1; i >= 0; i--)
            {
                LandmarkView lw = mw.Goal.Children[i] as LandmarkView;
                
                if(lw!=null)
                    mw.Goal.Children.RemoveAt(i);
            }


            for (int i = mw.Goal.Children.Count - 1; i >= 0; i--)
            {
                Rectangle r = mw.Goal.Children[i] as Rectangle;
                if (r != null)
                    mw.Goal.Children.RemoveAt(i);
            }

            foreach (var l in PlacedLandmarks)
            {
                LandmarkView lw = new LandmarkView(l.ID, l.position, l.imagePath);
                lw.Background = Brushes.White;
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
                    lw.Width = 54;
                    lw.Height = 54;

                    lw.MouseLeftButtonUp += doRightClick;
                    lw.MouseLeftButtonDown += mw.startDrag;
                    r.MouseLeftButtonUp += doRightClick;
                    r.MouseLeftButtonDown += mw.startDrag;
                    mw.Goal.Children.Add(lw);
                    mw.Goal.Children.Add(r);

                    Canvas.SetLeft(lw, lw.Position.X - 2 /*+ (tbt.Width/2)*/);
                    Canvas.SetTop(lw, lw.Position.Y - 2 /*+ (tbt.Height/2)*/);
                    Canvas.SetLeft(r, lw.Position.X);
                    Canvas.SetTop(r, lw.Position.Y);
                }
            }

            MapWindow.notSaved = false;
        }

        public void doRightClick(object sender, MouseButtonEventArgs e)
        {
            foreach (var q in mw.Goal.Children)
            {
                LandmarkView qq = q as LandmarkView;
                if (qq != null)
                {
                    if (qq.LandmarkId.Equals(mw.SelectedLandmark))
                    {
                        mw.SelectedLandmark = null;
                        qq.Background = Brushes.White;
                    }
                }
                else
                {
                    Rectangle rr = q as Rectangle;
                    if (rr != null)
                    {
                        if (rr.Stroke == Brushes.Red)
                        {
                            rr.Stroke = Brushes.Black;
                        }
                    }
                }
            }


            LandmarkView lw = sender as LandmarkView;
            if (lw != null)         //selektovan je landmarkview
            {
                lw.Background = Brushes.Green;
                mw.SelectedLandmark = lw.LandmarkId;
                foreach (var v in mw.Goal.Children)
                {
                    Rectangle w = v as Rectangle;
                    if (w != null)
                    {
                        double x = Canvas.GetLeft(w);
                        double y = Canvas.GetTop(w);
                        if (lw.Position.X == x  && lw.Position.Y == y)
                        {
                            w.Stroke = Brushes.Red;
                            break;
                        }
                    }
                }
            }               //selektovan je rectangle
            else
            {
                Rectangle w =  sender as Rectangle;
                w.Stroke = Brushes.Red;
                foreach (var v in mw.Goal.Children)
                {
                    LandmarkView vv = v as LandmarkView;
                    if (vv != null)
                    {
                        double x = Canvas.GetLeft(w);
                        double y = Canvas.GetTop(w);
                        if (vv.Position.X==x && vv.Position.Y==y)
                        {
                            vv.Background = Brushes.Green;
                            mw.SelectedLandmark = vv.LandmarkId;
                            break;
                        }
                    }
                }
            }
        }
    }
}
