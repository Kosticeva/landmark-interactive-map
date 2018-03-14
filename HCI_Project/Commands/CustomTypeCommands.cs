using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace HCI_Project
{
    public class CustomTypeCommands
    {
        //landmarkTypeWindow    /++++
        public static RoutedCommand OkType = new RoutedCommand();           //enter
        public static RoutedCommand CancelType = new RoutedCommand();       //escape
        public static RoutedCommand ExitType = new RoutedCommand();         //altf4

    }

    public class CustomTypesCommands{

        //listTypesWindow       /++++
        public static RoutedCommand NewLandmarkType1 = new RoutedCommand(); //ctrlN
        public static RoutedCommand SelectLandmarkType = new RoutedCommand(); //ctrlA
        public static RoutedCommand DeleteLandmarkType = new RoutedCommand(); //delete
        public static RoutedCommand EditType = new RoutedCommand(); //ctrlE
        public static RoutedCommand OkTypes = new RoutedCommand(); //enter
        public static RoutedCommand CancelTypes = new RoutedCommand(); //escape
        public static RoutedCommand ExitTypes = new RoutedCommand(); //altf4
        
    }
}
