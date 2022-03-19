using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapDatos;
using CapEntidad;


namespace CapNegocio
{
    public class ContratistaCN
    {
        ContratistaDao objDAO = new ContratistaDao();
        public void ACTUALIZARCONTRA(ContratistaCE c)
        {
            objDAO.ACTUALIZACONTRA(c);
        }
        public DataTable LISTACONTRATISTA()
        {
            return objDAO.LISTACONTRATISTA();
        }
        public string NUEVOCODIGO()
        {
            return objDAO.NUEVOCODIGO();
        }
        public void NUEVOCONTRA(ContratistaCE c)
        {
            objDAO.NUEVOCONTRA(c);
        }
        public DataTable BUSCARCONTRATISTA(ContratistaCE C)
        {
            return objDAO.BUSCARCONTRATISTA(C);
        }

    }
}
