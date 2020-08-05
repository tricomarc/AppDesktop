using Modelo.application.model;
using Persistencia.app.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            List<Clientes> clientes = clienteDao.BuscaTodo();

            foreach (Clientes cliente in clientes)
            {
                Debug.WriteLine("RUT -> " + cliente.RutCliente);
            }
        }
    }
}
