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
    public class HuespedDAO
    {

        HUESPEDESTableAdapter adapter;

        public HuespedDAO()
        {
            adapter = new HUESPEDESTableAdapter();
        }


        public bool InsertarHuesped(Huespedes huesped)
        {
            try
            {
                int resultado = adapter.Insert(huesped.RutHuesped,
                                               huesped.NombreHuesped,
                                               huesped.ApellidoHuesped,
                                               huesped.Habitacion,
                                               huesped.OrdenDeCompra,
                                               huesped.Cliente);
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
     

        public List<Huespedes> BuscarHuesped(string rut)
        {
            List<Huespedes> huespedes = new List<Huespedes>();
            try
            {
                foreach (HUESPEDESRow fila  in adapter.BuscarHuesped(rut).Rows)
                {
                    Huespedes huesped = new Huespedes();
                    huesped.RutHuesped = fila.RUT_HUESPED;
                    huesped.NombreHuesped = fila.NOMBRE_HUESPED;
                    huesped.ApellidoHuesped = fila.APELLIDO_HUESPED;
                    huesped.Habitacion = (int)fila.HABITACIONES_ID_HABITACION;
                    huesped.OrdenDeCompra = (int)fila.ORDENES_COMPRA_NUMERO_ORDEN;
                    huesped.Cliente = fila.CLIENTES_RUT_CLIENTE;

                    huespedes.Add(huesped);
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }

            return huespedes;
        }

        public bool ActualizarHuesped(Huespedes huesped)
        {
            try
            {
                int resultado = adapter.ModificarHuesped(huesped.RutHuesped,
                                                         huesped.NombreHuesped,
                                                         huesped.ApellidoHuesped,
                                                         huesped.Habitacion,
                                                         huesped.OrdenDeCompra,
                                                         huesped.Cliente,
                                                         huesped.RutHuesped);

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


        public bool ElimarHuesped(string rut)
        {
            try
            {
                int resultado = adapter.EliminarHuesped(rut);

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

        //public bool InsertarHuesped(Huespedes huesped)
        //{
        //    try
        //    {
        //        int resultado = adapter.INSERTAR_HUESPED(huesped.RutHuesped,
        //                                                 huesped.NombreHuesped,
        //                                                 huesped.ApellidoHuesped,
        //                                                 huesped.Habitacion,
        //                                                 huesped.OrdenDeCompra,
        //                                                 huesped.Cliente);
        //        if (resultado == 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Debug.WriteLine(ex.Message);
        //        return false;
        //    }
        //}

    }
}
