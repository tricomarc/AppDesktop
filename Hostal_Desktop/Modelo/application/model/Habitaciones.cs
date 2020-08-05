using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Habitaciones
    {
        /** Atributos **/
        private int idHabitacion;
        private int numeroHabitacion;
        private String tipoCama;
        private String accesorio;
        private int precio;
        private int cantidadAccesorios;

        public Habitaciones()
        {

        }

        public Habitaciones(int idHabitacion, int numeroHabitacion, string tipoCama, string accesorio, int precio, int cantidadAccesorios)
        {
            this.IdHabitacion = idHabitacion;
            this.NumeroHabitacion = numeroHabitacion;
            this.TipoCama = tipoCama;
            this.Accesorio = accesorio;
            this.Precio = precio;
            this.CantidadAccesorios = cantidadAccesorios;
        }

        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public int NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        public string TipoCama { get => tipoCama; set => tipoCama = value; }
        public string Accesorio { get => accesorio; set => accesorio = value; }
        public int Precio { get => precio; set => precio = value; }
        public int CantidadAccesorios { get => cantidadAccesorios; set => cantidadAccesorios = value; }
    }
}
