using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmBienvenida :Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instancia el formulario de usuario
            frmUsuario FormUsuario = new frmUsuario();
            FormUsuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instancia fornulario de administrador
            frmAdministrador FormAdmin=new frmAdministrador();
            FormAdmin.Show();
            
        }
    }
}
