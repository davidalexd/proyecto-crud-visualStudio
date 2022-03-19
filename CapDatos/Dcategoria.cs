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
    public class Dcategoria
    {
        SqlConnection cn;
        Conexion obj = new Conexion();
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            try
            {
                cn = obj.getConecta();
                cn.Open();
                SqlCommand comando = new SqlCommand("SP_LISTACATEGORIA", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
                Resultado = comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }
        public DataTable Insertar(Categoria c)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            try
            {
                cn = obj.getConecta();
                cn.Open();
                SqlCommand comando = new SqlCommand("SP_INSERTARCATEGORIA", cn);
                comando.CommandType = CommandType.StoredProcedure;
                
             

                comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = c.Nombre;
                comando.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = c.Descripcion;

                Resultado = comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }


        public DataTable BuscarCategoriadatos(string valor)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            try
            {
                cn = obj.getConecta();
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_BUSCACATEGORIA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TEXTO", SqlDbType.VarChar).Value = valor;
                Resultado = cmd.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {

                if (cn.State == ConnectionState.Open) cn.Close();

            }

        }

        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            try
            {
                cn = obj.getConecta();
                cn.Open();
                SqlCommand comando = new SqlCommand("SP_SELECCIONARCATEGORIA", cn);
                comando.CommandType = CommandType.StoredProcedure;

                Resultado = comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open) cn.Close();
            }
        }


    }
}
