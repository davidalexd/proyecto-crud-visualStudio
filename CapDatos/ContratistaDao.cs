using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using CapEntidad;

namespace CapDatos
{
    public class ContratistaDao
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();

        public void ACTUALIZACONTRA(ContratistaCE c)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_ACTUALIZACONTRATISTA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@COD", SqlDbType.Char).Value = c.codigo;
            cmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = c.nombre;
            cmd.Parameters.Add("@PAT", SqlDbType.VarChar).Value = c.paterno;
            cmd.Parameters.Add("@MAT", SqlDbType.VarChar).Value = c.materno;
            cmd.Parameters.Add("@FON", SqlDbType.VarChar).Value = c.telefono;
            cmd.Parameters.Add("@EMA", SqlDbType.VarChar).Value = c.correo;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }

        }
        
        public DataTable LISTACONTRATISTA()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTARCONTRATISTA", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable BUSCARCONTRATISTA(ContratistaCE C)
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCARCONTRATISTA", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@COD",SqlDbType.VarChar).Value = C.codigo;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public string NUEVOCODIGO()
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_ULTIMOCODIGO", cn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            int codigo = int.Parse(cmd.ExecuteScalar().ToString().Substring(3, 3)) + 1;
            return "CON" + codigo.ToString("000");
        }
        public void NUEVOCONTRA(ContratistaCE c)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_NUEVOCONTRATISTA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@COD", SqlDbType.Char).Value = c.codigo;
            cmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = c.nombre;
            cmd.Parameters.Add("@PAT", SqlDbType.VarChar).Value = c.paterno;
            cmd.Parameters.Add("@MAT", SqlDbType.VarChar).Value = c.materno;
            cmd.Parameters.Add("@FON", SqlDbType.VarChar).Value = c.telefono;
            cmd.Parameters.Add("@EMA", SqlDbType.VarChar).Value = c.correo;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }

        }

        public void ELIMINARCONTRATISTA(ContratistaCE c)
        {
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_ELIMINARCONTRATISTA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@COD", SqlDbType.Char).Value = c.codigo;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }

        }


    }
}
