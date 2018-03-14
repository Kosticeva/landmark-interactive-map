using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HCI_Project
{
    public class CustomLandmarkCommands
    {
        //landmarkWindow        /++++
        public static RoutedCommand ManageTypes = new RoutedCommand();      //ctrlY
        public static RoutedCommand ManageTags = new RoutedCommand();       //ctrlT
        public static RoutedCommand OkLandmark = new RoutedCommand();       //enter
        public static RoutedCommand CancelLandmark = new RoutedCommand();   //escape
        public static RoutedCommand ExitLandmark = new RoutedCommand();     //altF4
    }
}
