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
using CapEntidad;

namespace CapPresentacion
{
    public partial class Form2 : Form
    {
        ContratistaCN objCon = new ContratistaCN();

        public Form2()
        {
            InitializeComponent();
        }

        String valida()
        {
            if (txtnombre.Text.Trim().Length == 0)
            {
                return "Nombre del contratista";
            }
            else if (txtpaterno.Text.Trim().Length == 0)
            {
                return "Apellidos Paternos contratista";
            }
            else if (txtmaterno.Text.Trim().Length == 0)
            {
                return "Apellidos Materno contratista";
            }
            else if (txttelefono.Text.Trim().Length == 0)
            {
                return "Telefono Maternos contratista";
            }
            else if (txtcorreo.Text.Trim().Length == 0)
            {
                return "Correo Maternos contratista";
            }
            else
            {
                return "";
            }

        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void generarcodigo()
        {
            txtcodigo.Text = objCon.NUEVOCODIGO();
            txtnombre.Text=  "";
            txtpaterno.Text="";
            txtmaterno.Text= "";
            txttelefono.Text= "";
            txtcorreo.Text= "";


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            generarcodigo();
            dgContratista.DataSource = objCon.LISTACONTRATISTA();

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
            if (valida() == "")
            {
                ContratistaCE objCE = new ContratistaCE();
                objCE.codigo = txtcodigo.Text;
                objCE.nombre = txtnombre.Text;
                objCE.paterno = txtpaterno.Text;
                objCE.materno = txtmaterno.Text;
                objCE.telefono = txttelefono.Text;
                objCE.correo = txtcorreo.Text;
                

                try
                {
                    objCon.NUEVOCONTRA(objCE);
                    MessageBox.Show("CONTRATISTA REGISTRADO CORRECTAMENTE", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgContratista.DataSource = objCon.LISTACONTRATISTA();
                    generarcodigo();
                }
                catch (Exception)
                {

                }

            }
            else MessageBox.Show("ERROR SE ENCUENTRA EN " + valida());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            formulario1.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
            Visible = false;
        }
    }
}
