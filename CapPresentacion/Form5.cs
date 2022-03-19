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
    public partial class Form5 : Form
    {
        
        private string RutaOrigen;
        private string RutaDestino;
        private string Diretorio = "M:\\fotos\\";
        private string NombreAnt;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Listar();
            CargarCategoria();

        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CargarCategoria()
        {
            try
            {
                cbocategoria.DataSource = NCategoria.SeleccionarCategoria();
                cbocategoria.DisplayMember = "nombre";
                cbocategoria.ValueMember = "idcategoria";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BuscarArticulos()
        {
            try
            {
                dglistado.DataSource = NCategoria.Buscar(txtbuscarArticulos.Text);
                Formato();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listar()
        {
            try
            {
                dglistado.DataSource = NCategoria.Listar();
                Formato();
                lbltotal.Text = "Total de Registros :" + Convert.ToString(dglistado.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Guardar()
        {
            try
            {
                Categoria objCE = new Categoria();

                objCE.Nombre = txtnombre.Text;
                objCE.Descripcion = txtdescripcion.Text;
          
                NCategoria.InsertarCategoria(objCE);
                MessageBox.Show(" REGISTRADO CORRECTAMENTE", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            dglistado.Columns[0].Visible = false;
            dglistado.Columns[1].Visible = false;
            dglistado.Columns[2].Width= 150;
            dglistado.Columns[3].Width = 400;
            dglistado.Columns[4].Width = 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarArticulos();
        }

        private void btncargarimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Image file(*.jpg ,*.jpeg,*.jpe,*.jfif,*.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (File.ShowDialog() == DialogResult.OK)
            {
                picimagen.Image = Image.FromFile(File.FileName);
                txtimagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\\") + 1);
                this.RutaOrigen = File.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
            Listar();
            CargarCategoria();
        }
    }
}
