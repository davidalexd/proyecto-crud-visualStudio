
namespace CapPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.dgContratista = new System.Windows.Forms.DataGridView();
            this.v1 = new System.Windows.Forms.Button();
            this.v2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(264, 224);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(202, 21);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(264, 269);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(202, 21);
            this.txtnombre.TabIndex = 1;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(264, 311);
            this.txtpaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(202, 21);
            this.txtpaterno.TabIndex = 2;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(599, 254);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(228, 21);
            this.txtcorreo.TabIndex = 3;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(599, 219);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(223, 21);
            this.txttelefono.TabIndex = 4;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(264, 364);
            this.txtmaterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(202, 21);
            this.txtmaterno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "CÓDIGO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRES :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "PATERNO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "TELÉFONO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "MATERNO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "CORREO :";
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnactualizar.Location = new System.Drawing.Point(618, 307);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(128, 53);
            this.btnactualizar.TabIndex = 12;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // dgContratista
            // 
            this.dgContratista.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgContratista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContratista.Location = new System.Drawing.Point(3, 53);
            this.dgContratista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgContratista.Name = "dgContratista";
            this.dgContratista.Size = new System.Drawing.Size(824, 131);
            this.dgContratista.TabIndex = 13;
            this.dgContratista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgContratista_MouseDoubleClick);
            // 
            // v1
            // 
            this.v1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.v1.Location = new System.Drawing.Point(16, 15);
            this.v1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(107, 26);
            this.v1.TabIndex = 14;
            this.v1.Text = "REGISTRAR";
            this.v1.UseVisualStyleBackColor = false;
            this.v1.Click += new System.EventHandler(this.v1_Click);
            // 
            // v2
            // 
            this.v2.BackColor = System.Drawing.Color.Turquoise;
            this.v2.Location = new System.Drawing.Point(128, 14);
            this.v2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(87, 26);
            this.v2.TabIndex = 15;
            this.v2.Text = "BUSCAR";
            this.v2.UseVisualStyleBackColor = false;
            this.v2.Click += new System.EventHandler(this.v2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(837, 436);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.dgContratista);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO ACTUALIZAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.DataGridView dgContratista;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Button v2;
    }
}

