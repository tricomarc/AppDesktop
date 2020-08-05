using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Minutas
    {
        private int idMinuta;
        private String dia;
        private String detalleDia;
        private int idServicio;

        public Minutas()
        {

        }

        public Minutas(int idMinuta, string dia, string detalleDia, int idServicio)
        {
            this.IdMinuta = idMinuta;
            this.Dia = dia;
            this.DetalleDia = detalleDia;
            this.IdServicio = idServicio;
        }

        public int IdMinuta { get => idMinuta; set => idMinuta = value; }
        public string Dia { get => dia; set => dia = value; }
        public string DetalleDia { get => detalleDia; set => detalleDia = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
    }
}
