﻿#pragma checksum "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CCC928CBD087423FB807E34412F429D4923E3C11"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CMSUI.Converters;
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
    /// MyCoursesDashboardUserControl
    /// </summary>
    public partial class MyCoursesDashboardUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 43 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox departmentsCombobox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox activeTermsCombobox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox myCoursesList;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid examsGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/CMSUI;component/usercontrols/mycoursesdashboardusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
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
            
            #line 11 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            ((CMSUI.UserControls.MyCoursesDashboardUserControl)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.departmentsCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            this.departmentsCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DepartmentsCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.activeTermsCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 61 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            this.activeTermsCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ActiveTermsCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.myCoursesList = ((System.Windows.Controls.ListBox)(target));
            
            #line 79 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            this.myCoursesList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MyCoursesList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.examsGrid = ((System.Windows.Controls.DataGrid)(target));
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
            
            #line 91 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddExamBtn_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 160 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateExcelFileBtn_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 171 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.FileLink_Click);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 189 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateExamBtn_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 206 "..\..\..\UserControls\MyCoursesDashboardUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteExamBtn_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

