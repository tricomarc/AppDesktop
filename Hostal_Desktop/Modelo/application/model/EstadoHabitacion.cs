using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class EstadoHabitacion
    {
        /** Atributos **/
        private int idEstado;
        private String estado;
        private int idHabitacion;

        /** Constructor sin parámetros **/
        public EstadoHabitacion()
        {

        }

        public EstadoHabitacion(int idEstado, string estado, int idHabitacion)
        {
            this.IdEstado = idEstado;
            this.estado = estado;
            this.idHabitacion = idHabitacion;
        }

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
    }
}
