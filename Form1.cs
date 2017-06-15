using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbolesBinarios
{
    public partial class Form1 : Form
    {
        Nodo Nodo = new Nodo();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Nodo.agregar(Convert.ToInt32(txtAgregar.Text));
            txtAgregar.Text = "";
        }

        private void txtBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void cmdInOrden_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = Nodo.inOrden();
        }

        private void cmdPostOrden_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = Nodo.postOrden();
        }

        private void cmdPreOrden_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = Nodo.preOrden();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = Nodo.busqueda(Convert.ToInt32(txtBusqueda.Text));
        }
    }
}
