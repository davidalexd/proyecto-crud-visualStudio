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
    public partial class Form3 : Form
    {
        ContratistaCN obj = new ContratistaCN();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgbuscar.DataSource = obj.LISTACONTRATISTA();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ContratistaCE dato = new ContratistaCE();
            dato.codigo = txtcodigo.Text;
            dgbuscar.DataSource = obj.BUSCARCONTRATISTA(dato);


        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void v31_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            formulario1.Show();
            Visible = false;

        }

        private void v32_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            formulario2.Show();
            Visible = false;
        }
    }
}
