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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se piden datos para creacion de usuario 
            string nombre = "";
            string apellido = "";
            string nombre_usuario = "";
            string contraseña = "";
            string contraseña2 = "";
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Por favor ingrese su nombre: ");
            apellido = Microsoft.VisualBasic.Interaction.InputBox("Por favor ingrese su apellido: ");
            nombre_usuario = Microsoft.VisualBasic.Interaction.InputBox("Por favor cree un nombre de usuario: ");
            contraseña = Microsoft.VisualBasic.Interaction.InputBox("Por favor cree una contraseña: ");
            contraseña2 = Microsoft.VisualBasic.Interaction.InputBox("Confirmar contraseña: ");
            if (contraseña2 != contraseña)
            {
                MessageBox.Show("Contraseña incorrecta, pruebe nuevamente.");
            }
            MessageBox.Show("Usuario creado con exito" + " Su usuario es: " + nombre_usuario + " Su contraseña es: " + contraseña2);
            MessageBox.Show("Puede ingresar a la biblioteca.");
            frmInterfaz_Usuario frm_biblioteca = new frmInterfaz_Usuario();
            frm_biblioteca.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Validacion de datos usuario ya creado
            if ((txtUsuarioU.Text == "Usuario") && (txtContraseñaU.Text == "U12345"))
            {
                frmInterfaz_Usuario frm_biblioteca = new frmInterfaz_Usuario();
                frm_biblioteca.ShowDialog();
            }
            else if ((txtUsuarioU.Text != "") && (txtContraseñaU.Text != ""))
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos, ingrese nuevamente.");
                txtUsuarioU.Clear();
                txtContraseñaU.Clear();
                
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre y contraseña.");
            }
            
        }
    }
}
