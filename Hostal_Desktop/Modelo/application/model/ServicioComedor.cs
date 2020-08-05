using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class ServicioComedor
    {
        private int idComedor;
        private String tipoServicio;
        private int numeroFactura;

        public ServicioComedor()
        {

        }

        public ServicioComedor(int idComedor, string tipoServicio, int numeroFactura)
        {
            this.IdComedor = idComedor;
            this.TipoServicio = tipoServicio;
            this.NumeroFactura = numeroFactura;
        }

        public int IdComedor { get => idComedor; set => idComedor = value; }
        public string TipoServicio { get => tipoServicio; set => tipoServicio = value; }
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
    }
}
