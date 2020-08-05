using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.application.model;
using Persistencia.app.dao;

namespace Test.app.persistencia.dao
{
    /// <summary>
    /// Summary description for ProveedorDAOTesting
    /// </summary>
    [TestClass]
    public class ProveedorDAOTesting
    {
       [TestMethod]
       public void TestBuscarProveedor()
        {
            ProveedorDAO proveedorDAO = new ProveedorDAO();
            List<Proveedores> proveedores = proveedorDAO.BuscarProveedor("26834965-6");
            foreach (Proveedores proveedor  in proveedores)
            {
                Debug.WriteLine("Rut -> " + proveedor.RutProveedor);
            }

            Assert.IsTrue(proveedores.Count > 0);
        }

        [TestMethod]
        public void TestInsertarProveedor()
        {
            Proveedores proveedor = new Proveedores
            {
                RutProveedor = "123",
                UsuarioProveedor = "funciona",
                Password = "funciona",
                NombreProveedor = "Prueba Test",
                RubroProveedor = "Carnes",
                Direccion = "Dirección prueba",
                Telefono = 123456789,
                CorreoElectronico = "test@test.cl"
            };

            ProveedorDAO proveedorDAO = new ProveedorDAO();
            bool resultado = proveedorDAO.InsertarProveedor(proveedor);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestModificarProveedor()
        {
            Proveedores proveedor = new Proveedores();

            proveedor.NombreProveedor = "Test Modificar";
            proveedor.UsuarioProveedor = "loHizo";
            proveedor.Password = "nuevo";
            proveedor.Direccion = "Dirección modificada";
            proveedor.RubroProveedor = "Prueba";
            proveedor.Telefono = 1213;
            proveedor.CorreoElectronico = "cambio@cambio.cl";
            proveedor.RutProveedor = "123";

            ProveedorDAO proveedorDAO = new ProveedorDAO();
            bool resultado = proveedorDAO.ActualizarProveedor(proveedor);
            Assert.IsTrue(resultado);
           
        

        }
        
        [TestMethod]
        public void TestEliminar()
        {
            ProveedorDAO proveedorDAO = new ProveedorDAO();
            bool resultado = proveedorDAO.EliminarProveedor("123");
            Assert.IsTrue(resultado);
        }
    }
}