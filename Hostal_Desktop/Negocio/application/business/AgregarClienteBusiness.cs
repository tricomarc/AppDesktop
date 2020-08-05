using Modelo.application.model;
using Negocio.application.rule;
using Persistencia.app.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.application.business
{
    public class AgregarClienteBusiness
    {
        private ClienteDAO clienteDAO;

        public AgregarClienteBusiness()
        {
            clienteDAO = new ClienteDAO();
        }


        //Método que es llamado desde presentación
        public void AgregarCliente(Clientes clientes)
        {
            //Validar(clientes);
            clienteDAO.InsertarClientes(clientes); //hace referencia al metodo creado en capa de persistencia
        }


        public void Validar(Clientes cliente)
        {
            EmptyRule emptyRule = new EmptyRule();
            emptyRule.IsEmpty(cliente.RutCliente, "Rut Cliente");
            emptyRule.IsEmpty(cliente.Usuario, "Usuario");
            emptyRule.IsEmpty(cliente.Password, "Contraseña");
            emptyRule.IsEmpty(cliente.NombreCliente, "Nombre Cliente");
            emptyRule.IsEmpty(cliente.Direccion, "Dirección");
            emptyRule.IsEmpty(cliente.Telefono.ToString(), "Telefono");
        }



        //Método que lista todos los clientes
        public List<Clientes> Listar()
        {
            return clienteDAO.BuscaTodo();//Hace referenca a método creado en persistencia
        }



        //Método que lista los clientes según rut
        public List<Clientes> ListarRut(string rut)
        {
            return clienteDAO.BuscarCliente(rut);
        }

        public void ActualizarPorRut(Clientes cliente)
        {
            clienteDAO.ActualizarPorRut(cliente);
        }

        public void EliminarCliente(Clientes cliente)
        {
            clienteDAO.EliminarPorRut(cliente.RutCliente);
        }
    }
}
