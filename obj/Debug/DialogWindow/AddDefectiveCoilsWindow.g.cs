﻿#pragma checksum "..\..\..\DialogWindow\AddDefectiveCoilsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C236AA7AD6F5DD311DF83C4B389EC6998BC1CF5A269B7355ECF73EA08EA9A995"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StockroomBinar.DialogWindow;
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


namespace StockroomBinar.DialogWindow {
    
    
    /// <summary>
    /// AddDefectiveCoilsWindow
    /// </summary>
    public partial class AddDefectiveCoilsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\DialogWindow\AddDefectiveCoilsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountDefectiveCoils;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\DialogWindow\AddDefectiveCoilsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DefectiveTypePlast;
        
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
            System.Uri resourceLocater = new System.Uri("/StockroomBinar;component/dialogwindow/adddefectivecoilswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogWindow\AddDefectiveCoilsWindow.xaml"
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
            this.CountDefectiveCoils = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\DialogWindow\AddDefectiveCoilsWindow.xaml"
            this.CountDefectiveCoils.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CountDefectiveCoils_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DefectiveTypePlast = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 23 "..\..\..\DialogWindow\AddDefectiveCoilsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

