﻿#pragma checksum "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20645FE8886220CAF32214C9C2896FD13B58834D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Presentacion.application.controller;
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


namespace Presentacion.application.controller {
    
    
    /// <summary>
    /// MóduloOrdenDePedido
    /// </summary>
    public partial class MóduloOrdenDePedido : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Buscar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_numero_orden;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_nombre_proveedor;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_rut_proveedor;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_detalle;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_orden_pedido;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_modificar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_eliminar;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/application/controller/m%c3%b3duloordendepedido.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\application\controller\MóduloOrdenDePedido.xaml"
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
            this.txt_Buscar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_numero_orden = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_nombre_proveedor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_rut_proveedor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lbl_detalle = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dtg_orden_pedido = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.btn_modificar = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btn_eliminar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

