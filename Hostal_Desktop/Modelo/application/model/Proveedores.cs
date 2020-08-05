using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Proveedores
    {
        private String rutProveedor;
        private String usuarioProveedor;
        private String password;
        private String nombreProveedor;
        private String direccion;
        private String rubroProveedor;
        private int telefono;
        private String correoElectronico;

        public Proveedores()
        {

        }

        public Proveedores(string rutProveedor, string usuarioProveedor, string password, string nombreProveedor, string direccion, string rubroProveedor, int telefono, string correoElectronico)
        {
            this.RutProveedor = rutProveedor;
            this.UsuarioProveedor = usuarioProveedor;
            this.Password = password;
            this.NombreProveedor = nombreProveedor;
            this.Direccion = direccion;
            this.RubroProveedor = rubroProveedor;
            this.Telefono = telefono;
            this.CorreoElectronico = correoElectronico;
        }

        public string RutProveedor { get => rutProveedor; set => rutProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string RubroProveedor { get => rubroProveedor; set => rubroProveedor = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string UsuarioProveedor { get => usuarioProveedor; set => usuarioProveedor = value; }
        public string Password { get => password; set => password = value; }
    }
}
