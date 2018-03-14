using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HCI_Project
{
    public class CustomListCommands
    {
        //listLandmarksWindow   /++++
        public static RoutedCommand EditLandmark = new RoutedCommand();     //ctrlE
        public static RoutedCommand DeleteLandmark = new RoutedCommand();   //delete
        public static RoutedCommand OkLandmarks = new RoutedCommand();      //enter
        public static RoutedCommand CancelLandmarks = new RoutedCommand();  //escape
        public static RoutedCommand ExitLandmarks = new RoutedCommand();    //altf4
    }
}
