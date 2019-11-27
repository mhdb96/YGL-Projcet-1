﻿#pragma checksum "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DCF5ED3C444FD6C44B60E022DC29208AA3813B12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CMSUI.UserControls;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.IconPacks;
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


namespace CMSUI.UserControls {
    
    
    /// <summary>
    /// CourseDashboardUserControl
    /// </summary>
    public partial class CourseDashboardUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateDataSourceBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCourseBtn;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox coursesList;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox courseOutcomesList;
        
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
            System.Uri resourceLocater = new System.Uri("/CMSUI;component/usercontrols/dashboards/coursedashboardusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
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
            this.searchText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.updateDataSourceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
            this.updateDataSourceBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateDataSourceBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addCourseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
            this.addCourseBtn.Click += new System.Windows.RoutedEventHandler(this.AddCourseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.coursesList = ((System.Windows.Controls.ListBox)(target));
            
            #line 80 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
            this.coursesList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CoursesList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.courseOutcomesList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 97 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateCourseBtn_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 107 "..\..\..\..\UserControls\Dashboards\CourseDashboardUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteCourseBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

