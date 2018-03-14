using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace HCI_Project
{
    public class LandmarkView: TextBlock
    {
        public string LandmarkId;
        public Point Position;
        public string ImagePath;

        public LandmarkView(string l, Point p, string IP)
        {
            LandmarkId = l;
            Position = p;
            ImagePath = IP;

        }
    }
}
