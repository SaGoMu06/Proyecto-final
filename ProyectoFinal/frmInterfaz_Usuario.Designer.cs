namespace ProyectoFinal
{
    partial class frmInterfaz_Usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterfaz_Usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.txtLibros = new System.Windows.Forms.TextBox();
            this.frmInterfazAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmInterfazAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(202, 209);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(140, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(560, 75);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 28);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir2
            // 
            this.btnSalir2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.Location = new System.Drawing.Point(560, 177);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(88, 28);
            this.btnSalir2.TabIndex = 8;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // txtAutores
            // 
            this.txtAutores.Location = new System.Drawing.Point(202, 50);
            this.txtAutores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(140, 22);
            this.txtAutores.TabIndex = 9;
            // 
            // txtLibros
            // 
            this.txtLibros.Location = new System.Drawing.Point(202, 122);
            this.txtLibros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibros.Name = "txtLibros";
            this.txtLibros.Size = new System.Drawing.Size(140, 22);
            this.txtLibros.TabIndex = 10;
            // 
            // frmInterfazAdminBindingSource
            // 
            this.frmInterfazAdminBindingSource.DataSource = typeof(ProyectoFinal.frmInterfaz_Admin);
            // 
            // frmInterfaz_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 415);
            this.Controls.Add(this.txtLibros);
            this.Controls.Add(this.txtAutores);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInterfaz_Usuario";
            this.Text = "frmInterfaz_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.frmInterfazAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.BindingSource frmInterfazAdminBindingSource;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.TextBox txtLibros;
    }
}