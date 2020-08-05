using Modelo.application.model;
using Persistencia.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Persistencia.DataSet1;

namespace Persistencia.app.dao
{
    public class RegistroUsuarioDAO
    {


        /**MÉTODO QUE BUSCA TODOS LOS USUARIOS REGISTRADOS**/

        public List<RegistroUsuario> BuscaTodo()
        {
            List<RegistroUsuario> usuarios = new List<RegistroUsuario>();

            REGISTRO_USUARIOTableAdapter adaptador = new REGISTRO_USUARIOTableAdapter();

            foreach (REGISTRO_USUARIORow  row in adaptador.GetData())
            {
                RegistroUsuario usuario = new RegistroUsuario
                {
                    RutUsuario = row.RUT_USUARIO,
                    NombreUsuario = row.NOMBRE_USUARIO,
                    Password = row.PASSWORD,
                    RolUsuario = row.ROL_USUARIO
                };
                //usuario.RutCliente = row.CLIENTES_RUT_CLIENTE;
                //usuario.RutEmpleado = row.EMPLEADOS_RUT_EMPLEADO;
                //usuario.RutProveedor = row.PROVEEDORES_RUT_PROVEEDOR;
                usuarios.Add(usuario);
            }
            return usuarios;
        }

       
    }
}
