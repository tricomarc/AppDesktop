using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Huespedes
    {
        /** Atributos de la clase**/

        private String rutHuesped;
        private String nombreHuesped;
        private String apellidoHuesped;
        private int habitacion;
        private int ordenDeCompra;
        private string cliente;

        public Huespedes()
        {

        }

        public Huespedes(string rutHuesped, string nombreHuesped, string apellidoHuesped, int habitacion, int ordenDeCompra, string cliente)
        {
            this.RutHuesped = rutHuesped;
            this.NombreHuesped = nombreHuesped;
            this.ApellidoHuesped = apellidoHuesped;
            this.Habitacion = habitacion;
            this.OrdenDeCompra = ordenDeCompra;
            this.Cliente = cliente;
        }

        public string RutHuesped { get => rutHuesped; set => rutHuesped = value; }
        public string NombreHuesped { get => nombreHuesped; set => nombreHuesped = value; }
        public string ApellidoHuesped { get => apellidoHuesped; set => apellidoHuesped = value; }
        public int Habitacion { get => habitacion; set => habitacion = value; }
        public int OrdenDeCompra { get => ordenDeCompra; set => ordenDeCompra = value; }
        public string Cliente { get => cliente; set => cliente = value; }


    }
}
