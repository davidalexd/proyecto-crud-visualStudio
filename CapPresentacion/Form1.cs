using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapNegocio;
using CapEntidad;
using System.Windows.Forms;

namespace CapPresentacion
{
    public partial class Form1 : Form
    {
        ContratistaCN objCon = new ContratistaCN();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            dgContratista.DataSource = objCon.LISTACONTRATISTA();

        }

        private void dgContratista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtcodigo.Text = dgContratista.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgContratista.CurrentRow.Cells[1].Value.ToString();
            txtpaterno.Text = dgContratista.CurrentRow.Cells[2].Value.ToString();
            txtmaterno.Text = dgContratista.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgContratista.CurrentRow.Cells[4].Value.ToString();
            txtcorreo.Text = dgContratista.CurrentRow.Cells[5].Value.ToString();

        }
        String valida()
        {
            if (txtnombre.Text.Trim().Length ==0)
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
                return "Correo Materno contratista";
            }
            else
            {
                return "";
            }

        }

        private void btnactualizar_Click(object sender, EventArgs e)
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
                    objCon.ACTUALIZARCONTRA(objCE);
                    MessageBox.Show("CONTRATISTA ACTUALIZADO CORRECTAMENTE", "ACTUALIZA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgContratista.DataSource = objCon.LISTACONTRATISTA();
                }
                catch (Exception)
                {

                }

            }
            else MessageBox.Show("ERROR SE ENCUENTRA EN " + valida());
        }

        private void pnbuscar_Click(object sender, EventArgs e)
        {


        }

        private void v1_Click(object sender, EventArgs e)
        {
            
            Form2 formulario2 = new Form2();
            formulario2.Show();
            Visible = false;
         
            
         
            
     



        }

        private void v2_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
            Visible = false;

        }
    }
}
