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
    /// Lógica de interacción para MóduloHuésped.xaml
    /// </summary>
    public partial class MóduloHuésped : UserControl
    {

        private HuespedDAO huespedDAO;
        private HuespedBusiness huespedBusiness;

        public MóduloHuésped()
        {
            InitializeComponent();
            huespedDAO = new HuespedDAO();
            huespedBusiness = new HuespedBusiness();
        }

        private void Btn_buscar_huesped(object sender, RoutedEventArgs e)
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

        private void Btn_modificar_huesped(object sender, RoutedEventArgs e)
        {
            try
            {
                huespedBusiness.ActualizarHuesped(CrearHuesped());
                RefreshDataGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }

        private void Btn_eliminar_eliminar(object sender, RoutedEventArgs e)
        {
            try
            {
                object selectRow = dtg_huespedes.SelectedItem;

                if (selectRow.GetType() == typeof(Huespedes))
                {
                    Huespedes huesped = (Huespedes)selectRow;
                    huespedBusiness.EliminarHuesped(huesped);
                    LimpiarCampos();
                    RefreshDataGrid();
                    lbl_mensaje.Content = "Huésped eliminado";
                    lbl_mensaje.Foreground = Brushes.Green;
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
            dtg_huespedes.ItemsSource = huespedBusiness.ListarHuesped(txt_Buscar.Text);

        }

        public void RellenaCampos()
        {

            object selectRow = dtg_huespedes.SelectedItem;
            if (selectRow != null)
            {
                if (selectRow.GetType() == typeof(Huespedes))
                {
                    Huespedes huesped = new Huespedes();
                    txt_rut_huesped.Text = huesped.RutHuesped;
                    txt_nombre_huesped.Text = huesped.NombreHuesped;
                    txt_apellido_huesped.Text = huesped.ApellidoHuesped;
                    txt_numero_habitacion.Text = huesped.Habitacion.ToString();
                    txt_orden_compra.Text = huesped.OrdenDeCompra.ToString();
                    txt_rut_empresa.Text = huesped.Cliente;


                }
            }
        }

        public Huespedes CrearHuesped()
        {
            Huespedes huesped = new Huespedes();
            if (txt_rut_huesped.Text != null && txt_rut_huesped.Text.Count() > 0)
            {
                huesped.RutHuesped = txt_rut_huesped.Text;
                huesped.NombreHuesped = txt_nombre_huesped.Text;
                huesped.ApellidoHuesped = txt_apellido_huesped.Text;
                huesped.Habitacion = int.Parse(txt_numero_habitacion.Text);
                huesped.OrdenDeCompra = int.Parse(txt_orden_compra.Text);
                huesped.Cliente = txt_rut_empresa.Text;
            }
            return huesped;
        }

        public void LimpiarCampos()
        {
            txt_rut_huesped.Text = "";
            txt_nombre_huesped.Text = "";
            txt_apellido_huesped.Text = "";
            txt_numero_habitacion.Text = "";
            txt_orden_compra.Text = "";
            txt_rut_empresa.Text = "";
        }

        public void HabilitaCampos(string texto)
        {
            if (!string.IsNullOrEmpty(txt_Buscar.Text))
            {
                dtg_huespedes.IsEnabled = true;
                btn_modificar.IsEnabled = true;
                btn_eliminar.IsEnabled = true;
                txt_rut_huesped.IsEnabled = true;
                txt_nombre_huesped.IsEnabled = true;
                txt_apellido_huesped.IsEnabled = true;
                txt_numero_habitacion.IsEnabled = true;
                txt_orden_compra.IsEnabled = true;
                txt_rut_empresa.IsEnabled = true;
            }
        }
    }
}
