using Modelo.application.model;
using Negocio.application.business;
using Persistencia.app.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion.application.controller
{
    /// <summary>
    /// Lógica de interacción para AgregarProveedor.xaml
    /// </summary>
    public partial class AgregarProveedor : UserControl
    {

        private ProveedorBusiness proveedorBusiness;
        private ProveedorDAO proveedorDAO;

        public AgregarProveedor()
        {
            proveedorBusiness = new ProveedorBusiness();
            proveedorDAO = new ProveedorDAO();
            InitializeComponent();
        }

        private void Btn_agregar_proveedor(object sender, RoutedEventArgs e)
        {
            try
            {
                proveedorBusiness.AgregarProveedor(CrearProveedor());
                lbl_mensaje.Content = "Proveeedor ingresado de forma éxitosa";
                lbl_mensaje.Foreground = Brushes.Green;

                LimpiarCampos();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                lbl_mensaje.Content = "Proveedor ya exíste";
            }
        }




        //Construye cliente desde los parámetros ingresados por el usuario
        private Proveedores CrearProveedor()
        {
            Proveedores proveedor = new Proveedores();

            if (txt_rut.Text != null && txt_rut.Text.Count() > 0)
            {
                proveedor.RutProveedor = txt_rut.Text;
                proveedor.UsuarioProveedor = txt_usuario_proveedor.Text;
                proveedor.Password = txt_password.Password;
                proveedor.NombreProveedor = txt_nombre_proveedor.Text;
                proveedor.RubroProveedor = txt_rubro.Text;
                proveedor.Direccion = txt_direccion.Text;
                proveedor.Telefono = int.Parse(txt_telefono.Text);
                proveedor.CorreoElectronico = txt_correo.Text;

            }

            return proveedor;
        }


        private void LimpiarCampos()
        {
            txt_rut.Text = "";
            txt_usuario_proveedor.Text = "";
            txt_password.Password = "";
            txt_nombre_proveedor.Text = "";
            txt_rubro.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text= "";
            txt_correo.Text = "";
        }
    }
}
