﻿#pragma checksum "..\..\..\Pages\PlasticStorage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEB620594A3A4FE7586C09E0A2252EDC9EBA28458B46E3C1CB1D9042678D65A7"
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
    /// PlasticStorage
    /// </summary>
    public partial class PlasticStorage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchColor;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlastType;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlastManufact;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PlastitStoageView;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPlatic;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManufactInfo;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Pages\PlasticStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrintInfo;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Pages\PlasticStorage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/StockroomBinar;component/pages/plasticstorage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PlasticStorage.xaml"
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
            
            #line 19 "..\..\..\Pages\PlasticStorage.xaml"
            this.SearchColor.SelectionChanged += new System.Windows.RoutedEventHandler(this.SearchColor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PlastType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\Pages\PlasticStorage.xaml"
            this.PlastType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlastType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlastManufact = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\PlasticStorage.xaml"
            this.PlastManufact.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlastManufact_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PlastitStoageView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            
            #line 34 "..\..\..\Pages\PlasticStorage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddPlatic = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Pages\PlasticStorage.xaml"
            this.AddPlatic.Click += new System.Windows.RoutedEventHandler(this.AddPlatic_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ManufactInfo = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Pages\PlasticStorage.xaml"
            this.ManufactInfo.Click += new System.Windows.RoutedEventHandler(this.ManufactInfo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PrintInfo = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Pages\PlasticStorage.xaml"
            this.PrintInfo.Click += new System.Windows.RoutedEventHandler(this.PrintInfo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MyFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

