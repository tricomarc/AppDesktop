 using Modelo.application.model;
using Persistencia.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Persistencia.DataSet1;

namespace Persistencia.app.dao
{
    public class ClienteDAO
    {
        private CLIENTESTableAdapter adapter;

        public ClienteDAO()
        {
            adapter = new CLIENTESTableAdapter();
        }

        public List<Clientes> BuscaTodo()
        {

            List<Clientes> clientes = new List<Clientes>();

            CLIENTESTableAdapter adapter = new CLIENTESTableAdapter();

            foreach (CLIENTESRow fila in adapter.GetData())
            {
                Clientes cliente = new Clientes
                {
                    RutCliente = fila.RUT_CLIENTE,
                    NombreCliente = fila.NOMBRE_CLIENTE,
                    Password = fila.PASSWORD,
                    Usuario = fila.USUARIO_EMPRESA,
                    Telefono = (int)fila.TELEFONO,
                    Direccion = fila.DIRECCION
                };
                clientes.Add(cliente);
            }


            return clientes;
        }

        //Busca cliente por rut
        public List<Clientes> BuscarCliente(string rut)
        {
            List<Clientes> clientes = new List<Clientes>();

            try
            {
                foreach (CLIENTESRow fila in adapter.BuscarCliente(rut).Rows)
                {
                    Clientes cliente = new Clientes
                    {
                        RutCliente = fila.RUT_CLIENTE,
                        Usuario = fila.USUARIO_EMPRESA,
                        NombreCliente = fila.NOMBRE_CLIENTE,
                        Direccion = fila.DIRECCION,
                        Telefono = (int)fila.TELEFONO
                    };

                    clientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
            

            return clientes;
        }

        //Insertar Clientes
        public bool InsertarClientes(Clientes cliente)
        {
            try
            {
                int resultado = adapter.InsertarCliente(cliente.RutCliente,
                                                        cliente.Usuario,
                                                        cliente.Password,
                                                        cliente.NombreCliente,
                                                        cliente.Telefono,
                                                        cliente.Direccion);

                if (resultado ==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        //Actualiza Clientes por  Rut 
        public bool ActualizarPorRut(Clientes cliente)
        {

            try
            {
                 int resultado = adapter.UpdatebyRut(cliente.NombreCliente,
                                         cliente.Telefono,
                                         cliente.Direccion,
                                         cliente.RutCliente);

                if (resultado == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }
        }


        //Elimina Clientes por rut
        public bool EliminarPorRut(string rut)
        {
            try
            {
                int resultado = adapter.EliminarRut(rut);

                if (resultado ==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }
        }
    }  
}
