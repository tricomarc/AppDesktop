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
    public class ProveedorDAO
    {
        private PROVEEDORESTableAdapter adapter;

        public ProveedorDAO()
        {
            adapter = new PROVEEDORESTableAdapter();
        }


        //Método que lista todos los proveedotres -> será utilizado para cargar DataGrid dtg_proveedores
        public List<Proveedores> BuscaTodo()
        {
            List<Proveedores> proveedores = new List<Proveedores>();

            foreach (PROVEEDORESRow fila in adapter.GetData())
            {
                Proveedores proveedor = new Proveedores
                {
                    RutProveedor = fila.RUT_PROVEEDOR,
                    NombreProveedor = fila.NOMBRE_PROVEEDOR,
                    Direccion = fila.DIRECCION_PROVEEDOR,
                    RubroProveedor = fila.RUBRO_PROVEEDOR,
                    Telefono = (Int32)fila.TELEFONO,
                    CorreoElectronico = fila.CORREO_ELECTRONICO
                };
                proveedores.Add(proveedor);
            }

            return proveedores;
        }


        //Busca y lista proveedores por rut
        public List<Proveedores> BuscarProveedor(string rut)
        {
            List<Proveedores> proveedores = new List<Proveedores>();

            try
            {
                foreach (PROVEEDORESRow fila in adapter.BuscarProveedor(rut).Rows)
                {
                    Proveedores proveedor = new Proveedores();
                    proveedor.RutProveedor = fila.RUT_PROVEEDOR;
                    proveedor.NombreProveedor = fila.NOMBRE_PROVEEDOR;
                    proveedor.Direccion = fila.DIRECCION_PROVEEDOR;
                    proveedor.RubroProveedor = fila.RUBRO_PROVEEDOR;
                    proveedor.Telefono = (int)fila.TELEFONO;
                    proveedor.CorreoElectronico = fila.CORREO_ELECTRONICO;
                    

                    proveedores.Add(proveedor);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }


            return proveedores;
        }

        //Insertar Proveedores

        public bool InsertarProveedor(Proveedores proveedor)
        {
            try
            {
                int  resultado = adapter.InsertarProveedor(proveedor.RutProveedor,
                                                            proveedor.UsuarioProveedor,
                                                            proveedor.Password,
                                                            proveedor.NombreProveedor,
                                                            proveedor.RubroProveedor,
                                                            proveedor.Direccion,
                                                            proveedor.Telefono,
                                                            proveedor.CorreoElectronico);

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

        //Método modificar
        public bool ActualizarProveedor(Proveedores proveedor)
        {
            try
            {
                int resultado = adapter.ModificarProveedor(proveedor.NombreProveedor,
                                                           proveedor.Direccion,
                                                           proveedor.RubroProveedor,
                                                           proveedor.Telefono,
                                                           proveedor.CorreoElectronico,
                                                           proveedor.RutProveedor);
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

        //Método eliminar proveedor

        public bool EliminarProveedor(string rut)
        {
            try
            {
                int resultado = adapter.EliminarProveedor(rut);

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
    }
}
