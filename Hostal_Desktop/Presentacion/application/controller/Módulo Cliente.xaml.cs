using Modelo.application.model;
using Negocio.application.business;
using Persistencia.app.dao;
using Persistencia.DataSet1TableAdapters;
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
using static Persistencia.DataSet1;

namespace Presentacion.application.controller
{
    /// <summary>
    /// Lógica de interacción para Módulo_Cliente.xaml
    /// </summary>
    public partial class Módulo_Cliente : UserControl
    {
        private ClienteDAO clienteDAO;
        private AgregarClienteBusiness agregarClienteBusiness;
        public Módulo_Cliente()
        {

            agregarClienteBusiness = new AgregarClienteBusiness();
            clienteDAO = new ClienteDAO();
            InitializeComponent();
            RellenaCampos();
            

        }



        
        private void Btn_buscar_cliente(object sender, RoutedEventArgs e)
        {
            try
            {
                RellenaCampos();
                HabilitaCampos(txt_Buscar.Text);
                RefreshDataGrid();
                
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }                

        }

        private void Btn_modificar_cliente(object sender, RoutedEventArgs e)
        {
            try
            {
                
                agregarClienteBusiness.ActualizarPorRut(CrearCliente());
                txt_rut.IsEnabled = true;
                RefreshDataGrid();
                LimpiarCampos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_eliminar_cliente(object sender, RoutedEventArgs e)
        {
            try
            {
                object seleccionarFila = dtg_Clientes.SelectedItem;
                if (seleccionarFila != null)
                {
                    if (seleccionarFila.GetType() == typeof(Clientes))
                    {
                        Clientes cliente = (Clientes)seleccionarFila;
                        agregarClienteBusiness.EliminarCliente(cliente);
                        LimpiarCampos();
                        RefreshDataGrid();
                        lbl_mensaje.Content = "Cliente eliminado";
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
        



      
        public void RefreshDataGrid()
        {
            
            dtg_Clientes.ItemsSource = agregarClienteBusiness.ListarRut(txt_Buscar.Text);

            dtg_Clientes.Columns[1].Visibility = Visibility.Hidden;
            dtg_Clientes.Columns[2].Visibility = Visibility.Hidden;
        }

        public void RellenaCampos()
        {
            object selectRow = dtg_Clientes.SelectedItem;
            if (selectRow !=null)
            {
                if (selectRow.GetType() == typeof(Clientes))
                {
                    Clientes cliente = (Clientes)selectRow;
                    txt_rut.Text = cliente.RutCliente;
                    txt_nombre_cliente.Text = cliente.NombreCliente;
                    txt_telefono.Text = cliente.Telefono.ToString();
                    txt_direccion.Text = cliente.Direccion;
                }
            }
           
        }

        public Clientes CrearCliente()
        {
            Clientes cliente = new Clientes();

            if (txt_rut.Text != null && txt_rut.Text.Count() >0)
            {
                cliente.RutCliente = txt_rut.Text;
                cliente.NombreCliente = txt_nombre_cliente.Text;
                cliente.Telefono = int.Parse(txt_telefono.Text);
                cliente.Direccion = txt_direccion.Text;
            }
            

            return cliente;
        }

        public void LimpiarCampos()
        {
            txt_rut.Text = "";
            txt_nombre_cliente.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            txt_Buscar.Text = "";
            lbl_mensaje.Content = "";
        }

        public void HabilitaCampos(string texto)
        {
            if (!string.IsNullOrEmpty(txt_Buscar.Text))
            {
                dtg_Clientes.IsEnabled = true;
                btn_modificar.IsEnabled = true;
                btn_eliminar.IsEnabled = true;
                txt_rut.IsEnabled = true;
                txt_nombre_cliente.IsEnabled = true;
                txt_telefono.IsEnabled = true;
                txt_direccion.IsEnabled = true;
            }
        }
        
    }
}
