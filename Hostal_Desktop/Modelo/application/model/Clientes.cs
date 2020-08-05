using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
     public class Clientes
    {
        /** Atributos de la clase**/
        private String rutCliente;
        private String usuario;
        private String password;
        private String nombreCliente;
        private int telefono;
        private String direccion;

        /** Constructor sin Parámetros **/
        public Clientes()
        {

        }


        /** Constructor con parámetros**/
        public Clientes(string rutCliente, string usuario, string password, string nombreCliente, int telefono, string direccion)
        {
            this.RutCliente = rutCliente;
            this.Usuario = usuario;
            this.Password = password;
            this.NombreCliente = nombreCliente;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public string RutCliente { get => rutCliente; set => rutCliente = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
