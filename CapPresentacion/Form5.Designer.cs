
namespace CapPresentacion
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabgeneral = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.lbltotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscarArticulos = new System.Windows.Forms.TextBox();
            this.dglistado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel = new System.Windows.Forms.TabPage();
            this.picimagen = new System.Windows.Forms.PictureBox();
            this.btncargarimagen = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.lbcategoria = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabgeneral.SuspendLayout();
            this.tabpage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistado)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.tabpage1);
            this.tabgeneral.Controls.Add(this.panel);
            this.tabgeneral.Location = new System.Drawing.Point(12, 51);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.SelectedIndex = 0;
            this.tabgeneral.Size = new System.Drawing.Size(776, 363);
            this.tabgeneral.TabIndex = 0;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.lbltotal);
            this.tabpage1.Controls.Add(this.button1);
            this.tabpage1.Controls.Add(this.txtbuscarArticulos);
            this.tabpage1.Controls.Add(this.dglistado);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(768, 337);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Listado";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(542, 313);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(35, 13);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbuscarArticulos
            // 
            this.txtbuscarArticulos.Location = new System.Drawing.Point(20, 25);
            this.txtbuscarArticulos.Name = "txtbuscarArticulos";
            this.txtbuscarArticulos.Size = new System.Drawing.Size(297, 20);
            this.txtbuscarArticulos.TabIndex = 1;
            // 
            // dglistado
            // 
            this.dglistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dglistado.Location = new System.Drawing.Point(20, 64);
            this.dglistado.Name = "dglistado";
            this.dglistado.Size = new System.Drawing.Size(726, 246);
            this.dglistado.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.picimagen);
            this.panel.Controls.Add(this.btncargarimagen);
            this.panel.Controls.Add(this.txtimagen);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.cbocategoria);
            this.panel.Controls.Add(this.lbcategoria);
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtdescripcion);
            this.panel.Controls.Add(this.txtnombre);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Location = new System.Drawing.Point(4, 22);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(3);
            this.panel.Size = new System.Drawing.Size(768, 337);
            this.panel.TabIndex = 1;
            this.panel.Text = "Mantenimiento";
            this.panel.UseVisualStyleBackColor = true;
            // 
            // picimagen
            // 
            this.picimagen.Location = new System.Drawing.Point(590, 120);
            this.picimagen.Name = "picimagen";
            this.picimagen.Size = new System.Drawing.Size(136, 156);
            this.picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimagen.TabIndex = 14;
            this.picimagen.TabStop = false;
            // 
            // btncargarimagen
            // 
            this.btncargarimagen.Location = new System.Drawing.Point(712, 72);
            this.btncargarimagen.Name = "btncargarimagen";
            this.btncargarimagen.Size = new System.Drawing.Size(37, 23);
            this.btncargarimagen.TabIndex = 13;
            this.btncargarimagen.Text = "...";
            this.btncargarimagen.UseVisualStyleBackColor = true;
            this.btncargarimagen.Click += new System.EventHandler(this.btncargarimagen_Click);
            // 
            // txtimagen
            // 
            this.txtimagen.Enabled = false;
            this.txtimagen.Location = new System.Drawing.Point(590, 75);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(116, 20);
            this.txtimagen.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // cbocategoria
            // 
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(236, 38);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(121, 21);
            this.cbocategoria.TabIndex = 9;
            // 
            // lbcategoria
            // 
            this.lbcategoria.AutoSize = true;
            this.lbcategoria.Location = new System.Drawing.Point(162, 38);
            this.lbcategoria.Name = "lbcategoria";
            this.lbcategoria.Size = new System.Drawing.Size(52, 13);
            this.lbcategoria.TabIndex = 8;
            this.lbcategoria.Text = "Categoria";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(*) indicar que el dato es obligatorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(236, 108);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(244, 126);
            this.txtdescripcion.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(236, 82);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(244, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabgeneral);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabgeneral.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglistado)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabgeneral;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage panel;
        private System.Windows.Forms.DataGridView dglistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbuscarArticulos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbcategoria;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.PictureBox picimagen;
        private System.Windows.Forms.Button btncargarimagen;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Label label4;
    }
}