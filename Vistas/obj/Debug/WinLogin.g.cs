﻿#pragma checksum "..\..\WinLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FB01171852F6987C8B524488A406C48E"
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
    /// WinLogin
    /// </summary>
    public partial class WinLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaxi;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNormal;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPass;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MyBorderBtn;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\WinLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIngreso;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/winlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WinLogin.xaml"
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
            
            #line 35 "..\..\WinLogin.xaml"
            this.dockMenu.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DockMenu_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\WinLogin.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMaxi = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\WinLogin.xaml"
            this.btnMaxi.Click += new System.Windows.RoutedEventHandler(this.BtnMaxi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNormal = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\WinLogin.xaml"
            this.btnNormal.Click += new System.Windows.RoutedEventHandler(this.BtnNormal_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\WinLogin.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.BtnMin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\WinLogin.xaml"
            this.txtUsername.GotFocus += new System.Windows.RoutedEventHandler(this.TxtUsername_GotFocus);
            
            #line default
            #line hidden
            
            #line 69 "..\..\WinLogin.xaml"
            this.txtUsername.LostFocus += new System.Windows.RoutedEventHandler(this.TxtUsername_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 86 "..\..\WinLogin.xaml"
            this.txtPass.LostFocus += new System.Windows.RoutedEventHandler(this.TxtPass_LostFocus);
            
            #line default
            #line hidden
            
            #line 86 "..\..\WinLogin.xaml"
            this.txtPass.GotFocus += new System.Windows.RoutedEventHandler(this.TxtPass_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MyBorderBtn = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.btnIngreso = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\WinLogin.xaml"
            this.btnIngreso.Click += new System.Windows.RoutedEventHandler(this.BtnIngreso_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
