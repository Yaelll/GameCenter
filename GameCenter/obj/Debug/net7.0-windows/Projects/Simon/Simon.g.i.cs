﻿#pragma checksum "..\..\..\..\..\Projects\Simon\Simon.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3E7D8174745466CB7F0FC7AE866D51FB1AD76D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameCenter.Projects.Simon;
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


namespace GameCenter.Projects.Simon {
    
    
    /// <summary>
    /// Simon
    /// </summary>
    public partial class Simon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\Projects\Simon\Simon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Projects\Simon\Simon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GreenButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Projects\Simon\Simon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BlueButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\Projects\Simon\Simon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YellowButton;
        
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
            System.Uri resourceLocater = new System.Uri("/GameCenter;component/projects/simon/simon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Projects\Simon\Simon.xaml"
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
            
            #line 21 "..\..\..\..\..\Projects\Simon\Simon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartGame_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RedButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\Projects\Simon\Simon.xaml"
            this.RedButton.Click += new System.Windows.RoutedEventHandler(this.SimonButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GreenButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\Projects\Simon\Simon.xaml"
            this.GreenButton.Click += new System.Windows.RoutedEventHandler(this.SimonButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BlueButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\Projects\Simon\Simon.xaml"
            this.BlueButton.Click += new System.Windows.RoutedEventHandler(this.SimonButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.YellowButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Projects\Simon\Simon.xaml"
            this.YellowButton.Click += new System.Windows.RoutedEventHandler(this.SimonButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

