using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HCI_Project
{
    public class CustomTagCommands
    {
        //tagWindow             /++++
        public static RoutedCommand OkTag = new RoutedCommand();            //enter
        public static RoutedCommand CancelTag = new RoutedCommand();        //escape
        public static RoutedCommand ExitTag = new RoutedCommand();          //altf4
    }

    public class CustomTagsCommands
    {
        //listTagsWindow        /++++
        public static RoutedCommand NewTag1 = new RoutedCommand();          //ctrlN
        public static RoutedCommand DeleteTag1 = new RoutedCommand();       //delete
        public static RoutedCommand AddTag = new RoutedCommand();           //ctrlA
        public static RoutedCommand RemoveTag = new RoutedCommand();        //ctrlD
        public static RoutedCommand EditTag = new RoutedCommand();          //ctrlE
        public static RoutedCommand OkTags = new RoutedCommand();           //enter
        public static RoutedCommand CancelTags = new RoutedCommand();       //escape
        public static RoutedCommand ExitTags = new RoutedCommand();         //altf4
    }
}
