using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HCI_Project
{
    [Serializable]
    public class LandmarkType: INotifyPropertyChanged
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

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!name.Equals(value))
                {
                    name = value;
                    OnPropertyChanged("Name");
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

        private string iconPath;
        public string IconPath
        {
            get
            {
                return iconPath;
            }
            set
            {
                if (!iconPath.Equals(value))
                {
                    iconPath = value;
                    OnPropertyChanged("IconPath");
                }
            }
        }

        private string typeView;
        public string TypeView
        {
            get
            {
                return typeView;
            }
            set
            {
                if (!typeView.Equals(value))
                {
                    typeView = value;
                    OnPropertyChanged("TypeView");
                }
            }
        }


        public LandmarkType(string i, string n, string p, string d)
        {
            id = i;
            name = n;
            iconPath = p;
            description = d;
            typeView = "$"+id+"_"+name;
        }

        public bool Equals(LandmarkType lt)
        {
            return id.Equals(lt.id) && name.Equals(lt.name) &&
                description.Equals(lt.description) && iconPath.Equals(lt.iconPath);
        }

        public bool Similar(string s)
        {
            return id.ToLower().Contains(s.ToLower()) ||
                   name.ToLower().Contains(s.ToLower()) ||
                   description.ToLower().Contains(s.ToLower()) || 
                   iconPath.ToLower().Contains(s.ToLower());
        }
    }
}
