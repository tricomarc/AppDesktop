using Modelo.application.model;
using Persistencia.app.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.application.business
{
    public class HuespedBusiness
    {
        private HuespedDAO huespedDAO;
        
        public HuespedBusiness()
        {
            huespedDAO = new HuespedDAO();
        }

        public void AgregarHuesped(Huespedes huesped)
        {
            huespedDAO.InsertarHuesped(huesped);
        }


        public List<Huespedes> ListarHuesped(string rut)
        {
            return huespedDAO.BuscarHuesped(rut);
        }


        public void ActualizarHuesped(Huespedes huesped)
        {
            huespedDAO.ActualizarHuesped(huesped);
        }


        public void EliminarHuesped(Huespedes huesped)
        {
            huespedDAO.ElimarHuesped(huesped.RutHuesped);
        }
    }
}
