﻿#pragma checksum "..\..\..\adminControls\CheckInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B72F986E557FF1094ECF56E9009CEC818BDAD2C8"
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
    /// CheckInfo
    /// </summary>
    public partial class CheckInfo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\adminControls\CheckInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TAXONANASTASON.adminControls.CheckInfo Information;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\adminControls\CheckInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllTrip;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\adminControls\CheckInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CurrentTrip;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\adminControls\CheckInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer AllScroll;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\adminControls\CheckInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridAllTrip;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\adminControls\CheckInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridCurrentTrip;
        
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
            System.Uri resourceLocater = new System.Uri("/TAXONANASTASON;component/admincontrols/checkinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\adminControls\CheckInfo.xaml"
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
            this.Information = ((TAXONANASTASON.adminControls.CheckInfo)(target));
            
            #line 8 "..\..\..\adminControls\CheckInfo.xaml"
            this.Information.Loaded += new System.Windows.RoutedEventHandler(this.Information_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AllTrip = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\adminControls\CheckInfo.xaml"
            this.AllTrip.Click += new System.Windows.RoutedEventHandler(this.AllTrip_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CurrentTrip = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\adminControls\CheckInfo.xaml"
            this.CurrentTrip.Click += new System.Windows.RoutedEventHandler(this.CurrentTrip_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AllScroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.DataGridAllTrip = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.DataGridCurrentTrip = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

