using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapDatos;
using CapEntidad;

namespace CapNegocio
{

    public class NCategoria
    {
        public static DataTable Listar()
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.BuscarCategoriadatos(valor);
        }
        public static DataTable SeleccionarCategoria()
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Seleccionar();
        }
        public static DataTable InsertarCategoria(Categoria c)
        {
            Dcategoria Datos = new Dcategoria();
            return Datos.Insertar(c);
        }
    }
}
