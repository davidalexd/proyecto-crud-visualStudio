
namespace CapPresentacion
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dgbuscar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.v31 = new System.Windows.Forms.Button();
            this.v32 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbuscar
            // 
            this.dgbuscar.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbuscar.Location = new System.Drawing.Point(14, 47);
            this.dgbuscar.Name = "dgbuscar";
            this.dgbuscar.Size = new System.Drawing.Size(819, 167);
            this.dgbuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR POR CÓDIGO :";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(394, 294);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(257, 21);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnbuscar.Location = new System.Drawing.Point(673, 322);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(125, 54);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // v31
            // 
            this.v31.BackColor = System.Drawing.Color.SpringGreen;
            this.v31.Location = new System.Drawing.Point(14, 14);
            this.v31.Name = "v31";
            this.v31.Size = new System.Drawing.Size(99, 27);
            this.v31.TabIndex = 4;
            this.v31.Text = "ACTUALIZAR";
            this.v31.UseVisualStyleBackColor = false;
            this.v31.Click += new System.EventHandler(this.v31_Click);
            // 
            // v32
            // 
            this.v32.BackColor = System.Drawing.Color.Turquoise;
            this.v32.Location = new System.Drawing.Point(120, 14);
            this.v32.Name = "v32";
            this.v32.Size = new System.Drawing.Size(97, 27);
            this.v32.TabIndex = 5;
            this.v32.Text = "REGISTRAR";
            this.v32.UseVisualStyleBackColor = false;
            this.v32.Click += new System.EventHandler(this.v32_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(847, 435);
            this.Controls.Add(this.v32);
            this.Controls.Add(this.v31);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO BUSCAR";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button v31;
        private System.Windows.Forms.Button v32;
    }
}