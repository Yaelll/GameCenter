﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3925391FE9A35600167EC88EFB7AC963A51E18DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameCenter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GameCenter {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MainTtile;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DateLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GameText;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image2;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image3;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image4;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image5;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image6;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GameCenter;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainTtile = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.DateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.GameText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Image1 = ((System.Windows.Controls.Image)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.Image1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.Image1.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMouuseLeave);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.Image1.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image1_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Image2 = ((System.Windows.Controls.Image)(target));
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.Image2.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.Image2.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMouuseLeave);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\MainWindow.xaml"
            this.Image2.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image2_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Image3 = ((System.Windows.Controls.Image)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.Image3.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.Image3.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMouuseLeave);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.Image3.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image3_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Image4 = ((System.Windows.Controls.Image)(target));
            
            #line 57 "..\..\..\MainWindow.xaml"
            this.Image4.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\MainWindow.xaml"
            this.Image4.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMouuseLeave);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\MainWindow.xaml"
            this.Image4.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image4_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Image5 = ((System.Windows.Controls.Image)(target));
            
            #line 58 "..\..\..\MainWindow.xaml"
            this.Image5.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\MainWindow.xaml"
            this.Image5.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMouuseLeave);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\MainWindow.xaml"
            this.Image5.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image5_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Image6 = ((System.Windows.Controls.Image)(target));
            
            #line 59 "..\..\..\MainWindow.xaml"
            this.Image6.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\MainWindow.xaml"
            this.Image6.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OnMouuseLeave);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\MainWindow.xaml"
            this.Image6.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image6_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
