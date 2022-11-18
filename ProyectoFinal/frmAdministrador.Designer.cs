namespace ProyectoFinal
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.txtContraseñaA = new System.Windows.Forms.TextBox();
            this.txtUsuarioA = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContraseñaA
            // 
            this.txtContraseñaA.Location = new System.Drawing.Point(126, 207);
            this.txtContraseñaA.Name = "txtContraseñaA";
            this.txtContraseñaA.PasswordChar = '*';
            this.txtContraseñaA.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaA.TabIndex = 11;
            // 
            // txtUsuarioA
            // 
            this.txtUsuarioA.Location = new System.Drawing.Point(126, 73);
            this.txtUsuarioA.Name = "txtUsuarioA";
            this.txtUsuarioA.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioA.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Crear cuenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(52, 258);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(72, 56);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 340);
            this.Controls.Add(this.txtContraseñaA);
            this.Controls.Add(this.txtUsuarioA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdministrador";
            this.Text = "frmAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaA;
        private System.Windows.Forms.TextBox txtUsuarioA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}