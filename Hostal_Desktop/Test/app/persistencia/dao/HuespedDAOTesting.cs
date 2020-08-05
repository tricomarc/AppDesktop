using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.application.model;
using Persistencia.app.dao;

namespace Test.app.persistencia.dao
{
    [TestClass]
    public class HuespedDAOTesting
    {
        [TestMethod]
        public void TestInsertarHuesped()
        {
            
            Huespedes huespedes = new Huespedes();
            huespedes.RutHuesped = "346";
            huespedes.NombreHuesped = "Funciona";
            huespedes.ApellidoHuesped = "Lazo";
            huespedes.Habitacion = 1;
            huespedes.OrdenDeCompra = 2;
            huespedes.Cliente = "30234757-2";

            HuespedDAO huespedDAO = new HuespedDAO();
            bool resultado = huespedDAO.InsertarHuesped(huespedes);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestBuscarHuesped()
        {
            HuespedDAO huespedDAO = new HuespedDAO();

            List<Huespedes> huespedes = huespedDAO.BuscarHuesped("16748168-k");
            foreach (Huespedes huesped in huespedes)
            {
                Debug.WriteLine("Rut -> " + huesped.RutHuesped);
                Debug.WriteLine("Nombre -> " + huesped.NombreHuesped);
                Debug.WriteLine("Apellido -> " + huesped.ApellidoHuesped);
                Debug.WriteLine("ID Habitacion -> " + huesped.Habitacion);
                Debug.WriteLine("ID Orden de Compra -> " + huesped.OrdenDeCompra);
                Debug.WriteLine("Cliente rut -> " + huesped.Cliente);
            }
            Assert.IsTrue(huespedes.Count > 0);
        }

        [TestMethod]
        public void TestModificarHuesped()
        {
            Huespedes huesped = new Huespedes();
            huesped.RutHuesped = "321";
            huesped.NombreHuesped = "Ismael";
            huesped.ApellidoHuesped = "Prueba";
            huesped.Habitacion = 10;
            huesped.OrdenDeCompra = 4;
            huesped.Cliente = "20577250-k";
            huesped.RutHuesped = "321";

            HuespedDAO huespedDAO = new HuespedDAO();
            bool resultado = huespedDAO.ActualizarHuesped(huesped);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestEliminarHuesped()
        {
            HuespedDAO huespedDAO = new HuespedDAO();
            bool resultado = huespedDAO.ElimarHuesped("13645865-2");
            Assert.IsTrue(resultado);
        }
    }
}
