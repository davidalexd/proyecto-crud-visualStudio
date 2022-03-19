using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapNegocio;
using System.Data.SqlClient;
using CapEntidad;
namespace CapPresentacion
{
    public partial class Form4 : Form
    {
        EmpleadoCN objcn = new EmpleadoCN();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoCE ob = new EmpleadoCE();

            ob.Musuario = txtusuario.Text;
            ob.Mclave = txtclave.Text;

            SqlDataReader login = objcn.IniciarSessionEmpleado(ob);
            if (login.Read())
            {
                if (login["estado"].ToString() == "1")
                {
                    MessageBox.Show("Usuario activo");
                    this.Hide();
                    Form2 objfp = new Form2();
                    objfp.Show();
                }

                else 
                {
                    MessageBox.Show("Usuario inactivo", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta ", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
