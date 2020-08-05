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
    /// Lógica de interacción para AgregarCliente.xaml
    /// </summary>
    public partial class AgregarCliente : UserControl
    {
        private AgregarClienteBusiness agregarClienteBusiness;
        private ClienteDAO clienteDAO;

        public AgregarCliente()
        {
            InitializeComponent();
            agregarClienteBusiness = new AgregarClienteBusiness();
            clienteDAO = new ClienteDAO();
        }

        private void Btn_agregar_cliente(object sender, RoutedEventArgs e)
        {

            try
            {
               

                if (!ValidarRut(txt_Rut.Text))
                {
                    lbl_mensaje.Content = "Debe ingresar rut";
                    lbl_mensaje.Foreground = Brushes.Red;
                }
                else
                {
                    agregarClienteBusiness.AgregarCliente(CrearCliente());
                    lbl_mensaje.Content = "Cliente ingresado de forma éxitosa";
                    lbl_mensaje.Foreground = Brushes.Green;
                    LimpiarCampos();
                }
                   
                

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                lbl_mensaje.Content = "Cliente ya exíste";
            }

        }



        //construye un objeto cliente a partir de los parámetros ingresados en el formulario
        private Clientes CrearCliente()
        {
            Clientes cliente = new Clientes();
            if (txt_Rut.Text != null && txt_Rut.Text.Count() > 0)
            {
                cliente.RutCliente = txt_Rut.Text;
                cliente.Usuario = txt_Usuario.Text;
                cliente.Password = txt_Password.Password;
                cliente.NombreCliente = txt_NombreCliente.Text;
                cliente.Telefono = int.Parse(txt_Telefono.Text);
                cliente.Direccion = txt_Direccion.Text;
            }

            return cliente;
        }

        //Limpia los campos del formulario
        private void LimpiarCampos()
        {
            txt_Rut.Text = "";
            txt_Usuario.Text = "";
            txt_Password.Password = "";
            txt_NombreCliente.Text = "";
            txt_Telefono.Text = "";
            txt_Direccion.Text = "";
        }

        public bool ValidarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

    }
}
