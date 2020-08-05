using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Platos
    {
        private int idPlato;
        private String nombrePlato;
        private int precio;
        private int idServicio;
        private int idMinuta;

        public Platos()
        {

        }

        public Platos(int idPlato, string nombrePlato, int precio, int idServicio, int idMinuta)
        {
            this.IdPlato = idPlato;
            this.NombrePlato = nombrePlato;
            this.Precio = precio;
            this.IdServicio = idServicio;
            this.IdMinuta = idMinuta;
        }

        public int IdPlato { get => idPlato; set => idPlato = value; }
        public string NombrePlato { get => nombrePlato; set => nombrePlato = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public int IdMinuta { get => idMinuta; set => idMinuta = value; }
    }
}
