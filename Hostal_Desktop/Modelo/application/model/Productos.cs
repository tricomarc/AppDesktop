using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class Productos
    {
        private String codigoProducto;
        private String nombreProducto;
        private String descripcionProducto;
        private int stock;
        private int stockCritico;
        private int precio;
        private DateTime fechaRecepcion;
        private String rutEmpleado;
        private String idPedido;
        private String rutProveedor;

        public Productos()
        {

        }

        public Productos(string codigoProducto, string nombreProducto, string descripcionProducto, int stock, int stockCritico, int precio, DateTime fechaRecepcion, string rutEmpleado, string idPedido, string rutProveedor)
        {
            this.CodigoProducto = codigoProducto;
            this.NombreProducto = nombreProducto;
            this.DescripcionProducto = descripcionProducto;
            this.Stock = stock;
            this.StockCritico = stockCritico;
            this.Precio = precio;
            this.FechaRecepcion = fechaRecepcion;
            this.RutEmpleado = rutEmpleado;
            this.IdPedido = idPedido;
            this.RutProveedor = rutProveedor;
        }

        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public int Stock { get => stock; set => stock = value; }
        public int StockCritico { get => stockCritico; set => stockCritico = value; }
        public int Precio { get => precio; set => precio = value; }
        public DateTime FechaRecepcion { get => fechaRecepcion; set => fechaRecepcion = value; }
        public string RutEmpleado { get => rutEmpleado; set => rutEmpleado = value; }
        public string IdPedido { get => idPedido; set => idPedido = value; }
        public string RutProveedor { get => rutProveedor; set => rutProveedor = value; }
    }
}
