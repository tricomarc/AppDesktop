using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Facturas
    {
        private int numeroFactura;
        private int idVenta;
        private int precioFactura;
        private String rutCliente;

        public Facturas()
        {

        }

        public Facturas(int numeroFactura, int idVenta, int precioFactura, string rutCliente)
        {
            this.NumeroFactura = numeroFactura;
            this.IdVenta = idVenta;
            this.PrecioFactura = precioFactura;
            this.RutCliente = rutCliente;
        }

        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int PrecioFactura { get => precioFactura; set => precioFactura = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
    }
}
