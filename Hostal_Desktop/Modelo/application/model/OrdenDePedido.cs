using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.application.model
{
    public class OrdenDePedido
    {
        private int idPedido;
        private DateTime fechaCreacion;
        private Proveedores rutProveedor;

        public OrdenDePedido()
        {

        }

        public OrdenDePedido(int idPedido, DateTime fechaCreacion, Proveedores rutProveedor)
        {
            this.IdPedido = idPedido;
            this.FechaCreacion = fechaCreacion;
            this.RutProveedor = rutProveedor;
        }

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public Proveedores RutProveedor { get => rutProveedor; set => rutProveedor = value; }
    }
}
