using Modelo.application.model;
using Persistencia.app.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.application.business
{
    public class ProveedorBusiness
    {

        private ProveedorDAO proveedorDAO;

        public ProveedorBusiness()
        {
            proveedorDAO = new ProveedorDAO();
        }



        
        /* Todos los métodos aqui creados hacen referencia a los creados en la capa de persistencia*/


        //Insertar
        public void AgregarProveedor(Proveedores proveedor)
        {
            proveedorDAO.InsertarProveedor(proveedor);
        }


        //Listar Todo
        public List<Proveedores> Listar()
        {
            return proveedorDAO.BuscaTodo();
        }


        //Listar Por rut
        public List<Proveedores> ListarProveedor(string rut)
        {
            return proveedorDAO.BuscarProveedor(rut);
        }


        //Modificar proveedor
        public void ActualizarProveedor(Proveedores proveedor)
        {
            proveedorDAO.ActualizarProveedor(proveedor);
        }


        //Eliminar proveedor por rut
        public void EliminarProveedor(Proveedores proveedor)
        {
            proveedorDAO.EliminarProveedor(proveedor.RutProveedor);
        }
    }
}
