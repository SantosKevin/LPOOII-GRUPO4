﻿#pragma checksum "..\..\WinAsignacionButacas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E1CFD9DC92985668FE50F47FC0F3CE8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Vistas;


namespace Vistas {
    
    
    /// <summary>
    /// WinAsignacionButacas
    /// </summary>
    public partial class WinAsignacionButacas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockMenu;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaxi;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNormal;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdFilas;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAceptar;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 182 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridFilas;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\WinAsignacionButacas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid myGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/winasignacionbutacas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WinAsignacionButacas.xaml"
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
            this.dockMenu = ((System.Windows.Controls.DockPanel)(target));
            
            #line 22 "..\..\WinAsignacionButacas.xaml"
            this.dockMenu.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DockMenu_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\WinAsignacionButacas.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMaxi = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\WinAsignacionButacas.xaml"
            this.btnMaxi.Click += new System.Windows.RoutedEventHandler(this.BtnMaxi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNormal = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\WinAsignacionButacas.xaml"
            this.btnNormal.Click += new System.Windows.RoutedEventHandler(this.BtnNormal_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\WinAsignacionButacas.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.BtnMin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.brdFilas = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.btnAceptar = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\WinAsignacionButacas.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.BtnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.gridFilas = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.myGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

