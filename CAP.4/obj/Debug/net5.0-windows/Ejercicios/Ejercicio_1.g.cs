﻿#pragma checksum "..\..\..\..\Ejercicios\Ejercicio_1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721F9D91C07B5B0ED53558739885C11340CFDF8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Capitulo_4;
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


namespace Capitulo_4 {
    
    
    /// <summary>
    /// Ejercicio_1
    /// </summary>
    public partial class Ejercicio_1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumeroTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalcularButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LimpiarButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TablaListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Capitulo 4;component/ejercicios/ejercicio_1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NumeroTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CalcularButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
            this.CalcularButton.Click += new System.Windows.RoutedEventHandler(this.CalcularButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LimpiarButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Ejercicios\Ejercicio_1.xaml"
            this.LimpiarButton.Click += new System.Windows.RoutedEventHandler(this.LimpiarButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TablaListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

