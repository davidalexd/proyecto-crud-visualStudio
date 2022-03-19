using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapEntidad;

namespace CapDatos
{
    public class cdEmpleado
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();
        public SqlDataReader IniciarSession(EmpleadoCE var)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_logueo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.Parameters.Add("@usu", SqlDbType.VarChar).Value = var.Musuario;
            cmd.Parameters.Add("@cla", SqlDbType.VarChar).Value = var.Mclave;

            SqlDataReader leer = cmd.ExecuteReader();
            return leer;

        }

    }
}
