﻿#pragma checksum "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B19EAFF6CAF18821AA8164113ECDB428"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI_Project;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace HCI_Project {
    
    
    /// <summary>
    /// LandmarkTypeWindow
    /// </summary>
    public partial class LandmarkTypeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ID;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Color;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Iconn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LTID_Field;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LTName_Field;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LTDescription_Field;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Choose_Icon;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Img;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MainTitle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HCI_Project;component/landmark%20type/landmarktypewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((HCI_Project.LandmarkTypeWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((HCI_Project.LandmarkTypeWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 10 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OkTypeCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 11 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CancelTypeCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 12 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExitTypeCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Color = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Iconn = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.LTID_Field = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.LTName_Field = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.LTDescription_Field = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.Choose_Icon = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            this.Choose_Icon.Click += new System.Windows.RoutedEventHandler(this.Browse_OnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Img = ((System.Windows.Controls.Image)(target));
            return;
            case 14:
            this.MainTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            
            #line 53 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 54 "..\..\..\..\Landmark Type\LandmarkTypeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
