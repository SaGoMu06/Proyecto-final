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
    public partial class frmAdministrador:Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Se piden datos para la creacion de un usario
            string nombre="";
            string apellido = "";
            string nombre_usuario = "";
            string contraseña="";
            string contraseña2="";
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Por favor ingrese su nombre: ");
            apellido = Microsoft.VisualBasic.Interaction.InputBox("Por favor ingrese su apellido: ");
            nombre_usuario = Microsoft.VisualBasic.Interaction.InputBox("Por favor cree un nombre de usuario: ");
            contraseña = Microsoft.VisualBasic.Interaction.InputBox("Por favor cree una contraseña: ");
            contraseña2 = Microsoft.VisualBasic.Interaction.InputBox("Confirmar contraseña: ");
            if(contraseña2!=contraseña)
            {
                MessageBox.Show("Contraseña incorrecta, pruebe nuevamente.");
            }
            MessageBox.Show("Usuario creado con exito" + " Su usuario es: " + nombre_usuario + " Su contraseña es: " + contraseña2);
            MessageBox.Show("Puede ingresar a la biblioteca.");
            frmBiblioteca frm_biblioteca = new frmBiblioteca();
            frm_biblioteca.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Confirmacion de datos de usuario existente para acceso
            if ((txtUsuarioA.Text=="Santiago")&&(txtContraseñaA.Text=="Sagomu123"))
            {
                frmInterfaz_Admin frm_bibliotecaAdmin = new frmInterfaz_Admin();
                frm_bibliotecaAdmin.ShowDialog();
            }
            else if ((txtUsuarioA.Text != "") && (txtContraseñaA.Text != ""))
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos, ingrese nuevamente.");
                txtUsuarioA.Clear();
                txtContraseñaA.Clear();

            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre y contraseña.");
            }


        }
    }
}
