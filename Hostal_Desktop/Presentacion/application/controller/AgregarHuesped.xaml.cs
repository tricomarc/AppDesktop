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
    /// Lógica de interacción para Huespedes.xaml
    /// </summary>
    public partial class AgregarHuesped : UserControl
    {

        private HuespedBusiness huespedBusiness;
        private HuespedDAO huespedDAO;

        public AgregarHuesped()
        {
            InitializeComponent();
            huespedBusiness = new HuespedBusiness();
            huespedDAO = new HuespedDAO();
        }

        private void Btn_agregar_huesped(object sender, RoutedEventArgs e)
        {
            try
            {
                huespedBusiness.AgregarHuesped(CrearHuesped());
                lbl_mensaje.Content = "Huesped ingresado de forma éxitosa";
                lbl_mensaje.Foreground = Brushes.Green;
                LimpiaCampos();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                lbl_mensaje.Content = "Huesped ya exíste";
            }
        }

        private Huespedes CrearHuesped()
        {
            Huespedes huesped = new Huespedes();

            if (txt_rut_huesped != null && txt_rut_huesped.Text.Count() > 0)
            {
                huesped.RutHuesped = txt_rut_huesped.Text;
                huesped.NombreHuesped = txt_nombre.Text;
                huesped.ApellidoHuesped = txt_apellido.Text;
                huesped.Habitacion = int.Parse(txt_numero_habitacion.Text);
                huesped.OrdenDeCompra = int.Parse(txt_orden_compra.Text);
                huesped.Cliente = txt_rut_empresa.Text;
            }
            return huesped;
        }

        private void LimpiaCampos()
        {
            txt_rut_huesped.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_numero_habitacion.Text = "";
            txt_orden_compra.Text = "";
            txt_rut_empresa.Text = "";
        }

    }
}
