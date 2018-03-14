using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace HCI_Project
{
    [Serializable]
    public class Landmark: INotifyPropertyChanged
    {
        [field: NonSerialized] public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }

        private string _id;
        public string ID
        {
            get
            {
                return _id;
            }

            set
            {
                if (!_id.Equals(value))
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!_name.Equals(value))
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private string _desc;
        public string Description
        {
            get
            {
                return _desc;
            }

            set
            {
                if (!_desc.Equals(value))
                {
                    _desc = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        private LandmarkType _lt;
        public LandmarkType Type
        {
            get
            {
                return _lt;
            }

            set
            {
                if (_lt==null || (value==null) || !_lt.Equals(value))
                {
                    _lt = value;
                    OnPropertyChanged("Type");
                }
            }
        }

        private string _climate;
        public string Climate
        {
            get
            {
                return _climate;
            }

            set
            {
                if (!_climate.Equals(value))
                {
                    _climate = value;
                    OnPropertyChanged("Climate");
                }
            }
        }

        private string _status;
        public string TStatus
        {
            get
            {
                return _status;
            }

            set
            {
                if (!_status.Equals(value))
                {
                    _status = value;
                    OnPropertyChanged("TStatus");
                }
            }
        }

        private double _rev;
        public double Revenue
        {
            get
            {
                return _rev;
            }

            set
            {
                if (!_rev.Equals(value))
                {
                    _rev = value;
                    OnPropertyChanged("Revenue");
                }
            }
        }

        private string _dd;
        public string DoD
        {
            get
            {
                return _dd;
            }

            set
            {
                if (!_dd.Equals(value))
                {
                    _dd = value;
                    OnPropertyChanged("DoD");
                }
            }
        }

        private List<Tag> _tags;
        public List<Tag> Tags
        {
            get
            {
                return _tags;
            }

            set
            {
                if (_tags == null || !_tags.Equals(value))
                {
                    _tags = value;
                    OnPropertyChanged("Tags");
                }
            }
        }

        private bool _ee;
        public bool EE
        {
            get
            {
                return _ee;
            }

            set
            {
                if (!(_ee != value))
                {
                    _ee = value;
                    OnPropertyChanged("EE");
                }
            }
        }

        private bool _hab;
        public bool HAB
        {
            get
            {
                return _hab;
            }

            set
            {
                if (!(_hab != value))
                {
                    _hab = value;
                    OnPropertyChanged("HAB");
                }
            }
        }

        private bool _urb;
        public bool URB
        {
            get
            {
                return _urb;
            }

            set
            {
                if (!(_urb != value))
                {
                    _urb = value;
                    OnPropertyChanged("URB");
                }
            }
        }

        public string imagePath { get; set; }

        private string ltView;
        public string TypeView
        {
            get
            {
                return _lt.TypeView;
            }

            set
            {
                if (ltView==null || !ltView.Equals(value))
                {
                    ltView = value;
                    OnPropertyChanged("TypeView");
                }
            }
        }

        private string tagView;
        public string TagView
        {
            get
            {
                String ret = "";
                foreach (var t in _tags)
                {
                    ret += t.TagView + " ";
                }
                return ret;
            }

            set
            {
                if (!tagView.Equals(value))
                {
                    tagView = value;
                    OnPropertyChanged("TagView");
                }
            }
        }

        public Point position;


        public Landmark(string i, string n, string d, LandmarkType lt, List<Tag> tags, string c, string s, double r, string dd, string ip, bool e, bool h, bool u, Point p)
        {
            position.X = p.X;
            position.Y = p.Y;
            _name = n;
            _id = i;
            _desc = d;
            _lt = lt;
            _tags = new List<Tag>();
            foreach (Tag t in tags)
            {
                _tags.Add(t);
            }
            _climate = c;
            _status = s;
            _rev = r;
            _dd = dd;
            if (ip==null || ip.Equals("/HCI_Project;component/Images/missing_pic.jpg"))
            {
                imagePath = _lt.IconPath;
            }
            else
            {
                imagePath = ip;
            }
            _ee = e;
            _hab = h;
            _urb = u;
        }

        public bool Equals(Landmark l)
        {
            return _id.Equals(l.ID) && _name.Equals(l._name) && _desc.Equals(l._desc)
                && _climate.Equals(l._climate) && _dd.Equals(l._dd) && _ee.Equals(l._ee)
                && _hab.Equals(l._hab) && _lt.Equals(l._lt) && _rev == l._rev
                && _status.Equals(l._status) && _tags.Equals(l._tags)
                && _urb.Equals(l._urb);
        }

        public ObservableCollection<Tag> getTags()
        {
            ObservableCollection<Tag> coll = new ObservableCollection<Tag>();
            foreach (var tag in _tags)
            {
                coll.Add(tag);
            }

            return coll;
        }

        public bool Similar(string s)
        {
            return _id.ToLower().Contains(s.ToLower()) || _name.ToLower().Contains(s.ToLower()) 
                || _desc.ToLower().Contains(s.ToLower()) || _climate.ToLower().Contains(s.ToLower())
                || _status.ToLower().Contains(s.ToLower()) 
                || _rev.ToString().ToLower().Contains(s.ToLower()) 
                || _lt.TypeView.ToLower().Contains(s.ToLower())
                || TagView.ToLower().Contains(s.ToLower()) 
                || _dd.ToLower().Contains(s.ToLower());
        }

    }
}
