
namespace CapPresentacion
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgContratista = new System.Windows.Forms.DataGridView();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContratista
            // 
            this.dgContratista.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgContratista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContratista.Location = new System.Drawing.Point(3, 45);
            this.dgContratista.Name = "dgContratista";
            this.dgContratista.Size = new System.Drawing.Size(825, 143);
            this.dgContratista.TabIndex = 0;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(287, 215);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(203, 21);
            this.txtcodigo.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(287, 255);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(203, 21);
            this.txtnombre.TabIndex = 4;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(287, 297);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(203, 21);
            this.txtpaterno.TabIndex = 6;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(596, 218);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(231, 21);
            this.txttelefono.TabIndex = 8;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(596, 256);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(231, 21);
            this.txtcorreo.TabIndex = 12;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(287, 346);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(203, 21);
            this.txtmaterno.TabIndex = 14;
            this.txtmaterno.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "CÓDIGO :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "NOMBRES :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "PATERNO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "TELÉFONO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "MATERNO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "CORREO :";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnregistrar.Location = new System.Drawing.Point(608, 317);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(134, 52);
            this.btnregistrar.TabIndex = 21;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(24, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(131, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(842, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.dgContratista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO REGISTRAR";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgContratista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgContratista;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}