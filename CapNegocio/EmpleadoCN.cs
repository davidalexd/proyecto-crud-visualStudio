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
    public class EmpleadoCN
    {
        cdEmpleado objDao = new cdEmpleado();
        public SqlDataReader IniciarSessionEmpleado(EmpleadoCE ce)
        {
            return objDao.IniciarSession(ce);
        }
    }
}
