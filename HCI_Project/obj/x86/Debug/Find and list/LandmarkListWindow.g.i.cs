﻿#pragma checksum "..\..\..\..\Find and list\LandmarkListWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D57071FD98B0D6B4DAA011FB1A626F35"
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
    /// LandmarkListWindow
    /// </summary>
    public partial class LandmarkListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Smthing;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgrLandmarks;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI_Project;component/find%20and%20list/landmarklistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
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
            
            #line 5 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((HCI_Project.LandmarkListWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 5 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((HCI_Project.LandmarkListWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditLandmarkCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 22 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteLandmarkCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OkLandmarksCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 24 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CancelLandmarksCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 25 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExitLandmarksCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Smthing = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Go_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 69 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Manage_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dgrLandmarks = ((System.Windows.Controls.DataGrid)(target));
            
            #line 71 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.dgrLandmarks.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Double_OnClick);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.dgrLandmarks.MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.dgrLandmarks.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.OK = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.OK.Click += new System.Windows.RoutedEventHandler(this.OK_OnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_OnClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\..\Find and list\LandmarkListWindow.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

