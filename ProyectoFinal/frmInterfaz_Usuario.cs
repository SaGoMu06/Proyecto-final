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
    public partial class frmInterfaz_Usuario : Form
    {
        public frmInterfaz_Usuario()
        {
            InitializeComponent();
        }
        
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            frmInterfaz_Admin frmDatosAdmin_usuario = new frmInterfaz_Admin();
            frmDatosAdmin_usuario.Libros=txtLibros.Text;
            frmDatosAdmin_usuario.Autor=txtAutores.Text;
            frmDatosAdmin_usuario.Cantidad = Convert.ToInt32(txtCantidad.Text);
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            frmBienvenida Regreso_inicio = new frmBienvenida();
            Regreso_inicio.ShowDialog();
            
        }
    }
}
