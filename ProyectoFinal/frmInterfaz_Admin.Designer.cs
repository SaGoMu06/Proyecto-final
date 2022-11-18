namespace ProyectoFinal
{
    partial class frmInterfaz_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterfaz_Admin));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtgLibreria = new System.Windows.Forms.DataGridView();
            this.Column1Autores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Libros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibreria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(61, 143);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de libros a ingresar";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(250, 60);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // dtgLibreria
            // 
            this.dtgLibreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibreria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Autores,
            this.Column2Libros,
            this.Column3Cantidad});
            this.dtgLibreria.Location = new System.Drawing.Point(405, 39);
            this.dtgLibreria.Name = "dtgLibreria";
            this.dtgLibreria.Size = new System.Drawing.Size(343, 183);
            this.dtgLibreria.TabIndex = 7;
            // 
            // Column1Autores
            // 
            this.Column1Autores.HeaderText = "Autores";
            this.Column1Autores.Name = "Column1Autores";
            // 
            // Column2Libros
            // 
            this.Column2Libros.HeaderText = "Libros";
            this.Column2Libros.Name = "Column2Libros";
            // 
            // Column3Cantidad
            // 
            this.Column3Cantidad.HeaderText = "Cantidad";
            this.Column3Cantidad.Name = "Column3Cantidad";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(201, 143);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInterfaz_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 247);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgLibreria);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmInterfaz_Admin";
            this.Text = "frmInterfaz_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibreria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dtgLibreria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Autores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Libros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3Cantidad;
        private System.Windows.Forms.Button btnSalir;
    }
}