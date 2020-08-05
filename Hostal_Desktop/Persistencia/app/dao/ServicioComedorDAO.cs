using Modelo.application.model;
using Persistencia.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.app.dao
{
    public class ServicioComedorDAO
    {


        private SERVICIO_COMEDORTableAdapter adapter;
        public ServicioComedorDAO()
        {
            adapter = new SERVICIO_COMEDORTableAdapter();
        }

        public bool InsertarServicio(ServicioComedor servicioComedor)
        {
            try
            {
                int resultado = adapter.Insert(servicioComedor.IdComedor,
                                                servicioComedor.TipoServicio,
                                                servicioComedor.NumeroFactura);
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
