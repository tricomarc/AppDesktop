using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class OrdenDeCompra
    {
        private int numeroOrdenCompra;
        private String detalleOrdenCompra;
        private String rutCliente;

        public OrdenDeCompra()
        {

        }

        public OrdenDeCompra(int numeroOrdenCompra, string detalleOrdenCompra, string rutCliente)
        {
            this.NumeroOrdenCompra = numeroOrdenCompra;
            this.DetalleOrdenCompra = detalleOrdenCompra;
            this.RutCliente = rutCliente;
        }

        public int NumeroOrdenCompra { get => numeroOrdenCompra; set => numeroOrdenCompra = value; }
        public string DetalleOrdenCompra { get => detalleOrdenCompra; set => detalleOrdenCompra = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
    }
}
