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
    /// Lógica de interacción para MóduloProveedor.xaml
    /// </summary>
    public partial class MóduloProveedor : UserControl
    {
        private ProveedorDAO proveedorDAO;
        private ProveedorBusiness proveedorBusiness;

        public MóduloProveedor()
        {
            proveedorBusiness = new ProveedorBusiness();
            proveedorDAO = new ProveedorDAO();
            InitializeComponent();
                       
        }

        private void Btn_buscar_proveedor(object sender, RoutedEventArgs e)
        {
            try
            {
                RellenaCampos();
                HabilitaCampos(txt_Buscar.Text);
                RefreshDataGrid();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_modificar_proveedor(object sender, RoutedEventArgs e)
        {
            try
            {
                proveedorBusiness.ActualizarProveedor(CrearProveedor());
                RefreshDataGrid();
                LimpiaCampos();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }  
        }

        private void Btn_eliminar_proveedor(object sender, RoutedEventArgs e)
        {
            try
            {
                object seleccionarFila = dtg_proveedores.SelectedItem;

                if (seleccionarFila != null)
                {
                    if (seleccionarFila.GetType() == typeof(Proveedores))
                    {
                        Proveedores proveedor = (Proveedores)seleccionarFila;
                        proveedorBusiness.EliminarProveedor(proveedor);
                        LimpiaCampos();
                        RefreshDataGrid();
                        lbl_mensaje.Content = "Proveedor eliminado";
                        lbl_mensaje.Foreground = Brushes.Green;
                    }
                }
                else
                {
                    lbl_mensaje.Content = "Debe seleccionar fila para eliminar";
                    lbl_mensaje.Foreground = Brushes.Red;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }

        private void RefreshDataGrid()
        {
            dtg_proveedores.ItemsSource = proveedorBusiness.ListarProveedor(txt_Buscar.Text);
            //dtg_proveedores.Columns[0].Visibility = Visibility.Hidden;
            dtg_proveedores.Columns[6].Visibility = Visibility.Hidden;
            dtg_proveedores.Columns[7].Visibility = Visibility.Hidden;
        }

        private void RellenaCampos()
        {
            object selectRow = dtg_proveedores.SelectedItem;
            if (selectRow != null)
            {
                if (selectRow.GetType() == typeof(Proveedores))
                {
                    Proveedores proveedor = (Proveedores)selectRow;
                    txt_nombre_proveedor.Text = proveedor.NombreProveedor;
                    txt_direccion.Text = proveedor.Direccion;
                    txt_telefono.Text = proveedor.Telefono.ToString();
                    txt_correo.Text = proveedor.CorreoElectronico;
                    txt_rubro.Text = proveedor.RubroProveedor;
                }
            }
        }

        public Proveedores CrearProveedor()
        {
            Proveedores proveedor = new Proveedores();
            if (txt_nombre_proveedor.Text != null && txt_nombre_proveedor.Text.Count() > 0)
            {
                proveedor.RutProveedor = txt_Buscar.Text;
                proveedor.NombreProveedor = txt_nombre_proveedor.Text;
                proveedor.Direccion = txt_direccion.Text;
                proveedor.Telefono = int.Parse(txt_telefono.Text);
                proveedor.CorreoElectronico = txt_correo.Text;
                proveedor.RubroProveedor = txt_rubro.Text;
            }
            return proveedor;
        }

        public void LimpiaCampos()
        {
            txt_nombre_proveedor.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_rubro.Text = "";
            txt_Buscar.Text = "";
        }

        public void HabilitaCampos(string texto)
        {
            if (!string.IsNullOrEmpty(txt_Buscar.Text))
            {
                dtg_proveedores.IsEnabled = true;
                btn_modificar.IsEnabled = true;
                btn_eliminar.IsEnabled = true;
                txt_nombre_proveedor.IsEnabled = true;
                txt_direccion.IsEnabled = true;
                txt_telefono.IsEnabled = true;
                txt_correo.IsEnabled = true;
                txt_rubro.IsEnabled = true;
            }
        }
    }
}
