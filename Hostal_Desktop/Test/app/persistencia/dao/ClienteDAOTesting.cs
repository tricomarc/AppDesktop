using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.application.model;
using Persistencia.app.dao;

namespace Test.app.persistencia.dao
{
    [TestClass]
    public class ClienteDAOTesting
    {
        [TestMethod]
        public void BuscarTodo()
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            List<Clientes> clientes = clienteDAO.BuscaTodo();
            foreach (Clientes cliente in clientes) {

                Debug.WriteLine(" RUT -> " + cliente.RutCliente);
            }

            Assert.IsTrue(clientes.Count > 0);
        } 

        [TestMethod]
        public void TestBuscarClientePorRut()
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            List<Clientes> clientes = clienteDAO.BuscarCliente("30234757-2");
            foreach (Clientes cliente  in clientes)
            {
                Debug.WriteLine("Rut -> " + cliente.RutCliente);
            }

            Assert.IsTrue(clientes.Count > 0);
        }

        [TestMethod]
        public void TestAcutalizarPorRut()
        {
            Clientes cliente = new Clientes
            {
                NombreCliente = "Prueba",
                Telefono = 1234567,
                Direccion = "Prueba",
                RutCliente = "30234757-2"
            };

            ClienteDAO clienteDAO = new ClienteDAO();
            bool resultado = clienteDAO.ActualizarPorRut(cliente);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEliminarPorRut()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            bool resultado = clienteDAO.EliminarPorRut("123");
            Assert.IsTrue(resultado);
        }

        [TestMethod]

        public void TestInsertarCliente()
        {
            Clientes cliente = new Clientes
            {
                RutCliente = "123",
                Usuario = "prueba3",
                Password = "123",
                NombreCliente = "Insert Testing",
                Telefono = 123,
                Direccion = "Dirección testing"
            };

            ClienteDAO clienteDAO = new ClienteDAO();
            bool resultado = clienteDAO.InsertarClientes(cliente);

            Assert.IsTrue(resultado);
        }
    }

}
