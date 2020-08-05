using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Empleados
    {
        private String rutEmpleado;
        private String nombreEmpleado;
        private String apellidoEmpleado;
        private String cargoEmpleado;
        private String usuarioEmpleado;
        private String password;
        private String rutCliente;

        public Empleados()
        {

        }

        public Empleados(string rutEmpleado, string nombreEmpleado, string apellidoEmpleado, string cargoEmpleado, string usuarioEmpleado, string password, string rutCliente)
        {
            this.RutEmpleado = rutEmpleado;
            this.NombreEmpleado = nombreEmpleado;
            this.ApellidoEmpleado = apellidoEmpleado;
            this.CargoEmpleado = cargoEmpleado;
            this.UsuarioEmpleado = usuarioEmpleado;
            this.Password = password;
            this.RutCliente = rutCliente;
        }

        public string RutEmpleado { get => rutEmpleado; set => rutEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApellidoEmpleado { get => apellidoEmpleado; set => apellidoEmpleado = value; }
        public string CargoEmpleado { get => cargoEmpleado; set => cargoEmpleado = value; }
        public string UsuarioEmpleado { get => usuarioEmpleado; set => usuarioEmpleado = value; }
        public string Password { get => password; set => password = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
    }
}
