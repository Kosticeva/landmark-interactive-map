using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;

namespace HCI_Project
{
    [Serializable]
    public class Tag : INotifyPropertyChanged
    {
        [field: NonSerialized] public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }

        private string id;
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                if (!id.Equals(value))
                {
                    id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (!color.Equals(value))
                {
                    color = value;
                    OnPropertyChanged("Color");
                }
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!description.Equals(value))
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        private string tagView;
        public string TagView
        {
            get
            {
                return "#" + id ;
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

        public Tag(string i, string c, string d)
        {
            this.id = i;
            this.color = c;
            this.description = d;
        }

        public bool Equals(Tag t)
        {
            return t.id.Equals(id) && t.color.Equals(color) && t.description.Equals(description);
        }

        public bool Similar(string s)
        {
            return id.ToLower().Contains(s.ToLower())
                   || description.ToLower().Contains(s.ToLower())
                   || color.ToLower().Contains(s.ToLower());
        }
    }
}
