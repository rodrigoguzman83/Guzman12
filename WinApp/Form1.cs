using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmListadoArticulos frmListadoArticulos = new frmListadoArticulos();
            frmListadoArticulos.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmListadoCategoria frmListadoCategoria = new frmListadoCategoria();
            frmListadoCategoria.ShowDialog();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmListadoArticulos frmListadoArticulos = new frmListadoArticulos();
            frmListadoArticulos.ShowDialog();
        }
    }
}
