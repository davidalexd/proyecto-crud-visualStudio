using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapEntidad
{
    public class EmpleadoCE
    {
        private String _Usuario;
        private String _Clave;


        public String Musuario
        {
            set { _Usuario = value; }
            get { return _Usuario; }
        }
        public String Mclave
        {
            set { _Clave = value; }
            get { return _Clave; }
        }
    }
}
