﻿#pragma checksum "..\..\..\Pages\DefectiveCoilsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "350F9184DF545D520B1DF1E4B6A32339635AF654553AD59BC2B520A347D14E4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StockroomBinar.Pages;
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


namespace StockroomBinar.Pages {
    
    
    /// <summary>
    /// DefectiveCoilsPage
    /// </summary>
    public partial class DefectiveCoilsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\Pages\DefectiveCoilsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchColor;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\DefectiveCoilsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlastType;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\DefectiveCoilsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlastManufact;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\DefectiveCoilsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PlastitDefectiveView;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\DefectiveCoilsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RecyclingNameDel;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\DefectiveCoilsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MyFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/StockroomBinar;component/pages/defectivecoilspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DefectiveCoilsPage.xaml"
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
            this.SearchColor = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Pages\DefectiveCoilsPage.xaml"
            this.SearchColor.SelectionChanged += new System.Windows.RoutedEventHandler(this.SearchColor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PlastType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\DefectiveCoilsPage.xaml"
            this.PlastType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlastType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlastManufact = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\DefectiveCoilsPage.xaml"
            this.PlastManufact.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlastManufact_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PlastitDefectiveView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.RecyclingNameDel = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\DefectiveCoilsPage.xaml"
            this.RecyclingNameDel.Click += new System.Windows.RoutedEventHandler(this.RecyclingNameDel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MyFrame = ((System.Windows.Controls.Frame)(target));
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
            
            #line 44 "..\..\..\Pages\DefectiveCoilsPage.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.AddRecyclingName_Checked);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\Pages\DefectiveCoilsPage.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.AddRecyclingName_Unchecked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

