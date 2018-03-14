using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HCI_Project
{
    static class CustomCommands
    {
        //mapwindowFile
        public static RoutedCommand NewLandmark = new RoutedCommand();      //ctrlL
        public static RoutedCommand NewLandmarkType = new RoutedCommand();  //ctrlY
        public static RoutedCommand NewTag = new RoutedCommand();           //ctrlT
        public static RoutedCommand Save = new RoutedCommand();             //ctrlS
        public static RoutedCommand Exit = new RoutedCommand();             //altF4
        
        //mapWindowEdit
        public static RoutedCommand ListLandmarks = new RoutedCommand();    //ctrlF
        public static RoutedCommand Delete = new RoutedCommand();           //delete
        public static RoutedCommand Cut = new RoutedCommand();              //ctrlX
        public static RoutedCommand Copy = new RoutedCommand();             //ctrlC
        public static RoutedCommand Paste = new RoutedCommand();            //ctrlV
    }
}
