using Modelo.application.model;
using Persistencia;
using Persistencia.app.dao;
using Presentacion.application.controller;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

        }

        

        private void Btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            RegistroUsuarioDAO usuarioDAO = new RegistroUsuarioDAO();
            List<RegistroUsuario> usuarios = usuarioDAO.BuscaTodo();

            foreach (RegistroUsuario usuario in usuarios)
            {

                if (String.Compare(usuario.NombreUsuario, txt_usuario.Text) != 0 ) //String.Compare retorna "true" o "false", en este caso compara los campos de la base 
                {                                                                  //con los ingresados por el usuario. Al ser distintos, muestra mensaje de error según corresponda la validación
                    lbl_Error.Content = "Usuario Incorrecto";

                }else if (String.Compare(usuario.Password, txt_contraseña.Password) != 0)
                {
                    lbl_Error.Content = "Contraseña Incorrecta";
                }
                else if (String.Compare(usuario.RolUsuario, cmb_Rol.Text) != 0)
                {
                    lbl_Error.Content = "El rol seleccionado no corresponde a las credenciales ingresadas.";
                }
                else
                {
                    ModuloNavegacion navegacion = new ModuloNavegacion();
                    navegacion.Show();
                    this.Close();
                }
            }
             
        }

    }
}
