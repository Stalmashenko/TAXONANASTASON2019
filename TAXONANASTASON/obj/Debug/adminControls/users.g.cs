﻿#pragma checksum "..\..\..\adminControls\users.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "666201525803AEEA893075E9411BD5E25D232482"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TAXONANASTASON.adminControls;


namespace TAXONANASTASON.adminControls {
    
    
    /// <summary>
    /// users
    /// </summary>
    public partial class users : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TAXONANASTASON.adminControls.users AllUsers;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllDrivers;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllClients;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button XMLParse;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button XMLExport;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridDrivers;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\adminControls\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridClients;
        
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
            System.Uri resourceLocater = new System.Uri("/TAXONANASTASON;component/admincontrols/users.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\adminControls\users.xaml"
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
            this.AllUsers = ((TAXONANASTASON.adminControls.users)(target));
            
            #line 8 "..\..\..\adminControls\users.xaml"
            this.AllUsers.Loaded += new System.Windows.RoutedEventHandler(this.AllUsers_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AllDrivers = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\adminControls\users.xaml"
            this.AllDrivers.Click += new System.Windows.RoutedEventHandler(this.AllDrivers_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AllClients = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\adminControls\users.xaml"
            this.AllClients.Click += new System.Windows.RoutedEventHandler(this.AllClients_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.XMLParse = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\adminControls\users.xaml"
            this.XMLParse.Click += new System.Windows.RoutedEventHandler(this.XMLParse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.XMLExport = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\adminControls\users.xaml"
            this.XMLExport.Click += new System.Windows.RoutedEventHandler(this.XMLExport_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DataGridDrivers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.DataGridClients = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

