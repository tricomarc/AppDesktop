using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class RegistroUsuario
    {
        private String rutUsuario;
        private String nombreUsuario;
        private String password;
        private String rolUsuario;
        private String rutCliente;
        private String rutEmpleado;
        private String rutProveedor;

        public RegistroUsuario()
        {

        }

       

        public RegistroUsuario(string rutUsuario, string nombreUsuario, string password, string rolUsuario, string rutCliente, string rutEmpleado, string rutProveedor)
        {
            this.RutUsuario = rutUsuario;
            this.NombreUsuario = nombreUsuario;
            this.Password = password;
            this.RolUsuario = rolUsuario;
            this.rutCliente = rutCliente;
            this.rutEmpleado = rutEmpleado;
            this.rutProveedor = rutProveedor;
        }

        public string RutUsuario { get => rutUsuario; set => rutUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string RolUsuario { get => rolUsuario; set => rolUsuario = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
        public string RutEmpleado { get => rutEmpleado; set => rutEmpleado = value; }
        public string RutProveedor { get => rutProveedor; set => rutProveedor = value; }
    }
}
