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
    public partial class frmInterfaz_Admin : Form
    {
        public frmInterfaz_Admin()
        {
            InitializeComponent();
        }
        private string[,] libreria;
        private string libros;
        private string autor;
        private int cantidad = 1;
        //Encapsulamiento de atributos para posterior uso
        public string[,] Libreria { get => libreria; set => libreria = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Libros { get => libros; set => libros = value; }
        public void Inventario()
        {
            //Llenado de matriz para la libreria
            try
            {
                Cantidad = Convert.ToInt32(txtCantidad.Text);
            } catch
            {
                Cantidad = 1;
            }
            Libreria = new string[Cantidad, 3];
            for (int i = 0; i < Cantidad; i++)
            {
                Libreria[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del autor : " + (i + 1));
                Libreria[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del libro: " + (i + 1));
                Libreria[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad en biblioteca: " + (i + 1));
            }
            for (int i = 0; i < Cantidad; i++)
            {
                //Impresion de datos de matriz
                dtgLibreria.Rows.Insert(0, Libreria[i, 0], Libreria[i, 1], Libreria[i, 2]);
            }
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            //Invocacion de metodo
            Inventario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salida nuevamente al menu de bienvenida
            frmBienvenida frmBienvenida = new frmBienvenida();
            frmBienvenida.ShowDialog();
        }
    }
}
